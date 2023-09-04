using Core.Entities;

namespace Entities
{
    public class Staff : IEntity
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int EducationId { get; set; }
        public char NationalId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
