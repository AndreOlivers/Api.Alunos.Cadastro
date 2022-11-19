using Aluno.Domain.Interface.Service;
using Aluno.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Aluno.Infraestrutura.DependecyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAlunoService, AlunoService>();
        }
    }
}
