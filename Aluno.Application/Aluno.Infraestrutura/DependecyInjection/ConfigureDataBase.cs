using Aluno.Data.Context;
using Aluno.Data.Repository;
using Aluno.Domain.Interface;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Infraestrutura.DependecyInjection
{
    public class ConfigureDataBase
    {
        public static void ConfigureDependeciesDataBase(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MyContext>(options =>
                     options.UseSqlServer("Server=.\\SQLEXPRESS;Database=AppAlunoAPI;Trusted_Connection=True;"));
        }
    }
}
