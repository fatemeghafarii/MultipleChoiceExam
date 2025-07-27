using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest.Persistence.EF.Contexts
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MultipleChoiceTestContext>
    {
        public MultipleChoiceTestContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MultipleChoiceTestContext>();
            builder.UseSqlServer("Server=.\\SQL2025;Database=MultipleChoiceTestDb;Trusted_Connection=True;TrustServerCertificate=True;");
            return new MultipleChoiceTestContext(builder.Options);
        }
    }
}
