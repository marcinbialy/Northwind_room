using MediatR;
using Microsoft.EntityFrameworkCore;
using Northwind.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryHandler : IRequestHandler<GetRoomsQuery, RoomsListViewModel>
    {
        private readonly NorthwindDbContext _context;
    

        public GetRoomsQueryHandler(NorthwindDbContext context)
        {
            _context = context;

        }

        public async Task<RoomsListViewModel> Handle(GetRoomsQuery request, CancellationToken cancellationToken)
        {
            var rooms = await _context.Rooms.Include(c => c.Calendars).ToListAsync(cancellationToken);

            var model = new RoomsListViewModel();
           
            return model;
        }
    }
}

