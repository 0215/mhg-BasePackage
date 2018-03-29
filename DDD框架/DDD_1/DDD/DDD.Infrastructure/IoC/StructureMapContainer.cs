using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infrastructure.IoC
{
    public class StructureMapContainer : IIoCContainer
    {
        private IContainer _container;

        private IDictionary<Type, Type> _maps = new Dictionary<Type, Type>();

        public void Add<IT, T>()
        {
            _maps.Add(typeof(IT), typeof(T));
        }

        public void Init()
        {
            _container = new Container(m =>
            {
                m.For<IIoCContainer>().Singleton().Use(this);
                foreach (var item in _maps)
                {
                    m.For(item.Key).Use(item.Value);
                }
            });
        }

        public object GetInstance(Type type)
        {
            return _container.GetInstance(type);
        }

        public T GetInstance<T>()
        {
            return _container.GetInstance<T>();
        }

        public T[] GetAllInstance<T>()
        {
            return _container.GetAllInstances<T>().ToArray();
        }
    }
}