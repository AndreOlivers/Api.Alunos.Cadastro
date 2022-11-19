using Aluno.Domain.Interface;
using Aluno.Domain.Interface.Service;
using Aluno.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Service.Services
{
    public class AlunoService : IAlunoService
    {
        private IRepository<AlunoEntity> _repository;

        public AlunoService(IRepository<AlunoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AlunoEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<AlunoEntity> GetById(int id)
        {
            return await _repository.GetIdAsync(id);
        }

        public async Task<IEnumerable<AlunoEntity>> GetByName(string nome)
        {
            return await _repository.GetByName(nome);
        }

        public async Task<AlunoEntity> PostAluno(AlunoEntity aluno)
        {
            return await _repository.Create(aluno);
        }

        public async Task<AlunoEntity> PutAluno(AlunoEntity aluno)
        {
            return await _repository.Create(aluno);
        }

        public async Task<bool> DeleteAluno(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
