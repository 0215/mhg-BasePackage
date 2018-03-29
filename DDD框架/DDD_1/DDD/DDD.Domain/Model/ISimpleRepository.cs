using DDD.Infrastructure.Repository;

namespace DDD.Domain.Model
{
    public interface ISimpleRepository : IRepository
    {
        Simple GetSimple(int id);
    }
}