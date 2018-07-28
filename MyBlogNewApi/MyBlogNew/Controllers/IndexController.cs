using System;
using MyBlogNew.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MyBlogNew.Common;
using MyBlogNew.Entity;

namespace MyBlogNew.Controllers
{
    public class IndexController : ApiController
    {
        /// <summary>
        /// 获取博客主题
        /// </summary>
        /// <returns></returns>
        public theme GetTheme()
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                {
                    theme them = entity.Themes.FirstOrDefault();
                    return them;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        /// <summary>
        /// 获取导航列表
        /// </summary>
        /// <returns></returns>
        public List<navigation> GetNavigation()
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                {
                    List<navigation> ls_nav = entity.Navigations.ToList();                  
                    return ls_nav;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }    

    }
}
