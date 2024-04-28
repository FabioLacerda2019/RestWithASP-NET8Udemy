using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Controllers;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
       private SQLiteContext _context;       

       public PersonRepositoryImplementation(SQLiteContext context)
       {
           _context = context;
       }

       public Person Create(Person person)
       {
           try
           {
               _context.Add(person);
               _context.SaveChanges();
           }
           catch (Exception)
           {
              throw;
           }  
           return person;
       }

       public Person FindByID(long id) 
       {
           return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
       }

       public List<Person> FindAll()
       {
          return _context.Persons.ToList();
       }

       public Person Update(Person person)
       {
           if (!Exists(person.Id)) return null;
           
           var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
           if (result != null)
           {
              try
              {
                 _context.Entry(result).CurrentValues.SetValues(person);
                 _context.SaveChanges();
              }
              catch (Exception)
              {
              throw;
              }
           }  
           return person;
           
       }

       public void Delete(long id) 
       {
           var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

           if (result != null)
           {
              try
              {
                 _context.Persons.Remove(result);
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
           return _context.Persons.Any(p => p.Id.Equals(id));
       }
    }
}