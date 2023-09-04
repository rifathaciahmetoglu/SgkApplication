using Core.Entities;

namespace Entities
{
    public class StaffJob : IEntity
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
}
