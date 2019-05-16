using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.datacontext;
using WebApplication4.Models;

namespace WebApplication4.Repository
{
    public class Repository<T> where T :dbobj
    {
        private databasecontext databseContext = new databasecontext();
        protected  DbSet<T> dbset { get; set; }
        public Repository()
        {
            dbset = databseContext.Set<T>(); // set 
        }
        public List<T> GetAll()
        {
            return dbset.ToList();
        }
        public T find(int? i )
        {
            return dbset.Find(i);
        }
        public bool delete(int id)
        {
            T _t =dbset.Where(c => c.ID == id).FirstOrDefault();
            if (_t !=null)
            {
                dbset.Remove(_t);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(T t)
        {
            dbset.Add(t);
        }
        public void saveChange()
        {
            databseContext.SaveChanges();
        }
        

    }
}