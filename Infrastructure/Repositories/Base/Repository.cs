using Application.Ports.Repositories.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly StoreContext _employeeContext;
        public Repository(StoreContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _employeeContext.Set<T>().AddAsync(entity);
            await _employeeContext.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(T entity)
        {
            _employeeContext.Set<T>().Update(entity);
            await _employeeContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            _employeeContext.Set<T>().Remove(entity);
            await _employeeContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _employeeContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _employeeContext.Set<T>().FindAsync(id);
        }
    }
}
