using AutoMapper;
using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRooms
{
    public class RoomDto
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
    }
}
