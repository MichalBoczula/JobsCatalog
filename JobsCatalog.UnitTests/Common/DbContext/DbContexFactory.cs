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
        public static Mock<JobsCatalogDbContext> CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<JobsCatalogDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var mock = new Mock<JobsCatalogDbContext>(options) { CallBase = true };
            mock.Object.Database.EnsureCreated();
            mock.Object.SaveChanges();
            return mock;
        }

        public static void CleanUp(JobsCatalogDbContext contextTransaction)
        {
            contextTransaction.Database.EnsureDeleted();
            contextTransaction.Dispose();
        }
    }
}
