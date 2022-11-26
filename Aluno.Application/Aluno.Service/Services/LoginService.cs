using Aluno.Domain.DTOs;
using Aluno.Domain.Interface.Service;
using Aluno.Domain.RepositoryMethods;
using System.Threading.Tasks;

namespace Aluno.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;
        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(LoginDTO aluno)
        {
            if (aluno != null && !string.IsNullOrWhiteSpace(aluno.Email))
            {
                return await _repository.FindByLogin(aluno.Email);
            }
            else
            {
                return null;
            }
        }
    }
}
