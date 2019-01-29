using MediatR;
using Northwind.Application.Exceptions;
using Northwind.Domain.Entities;
using Northwind.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, Unit>
    {
        private readonly NorthwindDbContext _context;

        public UpdateRoomCommandHandler(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Rooms.FindAsync(request.RoomId);
            
            if (entity == null)
            {
                throw new NotFoundException(nameof(Room), request.RoomId);
            }

            entity.RoomId = request.RoomId;
            entity.RoomName = request.RoomName;
            entity.Calendars = request.Calendars;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
