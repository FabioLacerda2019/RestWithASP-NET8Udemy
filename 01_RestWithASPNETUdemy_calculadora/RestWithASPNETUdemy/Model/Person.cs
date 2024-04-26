using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("Person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("address")]
        public string Address { get; set; }
         
        [Column("first_name")] 
        public string FirstName { get; set; }

        [Column("gender")]       
        public string Gender { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
    }
}