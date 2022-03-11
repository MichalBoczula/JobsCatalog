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
        public JobsCatalogDbContext Context { get; set; }

        public QueryTestBase()
        {
            Context = DbContexFactory.Create().Object;
        }

        public void Dispose()
        {
            DbContexFactory.CleanUp(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestBase>
    {
    }
}
