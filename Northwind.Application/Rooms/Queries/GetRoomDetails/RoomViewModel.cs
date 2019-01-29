using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRoomDetails
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public IEnumerable<Calendar> Calendars { get; set; }
    }
}
