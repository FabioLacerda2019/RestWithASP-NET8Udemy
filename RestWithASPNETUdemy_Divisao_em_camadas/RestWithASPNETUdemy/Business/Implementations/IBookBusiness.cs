using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IBookBusiness
    {
    Book Create(Book Book);

    Book FindByID(long id);

    List<Book> FindAll();

    Book Update(Book Book);

    void Delete(long id);
    }
}