using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WPF.Services
{
    public interface IResourceHandler<T>
    {
        T LoadIndividualResourceFromDisk(string location);
        ICollection<T> LoadResourcesFromDisk(string location);

        bool SaveResourceToDisk(T resource, string location);

    }
}
