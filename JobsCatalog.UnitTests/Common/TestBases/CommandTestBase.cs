using AutoMapper;
using JobsCatalog.Application.Mapping;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Common.TestBases
{
    public class CommandTestBase : IDisposable
    {
        public JobsCatalogDbContextTransaction ContextTransaction { get; set; }
        public JobsCatalogDbContextQuery ContextQuery { get; set; }
        public IMapper Mapper { get; private set; }

        public CommandTestBase()
        {
            ContextTransaction = DbContexFactory.CreateTransactionDbContext().Object;
            ContextQuery = DbContexFactory.CreateQueryDbContext().Object;

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            DbContexFactory.CleanUp(ContextTransaction, ContextQuery);
        }
    }

    [CollectionDefinition("CommandCollection")]
    public class CommandCollection : ICollectionFixture<CommandTestBase>
    {
    }
}
