using FAP.Organizer.WinForms.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WPF.Entities
{
    class ImageResource : IEntity
    {
        public string FileName { get; set; }
        public string Alias { get; set; }//name given to the image by the user
        public List<Tag> Tags { get; set; }
    }
}
