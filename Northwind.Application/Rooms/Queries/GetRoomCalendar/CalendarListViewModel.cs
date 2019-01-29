using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRoomCalendar
{
    public class CalendarListViewModel
    {
        public IEnumerable<CalendarDto> Calendars { get; set; }
    }
}
