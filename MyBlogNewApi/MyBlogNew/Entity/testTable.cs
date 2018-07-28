using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyBlogNew.Entity
{
    [Table("testTable")]
    public class testTable
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Content")]
        public string Content { get; set; }

        [Column("Time")]
        public DateTime Time { get; set; }
        [Column("Time2")]
        public DateTime Time1 { get; set; }

    }
}