using Aluno.Data.Context;
using Aluno.Domain.Interface;
using Aluno.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : AlunoEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>>GetAllAsync()
        {
            try
            {
                return await _dataSet.ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetIdAsync(int id)
        {
            return await _dataSet.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> GetByName(string name)
        {
            IEnumerable<T> alunos;
            if (!string.IsNullOrEmpty(name))
            {
                alunos = await _dataSet
                    .Where(n => n.Nome.Contains(name)).ToListAsync();
            }
            else
            {
                alunos = await GetAllAsync();
            }
            return alunos;
        }

        public async Task<T> Create(T entity)
        {
            try
            {
                _dataSet.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            var result = await _dataSet.FirstOrDefaultAsync(a => a.Id == entity.Id);
            try
            {
                if (result == null)
                    return null;

                _dataSet.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _dataSet.FirstOrDefaultAsync(a => a.Id == id);
            try
            {
                if (result == null)
                    return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
