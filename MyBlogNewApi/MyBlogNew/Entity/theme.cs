using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyBlogNew.Entity
{
    [Table("theme")]
    public class theme
    {
        [Key]
        [Column("Name")]
        public string Name { get; set; }
        [Column("Url")]
        public string Url { get; set; }
        [Column("Test")]
        public string Test { get; set; }

    }
}