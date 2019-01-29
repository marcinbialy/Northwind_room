using MediatR;
using Northwind.Domain.Entities;
using Northwind.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
    {
        private readonly NorthwindDbContext _context;

        public CreateRoomCommandHandler(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var entity = new Room
            {
                RoomName = request.RoomName, 
            };

            _context.Rooms.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.RoomId;
        }
    }
}
