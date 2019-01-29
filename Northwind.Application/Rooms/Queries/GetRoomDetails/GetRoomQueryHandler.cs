using MediatR;
using Microsoft.EntityFrameworkCore;
using Northwind.Application.Exceptions;
using Northwind.Domain.Entities;
using Northwind.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Rooms.Queries.GetRoomDetails
{
    public class GetRoomQueryHandler : IRequestHandler<GetRoomQuery, RoomViewModel>
    {
        private readonly NorthwindDbContext _context;
       
        public GetRoomQueryHandler(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<RoomViewModel> Handle(GetRoomQuery request, CancellationToken cancellationToken)
        {
            var room = await _context.Rooms.Where(r => r.RoomId == request.RoomId).SingleOrDefaultAsync(cancellationToken);

            if (room == null)
            {
                throw new NotFoundException(nameof(Room), request.RoomId);
            }

            var model = new RoomViewModel();

            return model;
        }
    }
}
