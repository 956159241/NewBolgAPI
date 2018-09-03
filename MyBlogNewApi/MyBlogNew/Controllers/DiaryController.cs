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
                LoggerHelper.WriteLog("hello writeLog,info", LogLevel.Info);
                LoggerHelper.WriteLog("hello writeLog,Debug", LogLevel.Debug);
                LoggerHelper.WriteLog("hello writeLog,Error", LogLevel.Error);
                using (var entity = new MyBlogNewEntities()) 
                {
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
        /// <summary>
        /// get the count of diaries
        /// </summary>
        /// <returns></returns>
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
    }
}
