using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace MyBlogNew.Entity
{
    [Table("read")]
    public class read
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Title"), DisplayName("标题")]
        public string Title { get; set; }

        [Column("Content"), DisplayName("内容")]
        public string Content { get; set; }

        [Column("Picture"), DisplayName("文章简介图片路径")]
        public string Picture { get; set; }

        [Column("Time"), DisplayName("发布时间")]
        public DateTime Time { get; set; }

        [Column("Author"), DisplayName("作者")]
        public string Author { get; set; }

        [Column("Type"), DisplayName("分类：1:笔记，2：随笔，3:其他")]
        public int Type { get; set; }

    }
}