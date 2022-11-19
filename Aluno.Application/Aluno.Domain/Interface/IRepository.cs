using Aluno.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Domain.Interface
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetByName(string name);
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<bool> Delete(int id);

    }
}
