using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WinForms.Entities
{
    public class Tag
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Tag Alias { get; set; }

    }
}
