using Aluno.Domain.DTOs;
using System.Threading.Tasks;

namespace Aluno.Domain.Interface.Service
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDTO aluno);
    }
}
