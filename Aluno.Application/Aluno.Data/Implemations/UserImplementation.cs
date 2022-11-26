using Aluno.Data.Context;
using Aluno.Data.Repository;
using Aluno.Domain.Model;
using Aluno.Domain.RepositoryMethods;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Aluno.Data.Implemations
{
    public class UserImplementation : BaseRepository<AlunoEntity>, IUserRepository
    {
        private DbSet<AlunoEntity> _dataSet;

        public UserImplementation(MyContext context) : base(context)
        {
            _dataSet = context.Set<AlunoEntity>();
        }

        public async Task<AlunoEntity> FindByLogin(string email)
        {
            return await _dataSet.FirstOrDefaultAsync(e => e.Email.Equals(email)); 
        }
    }
}
