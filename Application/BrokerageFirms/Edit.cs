using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Persistence.Contexts;

namespace Application.BrokerageFirms
{
    public class Edit
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
                var brokageFirm = await _context.BrokerageFirms.FindAsync(request.BrokerageFirm.Id);
                if (brokageFirm == null)
                {
                    throw new ArgumentNullException(nameof(brokageFirm));
                }

                brokageFirm.ContactPerson =
                    request.BrokerageFirm.ContactPerson ?? brokageFirm.ContactPerson;
                brokageFirm.Email = request.BrokerageFirm.Email ?? brokageFirm.Email;
                brokageFirm.FirmName = request.BrokerageFirm.FirmName ?? brokageFirm.FirmName;
                brokageFirm.Location = request.BrokerageFirm.Location ?? brokageFirm.Location;
                brokageFirm.PhoneNumber =
                    request.BrokerageFirm.PhoneNumber ?? brokageFirm.PhoneNumber;
                brokageFirm.LastModified = DateTime.UtcNow;
                brokageFirm.LastModifiedBy =
                    request.BrokerageFirm.LastModifiedBy ?? brokageFirm.LastModifiedBy;

                await _context.SaveChangesAsync();
            }
        }
    }
}
