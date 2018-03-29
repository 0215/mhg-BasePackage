using System;

namespace DDD.Infrastructure.IoC
{
    public interface IIoCContainer
    {
        void Add<IT, T>();

        void Init();

        object GetInstance(Type type);

        T GetInstance<T>();

        T[] GetAllInstance<T>();
    }
}