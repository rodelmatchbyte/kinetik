﻿// Type: System.Web.HttpPostedFile
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll

using System.IO;

namespace System.Web
{
    /// <summary>
    /// Provides access to individual files that have been uploaded by a client.
    /// </summary>
    public sealed class HttpPostedFile
    {
        /// <summary>
        /// Saves the contents of an uploaded file.
        /// </summary>
        /// <param name="filename">The name of the saved file. </param><exception cref="T:System.Web.HttpException">The <see cref="P:System.Web.Configuration.HttpRuntimeSection.RequireRootedSaveAsPath"/> property of the <see cref="T:System.Web.Configuration.HttpRuntimeSection"/> object is set to true, but <paramref name="filename"/> is not an absolute path.</exception>
        public void SaveAs(string filename);

        /// <summary>
        /// Gets the fully qualified name of the file on the client.
        /// </summary>
        /// 
        /// <returns>
        /// The name of the client's file, including the directory path.
        /// </returns>
        public string FileName { get; }

        /// <summary>
        /// Gets the MIME content type of a file sent by a client.
        /// </summary>
        /// 
        /// <returns>
        /// The MIME content type of the uploaded file.
        /// </returns>
        public string ContentType { get; }

        /// <summary>
        /// Gets the size of an uploaded file, in bytes.
        /// </summary>
        /// 
        /// <returns>
        /// The file length, in bytes.
        /// </returns>
        public int ContentLength { get; }

        /// <summary>
        /// Gets a <see cref="T:System.IO.Stream"/> object that points to an uploaded file to prepare for reading the contents of the file.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.IO.Stream"/> pointing to a file.
        /// </returns>
        public Stream InputStream { get; }
    }
}
