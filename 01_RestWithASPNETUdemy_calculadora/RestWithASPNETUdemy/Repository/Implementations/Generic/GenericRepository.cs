using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model.Base;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Repository.Implementations.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity 
    {
        private SQLiteContext _context; 

        private DbSet<T> _dataset;      

        public GenericRepository(SQLiteContext context)
        {
            _context = context;
        }
         
        public T Create(T item)
        {
            throw new NotImplementedException();
        }

        public T Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T FindAll(T item)
        {
            throw new NotImplementedException();
        }

        public T FindById(T item)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}