using MyBlogNew.Common;
using MyBlogNew.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyBlogNew.Controllers
{
    public class ReadController : ApiController
    {
        //
        // GET: /Read/
        /// <summary>
        /// 获取日记列表
        /// </summary>
        /// <returns></returns>
        public List<read> GetReads(int pageIndex = 0, int pageSize = 1)
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                {
                    List<read> ls_read = entity.Reads.OrderBy(x => x.Id).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    if (ls_read.Count == 0)
                    {
                        return ls_read;
                    }
                    return ls_read;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
