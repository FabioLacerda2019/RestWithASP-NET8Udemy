using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO FindByID(long id);

        List<BookVO> FindAll();

        BookVO Update(BookVO book);

        void Delete(long id);
    }
}