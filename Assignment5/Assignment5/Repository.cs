using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> dbset;

        public Repository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public void Insert(T Entity)
        {
            context.Entry(entityState) = EntityState.Added;
            Context.Savechanges();
        }

        public void Update(T Entity)
        {
            context.Entry(entityState) = EntityState.Updated;
            Context.Savechanges();
        }

        public void Delete(T Entity)
        {
            context.Entry(entityState) = EntityState.Delete;
            Context.Savechanges();
        }
        public T GetByID(int id)
        {
            return dbset.Find(id);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return context.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {

        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<t, objet>>[] navigation
        {
            T item = null;
            //IQueryable<T> dbQuery = null;
            IQueryable<T> dbQuery = context.Set<T>();

            foreach (Expression<Func<T, object>> nagivationProperty in nagivationProperties)
                dbQuery = dbset.Include<T, object>(navigationProperty);
                item = dbQuery;
                .AsNoTracking()
                .FirstOrDefault(where);
                return item;

        }

    }
}
