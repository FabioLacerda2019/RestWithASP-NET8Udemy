using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model.Base;
using RestWithASPNETUdemy.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity 
    {
        private SQLiteContext _context; 

        private DbSet<T> dataset;      

        public GenericRepository(SQLiteContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }
         
        public List<T> FindAll()
        {
           return dataset.ToList();
        }

        public T FindByID(long id)
        {
           return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

         public T Create(T item)
        {
            try
           {
               dataset.Add(item);
               _context.SaveChanges();
               return item;
           }
           catch (Exception)
           {
              throw;
           }  
           
        }

        public T Update(T item)
        {
           if (!Exists(item.Id)) return null;
           
           var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
           if (result != null)
           {
              try
              {
                 _context.Entry(result).CurrentValues.SetValues(item);
                 _context.SaveChanges();
                 return item;
              }
              catch (Exception)
              {
              throw;
              }
           } 
           else
           {
              return null;
           } 
           
        }

        public void Delete(long id)
        {
             var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
             if (result != null)
             {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                    
                }
                catch (Exception)
                {
                    throw;
                }
             }  
        }
        
        public bool Exists(long id)
        {
           return dataset.Any(p => p.Id.Equals(id));
        }
    }
}