using Aluno.Domain.Interface;
using Aluno.Domain.Model;
using System.Threading.Tasks;

namespace Aluno.Domain.RepositoryMethods
{
    public interface IUserRepository : IRepository<AlunoEntity>
    {
        Task<AlunoEntity> FindByLogin(string email);
    }
}
