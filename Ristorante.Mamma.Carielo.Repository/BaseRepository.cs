using Ristorante.Mamma.Carielo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ristorante.Mamma.Carielo.Repository
{
    public abstract class BaseRepository<TEntity, TKey> where TEntity : class
    {
        protected DbContext _context = new RistoranteMammaCarieloDbContext();

        public virtual async Task<List<TEntity>> Select(Func<TEntity, bool> where = null)
        {
            List<TEntity> resultado = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            if (where != null)
                resultado = resultado.Where(where).ToList();
            return resultado.ToList();
        }

        public virtual async Task<TEntity> SelectById(TKey id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<bool> Insert(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual async Task<bool> Update(TEntity entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                    _context.Set<TEntity>().Attach(entity);

                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<bool> Delete(TEntity entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                    _context.Set<TEntity>().Attach(entity);

                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual async Task<bool> DeleteById(TKey id)
        {
            TEntity entity = await SelectById(id);
            return await Delete(entity);
        }

        public virtual async void Detach(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
            await _context.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> SelectDynamicInclude(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            IEnumerable<TEntity> resultado = await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();

            if (where != null)
                resultado = resultado.Where(where);

            return resultado.ToList();
        }
    }
}
