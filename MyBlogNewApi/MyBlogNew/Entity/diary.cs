using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyBlogNew.Entity
{
    [Table("diary")]
    public class diary
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Content")]
        public string Content { get; set; }

        [Column("Time")]
        public DateTime Time { get; set; }

        [Column("Week")]
        public string Week { get; set; }
        [Column("Weather")]
        public string Weather { get; set; }
        [Column("Mood")]
        public string Mood { get; set; }
        [Column("Hidden")]
        public bool Hidden { get; set; }
        [Column("Type")]
        public int Type { get; set; }

    }
}