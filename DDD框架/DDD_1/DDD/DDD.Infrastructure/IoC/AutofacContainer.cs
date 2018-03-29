using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infrastructure.IoC
{
    public class AutofacContainer : IIoCContainer
    {
        private IContainer _container;

        private IDictionary<Type, Type> _maps = new Dictionary<Type, Type>();

        public void Add<IT, T>()
        {
            _maps.Add(typeof(IT), typeof(T));
        }

        public void Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance<IIoCContainer>(this);
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(o => o.Name.EndsWith("Controller", StringComparison.Ordinal));
            foreach (var item in _maps)
            {
                builder.RegisterType(item.Value).As(item.Key);
            }
            _container = builder.Build();
        }

        public object GetInstance(Type type)
        {
            return _container.Resolve(type);
        }

        public T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }

        public T[] GetAllInstance<T>()
        {
            return this._container.Resolve<IEnumerable<T>>().ToArray();
        }
    }
}