using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Models;
//using System.Web.Helpers;
using KinetikV1.Tools;
using System.Security.Cryptography;
using KinetikV1.Domain.Services;

namespace KinetikV1.Domain.Extensions
{
    public static class AccountExtension
    {
        public static string Hash(this Account account)
        {
            var now = DateTime.UtcNow;
            var str = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", 
                now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, account.Id, account.Name);
            return Crypto.Encrypt<AesManaged>(str, Setting.Value["cryptoPass"], Setting.Value["cryptoSalt"]);
            
        }
    }
}