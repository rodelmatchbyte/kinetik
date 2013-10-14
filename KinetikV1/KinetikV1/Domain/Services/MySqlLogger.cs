using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Interfaces;

namespace KinetikV1.Domain.Services
{
    public class MySqlLogger : ILogger
    {
        public void Log(string source, Exception ex)
        {
            Log(source, ex.InnerException != null ? ex.InnerException.Message : ex.Message);
        }

        public void Log(string source, string content)
        {
            try
            {
                using (var ctx = new kinetikEntities())
                {
                    ctx.logs.AddObject(new log()
                    {
                        source = source,
                        content = content,
                        date = DateTime.UtcNow
                    });

                    ctx.SaveChanges();
                }
            }

            catch (Exception)
            {
                // no need to do anything,let it fail silently
            }

        }
    }
}