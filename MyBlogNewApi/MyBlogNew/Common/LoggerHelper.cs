using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MyBlogNew.Common
{
    public enum LogLevel
    {
        Trace,
        Debug,
        Info,
        Error,
        Fatal
    }
    public class LoggerHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void WriteLog(string message, LogLevel logLevel)
        {
            if (string.IsNullOrEmpty(message))
                return;
            var type = logger.GetType();
           type.InvokeMember(logLevel.ToString(), BindingFlags.Default | BindingFlags.InvokeMethod, null, logger, new object[] { message });  
        }

        public static void WriteLog(string message, Exception ex, LogLevel logLevel)
        {
            if (string.IsNullOrEmpty(message))
                return;
            var type = logger.GetType();
            type.InvokeMember(logLevel.ToString(), BindingFlags.Default | BindingFlags.InvokeMethod, null, logger, new object[] { message,ex });
        }


        public static void Info(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;
            logger.Info(message);
        }
        public static void Info(string message, Exception ex)
        {
            if (string.IsNullOrEmpty(message))
                return;
            logger.Info(ex,message);
        }

        public static void Debug(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;
            logger.Debug(message);
        }
        public static void Debug(string message, Exception ex)
        {
            if (string.IsNullOrEmpty(message))
                return;
            logger.Debug(ex,message);
        }
    }
}