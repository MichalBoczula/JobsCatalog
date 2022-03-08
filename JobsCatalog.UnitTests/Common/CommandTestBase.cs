﻿using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
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
