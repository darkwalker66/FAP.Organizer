using FAP.Organizer.WinForms.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WPF.Entities
{
    public class ImageResource : IEntity
    {
        public string FileName { get; set; }
        public string Alias { get; set; }//name given to the image by the user
        public List<Tag> Tags { get; set; }
        public string Hash { get; set; }

        public ImageResource(string fileName, Stream stream)
        {
            FileName = fileName;
            GenerateHashMD5(stream);
        }

        private string GenerateHashMD5(Stream stream)
        {
            using (var md5 = MD5.Create())
            {
                    var hash = md5.ComputeHash(stream);
                    Hash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    return Hash;                
            }
        }

    }
}
