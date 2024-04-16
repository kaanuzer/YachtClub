using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class List
    {
        public class Query : IRequest<List<BrokerageFirm>> { }

        public class Handler : IRequestHandler<Query, List<BrokerageFirm>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<BrokerageFirm>> Handle(
                Query request,
                CancellationToken cancellationToken
            )
            {
                return await _context.BrokerageFirms.ToListAsync();
            }
        }
    }
}
