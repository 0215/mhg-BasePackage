using DDD.Domain.Model;
using DDD.Infrastructure.Application;

namespace DDD.Application
{
    public interface ISimpleService : IService
    {
        Simple GetSimple(int id);
    }
}