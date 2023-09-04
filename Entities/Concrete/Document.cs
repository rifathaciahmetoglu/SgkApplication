using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Document : IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? Name { get; set; }
        public string? Documentation { get; set; }
        public DateTime Date { get; set; }
    }
}
