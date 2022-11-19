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
        Task<IEnumerable<T>> GetIdAsync(int id);
        Task<T> GetAllAsync();
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<T> Delete(T item);

    }
}
