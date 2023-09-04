using Core.Entities;

namespace Entities
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public bool Status { get; set; }

    }
}
