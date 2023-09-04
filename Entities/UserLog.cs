using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entities
{
    public class UserLog : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
