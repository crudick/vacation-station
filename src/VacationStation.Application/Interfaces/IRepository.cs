namespace VacationStation.Application.Interfaces;

public interface IRepository<T>
{
    Task AddAsync(T entity);
    Task<T> GetByIdAsync(string id);
}