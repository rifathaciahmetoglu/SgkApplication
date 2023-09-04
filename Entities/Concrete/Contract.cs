using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Contract : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Documentation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
