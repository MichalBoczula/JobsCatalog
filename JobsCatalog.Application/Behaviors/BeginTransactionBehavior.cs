using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Behaviors
{
    public class BeginTransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IJobsCatalogDbContext _context;

        public BeginTransactionBehavior(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (request is ICommandTag)
            {
                await _context.BeginTransaction();
            }
            return await next();
        }
    }
}
