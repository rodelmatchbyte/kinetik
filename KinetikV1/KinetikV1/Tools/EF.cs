using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Services;

namespace KinetikV1.Tools
{
    public static class EF
    {
        private readonly static ILogger Logger = new MySqlLogger();
        

        public static T Execute<T>(string funcName, Func<kinetikEntities, T> tryFunc, Func<T> catchFunc)
        {
            try
            {
                using (var ctx = new kinetikEntities())
                {
                    return tryFunc(ctx);
                }
            }

            catch (Exception ex)
            {
                Logger.Log(funcName, ex);
                return catchFunc();
            }



        }
    }
}