using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyBlogNew.Entity
{
    [Table("navigation")]
    public class navigation
    {
        [Key]
        [Column("Nav")]
        public string Nav { get; set; }
        [Column("Url")]
        public string Url { get; set; }
    }
}