using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;

namespace GetDevTaskPuppies.Services
{
    public static class ImageTransform
    {

        public static string Transform(int width, int height, string url)
        {
            var cloudinary = new Cloudinary(new Account()
            {
                ApiKey = CloudinaryUpload.apiKey,
                ApiSecret = CloudinaryUpload.apiSecret,
                Cloud = CloudinaryUpload.cloud,
            });
            var img = cloudinary.Api.UrlImgFetch.
                Transform(new Transformation()
                    .Height(height).Width(width).Crop("fit")).BuildUrl(url);
            return img;
        }
    }
}
