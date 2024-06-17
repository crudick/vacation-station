using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace VacationStation.Persistence;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<CosmosClient>(sp =>
        {
            var connectionString = configuration.GetConnectionString("Cosmos");
            return new CosmosClient(connectionString);
        });

        services.AddSingleton(sp =>
        {
            var cosmosClient = sp.GetRequiredService<CosmosClient>();
            var databaseName = configuration["Cosmos:DatabaseName"];
            var containerName = configuration["Cosmos:ContainerName"];
            return cosmosClient.GetContainer(databaseName, containerName);
        });


        services.AddSingleton(sp =>
        {
            var connectionString = configuration.GetConnectionString("Cosmos");
            var settings = new ElasticsearchClientSettings(new Uri(connectionString));
            return new ElasticsearchClient(settings);
        });

        return services;
    }
}