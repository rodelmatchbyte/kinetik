using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Interfaces;
using System.IO;

namespace KinetikV1.Domain.Services
{
    public class FileLogger : ILogger
    {
        public static readonly FileLogger Instance = new FileLogger();

        private uint _seed = 0;
        private const string Path = @"c:/kinetik/logs/";

        private string GetFilename()
        {
            var now = DateTime.Now;
            return string.Format("{0}{1}{2}{3}",now.Year,now.Month,now.Day,_seed++);
        }

        public void Log(string source, Exception ex)
        {
            Log(source, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
        }

        public void Log(string source, string content)
        {
            var sw = File.CreateText(Path + GetFilename() + ".log");
            try
            {
                sw.WriteLine(source);
                sw.WriteLine(content);
            }

            finally
            {
                sw.Close();
            }
        }
    }
}