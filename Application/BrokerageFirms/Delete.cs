using MediatR;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
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
                var brokageFirm = await _context.BrokerageFirms.FindAsync(request.Id);

                _context.Remove(brokageFirm);
                await _context.SaveChangesAsync();
            }
        }
    }
}
