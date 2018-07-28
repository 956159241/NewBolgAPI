using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogNew.Models
{
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}