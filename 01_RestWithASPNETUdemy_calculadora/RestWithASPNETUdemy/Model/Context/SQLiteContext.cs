using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Model.Context
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext()
        {
            
        }

        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options) {}
        
        public DbSet<Person> Persons { get; set; }    
        
        
    }
}