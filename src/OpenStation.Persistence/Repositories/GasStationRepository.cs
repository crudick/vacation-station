using Microsoft.Azure.Cosmos;
using OpenStation.Application.Interfaces;
using VacationStation.Domain.Entities;

namespace VacationStation.Persistence.Repositories;

public class GasStationRepository : IRepository<GasStation>
{
    private readonly Container _container;

    public GasStationRepository(CosmosClient cosmosClient, string databaseName, string containerName)
    {
        _container = cosmosClient.GetContainer(databaseName, containerName);
    }

    public async Task AddAsync(GasStation gasStation)
    {
        await _container.CreateItemAsync(gasStation, new PartitionKey(gasStation.Id));
    }

    public async Task<GasStation> GetByIdAsync(string id)
    {
        try
        {
            ItemResponse<GasStation> response = await _container.ReadItemAsync<GasStation>(id, new PartitionKey(id));
            return response.Resource;
        }
        catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }
    }
}