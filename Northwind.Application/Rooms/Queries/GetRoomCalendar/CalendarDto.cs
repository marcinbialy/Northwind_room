using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRoomCalendar
{
    public class CalendarDto
    {
        public int CalendarId { get; set; }
        public DateTime CalendarDate { get; set; }       
    }
}
