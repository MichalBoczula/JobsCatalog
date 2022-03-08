using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        public JobsCatalogDbContext Context { get; set; }

        public CommandTestBase()
        {
            Context = DbContexFactory.Create().Object;
        }

        public void Dispose()
        {
            DbContexFactory.CleanUp(Context);
        }
    }

    [CollectionDefinition("CommandCollection")]
    public class CommandCollection : ICollectionFixture<CommandTestBase>
    {
    }
}
