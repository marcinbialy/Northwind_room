﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRoomCalendar
{
    public class GetRoomCalendarQuery : IRequest<CalendarListViewModel>
    {
    }
}
