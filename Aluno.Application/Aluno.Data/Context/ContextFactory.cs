using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);

        }
    }
}
