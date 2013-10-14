using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Models;

namespace KinetikV1.Domain.Interfaces
{
    public interface ILogger
    {
        void Log(string source, Exception ex);
        void Log(string source, string content);
    }
}