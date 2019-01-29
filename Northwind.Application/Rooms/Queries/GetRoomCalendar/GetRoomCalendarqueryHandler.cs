using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Northwind.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Rooms.Queries.GetRoomCalendar
{
    public class GetRoomCalendarQueryHandler : IRequestHandler<GetRoomCalendarQuery, CalendarListViewModel>
    {
        private readonly NorthwindDbContext _context;
        private readonly IMapper _mapper;

        public GetRoomCalendarQueryHandler(NorthwindDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CalendarListViewModel> Handle(GetRoomCalendarQuery request, CancellationToken cancellationToken)
        {
            var calendar = await _context.Calendars.OrderBy(c => c.CalendarId).Include(r => r.Room).ToListAsync(cancellationToken);

            var model = new CalendarListViewModel
            {
                Calendars = _mapper.Map<IEnumerable<CalendarDto>>(calendar)
            };
            
            return model;
        }
    }
}
