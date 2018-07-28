using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogNew.Common
{
    public class LoggerHelper
    {
        public enum LogLevel
        {
            Trace,
            Debug,
            Info,
            Error,
            Fatal
        }
        private static Logger logger = LogManager.GetCurrentClassLogger();

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