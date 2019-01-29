using MediatR;
using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommand : IRequest
    {
        public int RoomId { get; set; }
    }
}
