using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using RestWithASPNETUdemy.Model.Base;

namespace RestWithASPNETUdemy.Model
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }
    }
}