using FAP.Organizer.WinForms.Entities;
using FAP.Organizer.WinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WinForms.Handlers
{
    public class TagHandler
    {
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public string DefaultTagFileLocation { get; } = "C:\\tagList.txt";
        public TagHandler()
        {
            Tags.Add(new Tag(){ Name = "Blonde" });
            Tags.Add(new Tag() { Name = "MILF" });
            Tags.Add(new Tag() { Name = "Hot" });
            Tags.Add(new Tag() { Name = "Latina" });
        }

        public void LoadTags ()
        {

        }

        public void SaveTagsToDisk()
        {
            ResourceManagerService.SaveTagsToDisk(Tags, DefaultTagFileLocation);
        }

    }
}
