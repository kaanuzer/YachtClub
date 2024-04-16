using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class Create
    {
        public class Command : IRequest
        {
            public BrokerageFirm BrokerageFirm { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                _context.BrokerageFirms.Add(request.BrokerageFirm);
                await _context.SaveChangesAsync();
            }
        }
    }
}
