using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Application.Rooms.Queries.GetRooms
{
    public class GetRoomsQuery : IRequest<RoomsListViewModel>
    {
    }
}
