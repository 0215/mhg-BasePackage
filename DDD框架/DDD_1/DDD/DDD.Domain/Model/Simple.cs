using DDD.Infrastructure.Domain;

namespace DDD.Domain.Model
{
    public class Simple : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}