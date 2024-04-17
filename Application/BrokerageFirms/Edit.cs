using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class Edit
    {
        public class Command : IRequest
        {
            public required BrokerageFirm BrokerageFirm { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var brokageFirm = await _context.BrokerageFirms.FindAsync(request.BrokerageFirm.Id);
                if (brokageFirm == null)
                {
                    throw new ArgumentNullException(nameof(brokageFirm));
                }

                _mapper.Map(request.BrokerageFirm, brokageFirm);

                await _context.SaveChangesAsync();
            }
        }
    }
}
