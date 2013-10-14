using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KinetikV1.Tools
{
    public class ValueFromJson
    {
        public static string Get(string json, string property)
        {
            if (string.IsNullOrEmpty(json)) return string.Empty;

            var index = json.IndexOf(property);
            if (index == -1) return string.Empty;

            var start = json.IndexOf(':', index) + 1;
            while (json[index] != ',' && json[index] != '}' && json[index] != '\n') index++;

            return json.Substring(start, index - start).Trim(new char[]{' '}).Replace("\"", "");
        }
    }
}