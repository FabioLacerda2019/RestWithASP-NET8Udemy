using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IPersonBusiness
    {
       PersonVO Create(PersonVO person);

       PersonVO FindByID(long id);

       List<PersonVO> FindAll();

       PersonVO Update(PersonVO person);

       void Delete(long id);
    }
}