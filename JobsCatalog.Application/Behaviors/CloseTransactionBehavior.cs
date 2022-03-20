using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Contracts.Tags;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Behaviors
{
    public class CloseTransactionBehavior<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly IJobsCatalogDbContext _context;

        public CloseTransactionBehavior(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            if (request is ICommandTag)
            {
                if (response is not null && _context.Transaction is not null)
                {
                     _context.CommitTransaction(cancellationToken);
                }
                else if (response is null && _context.Transaction is not null)
                {
                    _context.RollbackTransaction(cancellationToken);
                }
            }
        }
    }
}
