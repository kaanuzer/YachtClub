using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class Details
    {
        public class Query : IRequest<BrokerageFirm>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, BrokerageFirm>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<BrokerageFirm> Handle(
                Query request,
                CancellationToken cancellationToken
            )
            {
                return await _context.BrokerageFirms.FindAsync(request.Id);
            }
        }
    }
}
