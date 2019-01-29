using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain.Entities
{
    public class Calendar
    {
        public int CalendarId { get; set; }
        public DateTime CalendarDate { get; set; }

        public Room Room { get; set; }
    }
}
