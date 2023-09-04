using Core.Entities;
using System;

namespace Entities
{
    public class Note : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
