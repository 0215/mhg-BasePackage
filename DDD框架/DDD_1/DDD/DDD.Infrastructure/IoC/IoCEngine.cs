namespace DDD.Infrastructure.IoC
{
    public class IoCEngine
    {
        private static IIoCContainer _container;

        public static void Init(IIoCContainer container)
        {
            container.Init();
            _container = container;
        }

        public static IIoCContainer Container { get { return _container; } }
    }
}