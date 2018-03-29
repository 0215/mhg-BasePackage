using DDD.Domain.Model;

namespace DDD.Application
{
    public class SimpleService : ISimpleService
    {
        private ISimpleRepository _simpleRepository;

        public SimpleService(ISimpleRepository simpleRepository)
        {
            _simpleRepository = simpleRepository;
        }

        public Simple GetSimple(int id)
        {
            return _simpleRepository.GetSimple(id);
        }
    }
}