using JobsCatalog.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.UnitTests.Common.DbContext
{
    public static class DbContexFactory
    {
        public static Mock<JobsCatalogDbContextTransaction> CreateTransactionDbContext()
        {
            var options = new DbContextOptionsBuilder<JobsCatalogDbContextTransaction>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var mock = new Mock<JobsCatalogDbContextTransaction>(options) { CallBase = true };
            mock.Object.Database.EnsureCreated();
            mock.Object.SaveChanges();
            return mock;
        }

        public static Mock<JobsCatalogDbContextQuery> CreateQueryDbContext()
        {
            var options = new DbContextOptionsBuilder<JobsCatalogDbContextQuery>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var mock = new Mock<JobsCatalogDbContextQuery>(options) { CallBase = true };
            mock.Object.Database.EnsureCreated();
            mock.Object.SaveChanges();
            return mock;
        }

        public static void CleanUp(JobsCatalogDbContextTransaction contextTransaction, JobsCatalogDbContextQuery contextQuery)
        {
            contextTransaction.Database.EnsureDeleted();
            contextQuery.Database.EnsureDeleted();
            contextQuery.Dispose();
            contextTransaction.Dispose();
        }
    }
}
