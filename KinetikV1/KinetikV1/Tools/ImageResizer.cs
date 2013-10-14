using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace KinetikV1.Tools
{
    public class ImageResizer
    {
        public static void ResizeImage(string origFile, string newFile, int newWidth, int maxHeight, bool resizeIfWider)
        {
            var fullSizeImage = Image.FromFile(origFile);
            // Ensure the generated thumbnail is not being used by rotating it 360 degrees
            fullSizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            fullSizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (resizeIfWider)
            {
                if (fullSizeImage.Width <= newWidth)
                {
                    newWidth = fullSizeImage.Width;
                }
            }

            var newHeight = fullSizeImage.Height * newWidth / fullSizeImage.Width;
            if (newHeight > maxHeight) // Height resize if necessary
            {
                newWidth = fullSizeImage.Width * maxHeight / fullSizeImage.Height;
                newHeight = maxHeight;
            }

            // Create the new image with the sizes we've calculated
            var newImage = fullSizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            fullSizeImage.Dispose();
            newImage.Save(newFile);
        }
    }
}