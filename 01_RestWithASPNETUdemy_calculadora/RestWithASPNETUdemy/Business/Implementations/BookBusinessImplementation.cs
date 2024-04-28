using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Controllers;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Implementations;

namespace RestWithASPNETUdemy.Business.Implementations
{
   public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book Book)
        {
           
            return _repository.Create(Book);
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book Update(Book Book)
        {
            return _repository.Update(Book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}