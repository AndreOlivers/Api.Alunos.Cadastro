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

        Task<AlunoEntity> PostStudents(AlunoEntity aluno);
        Task<AlunoEntity> PutStudents(AlunoEntity aluno);
        Task<bool> DeleteStudents(int id);
    }
}
