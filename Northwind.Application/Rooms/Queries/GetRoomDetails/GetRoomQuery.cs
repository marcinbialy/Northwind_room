﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRoomDetails
{
    public class GetRoomQuery : IRequest<RoomViewModel>
    {
        public int RoomId { get; set; }
    }
}
