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
    public class DiaryController : ApiController
    {
        //
        // GET: /Diary/
        /// <summary>
        /// 获取日记列表
        /// </summary>
        /// <returns></returns>
        public List<diary> GetDiaries(int pageIndex = 0,int pageSize = 0)
        {
            try
            {
                LoggerHelper.Info("Test before connection:");
                using (var entity = new MyBlogNewEntities()) 
                {
                    LoggerHelper.Info("Test Log");
                    List<diary> ls_diary = entity.Diaries.OrderBy(x => x.Id).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    return ls_diary;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Info("exception:", ex);
                throw (ex);
            }
        }

        public int GetDiariesTotalNum()
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                 {
                    int totalPage = entity.Diaries.ToList().Count();
                    return totalPage;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }        
        }

        public int GetDiariesTotalNumOne()
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                {
                    int totalPage = entity.Diaries.ToList().Count();

                    LoggerHelper.Info("hello");
                    Dictionary<int, string> map = new Dictionary<int, string>();
                    map.Add(1,"hello");
                    map.Add(1,"world");
                    return totalPage;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Info("hello",ex);
                return 0;
            }
        }
    }
}
