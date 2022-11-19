using Aluno.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Domain.Interface.Service
{
    public interface IAlunoService
    {
        Task<AlunoEntity> GetById(int id);
        Task<IEnumerable<AlunoEntity>> GetAll();
        Task<IEnumerable<AlunoEntity>> GetByName(string nome);

        Task<AlunoEntity> PostAluno(AlunoEntity aluno);
        Task<AlunoEntity> PutAluno(AlunoEntity aluno);
        Task<bool> DeleteAluno(int id);
    }
}
