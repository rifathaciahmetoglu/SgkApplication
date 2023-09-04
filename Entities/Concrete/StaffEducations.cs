using Core.Entities;

namespace Entities.Concrete
{
    public class StaffEducations : IEntity
    {
        public int Id { get; set; }
        public int LicenseId { get; set; }
        public string? Chapter { get; set; }
        public bool MasterCertificate { get; set; }
        public bool MasterStudentCertificate { get; set; }
    }
}
