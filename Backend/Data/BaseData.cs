using Data.Implementations;
using Entity.Context;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BaseData<T> : ABaseData<T> where T : BaseModel
    {

        private readonly ApplicationDbContext _context;

        public BaseData(ApplicationDbContext context)
        {
            _context = context;          
        }


        public override async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>()
                .Where(e => !e.IsDeleted && e.Active)
                .ToListAsync();
        }

        public override async Task<T?> GetById(int id)
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted && e.Active);
        }

        public override async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public override async Task<bool> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public override async Task<bool> DeletePermant(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null) return false;
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> DeleteLogical(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null) return false;

            entity.IsDeleted = true;
            await _context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> Reactivate(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null) return false;

            entity.IsDeleted = false;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
