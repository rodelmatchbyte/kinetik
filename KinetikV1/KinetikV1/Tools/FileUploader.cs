using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KinetikV1.Tools
{
    public class FileUploader
    {
        public static string Upload(HttpRequest request, string folder)
        {
            if (request.Files.Count == 0) return string.Empty;
            var filename = "";
            foreach (string file in request.Files)
            {
                var postedFile = request.Files[file];
                if (string.IsNullOrEmpty(postedFile.FileName)) continue;
                var filePath = HttpContext.Current.Server.MapPath(folder + postedFile.FileName);
                postedFile.SaveAs(filePath);
                filename = postedFile.FileName;
            }
            return filename;
        }
    }
}