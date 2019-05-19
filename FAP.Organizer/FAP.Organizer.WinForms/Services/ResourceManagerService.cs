using FAP.Organizer.WinForms.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAP.Organizer.WinForms.Services
{
    public class ResourceManagerService<T>
    {
        /// <summary>
        /// Has to save:
        /// - filename
        /// - disk location
        /// - hash
        /// - tags
        /// </summary>
        /// <returns></returns>
        public bool SaveImageInformation()
        {
            return true;
        }


        public void SaveTagsToDisk(List<Tag> tagList, string filePath)
        {
            
            List<string> objsToSave = new List<string>();
            foreach (var item in tagList)
            {
                WriteToJsonFile(item, filePath);
            }

            

        }

        // Maybe use an abordage like: https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
        private void WriteToJsonFile(Tag itemToWrite, string filePath)
        {
            TextWriter writer = null;
            try
            {
                var content = JsonConvert.SerializeObject(itemToWrite);
                writer = new StreamWriter(filePath, true);
                writer.Write(content);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }


    }
}
