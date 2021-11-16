using System;
using System.IO;

namespace InventoryManagement
{
    public class InventoryData
    {
        public object JsonConvert { get; private set; }

        public InventoryManagement Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryManagement>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem in Getting data {0}", ex);
                    return null;
                }
            }
        }
    }
}
    

