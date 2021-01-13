using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using LexShop.Core.Contracts;
using LexShop.Core.Models;


namespace LexShop.DataAccess.SQL
{
    public class SQLRepositoryOld<T> : IRepository<T> where T : BaseEntity
    {
        string className;
        List<T> items;
        private readonly DataContext db;

        public SQLRepositoryOld(DataContext db)
        {
            className = typeof(T).Name;
            this.db = db;
            items = db.Database.SqlQuery<T>("select * from " + className + " order by Name").ToList();
        }

        public IQueryable<T> Collection()
        {
            return items.AsQueryable();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public T Find(string ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            items.Add(t);
            //db.
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
