using MediatR;
using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommand : IRequest
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public ICollection<Calendar> Calendars { get; set; }
    }
}
