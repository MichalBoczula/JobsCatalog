using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JobsCatalog.UnitTests.Common.TestBases
{
    public class QueryTestBase : IDisposable
    {
        public JobsCatalogDbContextTransaction ContextTransaction { get; set; }
        public JobsCatalogDbContextQuery ContextQuery { get; set; }

        public QueryTestBase()
        {
            ContextTransaction = DbContexFactory.CreateTransactionDbContext().Object;
            ContextQuery = DbContexFactory.CreateQueryDbContext().Object;
        }

        public void Dispose()
        {
            DbContexFactory.CleanUp(ContextTransaction, ContextQuery);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestBase>
    {
    }
}
