using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogNew.Common
{
    public enum Result
    { 
        success = 1, 
        fail = -1
    }

    public class Result<T>
    {
        public Result Code {get;set; }

        public string Msg { get; set; }

        public T Data { get; set; }
    }
}