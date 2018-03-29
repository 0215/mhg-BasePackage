using DDD.Domain.Model;

namespace Repository
{
    public class SimpleRepository : ISimpleRepository
    {
        public Simple GetSimple(int id)
        {
            return new Simple { Id = 1, Name = "Simple" };
        }
    }
}