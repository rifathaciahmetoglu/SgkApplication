using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class ProfessionalPracticeTraining : IEntity
    {
        public int Id { get; set; }
        public string? StaffName { get; set; }
        public int NumberOfStaff { get; set; }
        public int NumberOfMaster { get; set; }
        public bool ProfessionStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
