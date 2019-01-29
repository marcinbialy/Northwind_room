using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Entities
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public ICollection<Calendar> Calendars { get; set; }
    }
}
