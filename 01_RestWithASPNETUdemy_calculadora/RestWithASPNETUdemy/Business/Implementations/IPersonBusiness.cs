using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IPersonBusiness
    {
    Person Create(Person person);

    Person FindByID(long id);

    List<Person> FindAll();

    Person Update(Person person);

    void Delete(long id);
    }
}