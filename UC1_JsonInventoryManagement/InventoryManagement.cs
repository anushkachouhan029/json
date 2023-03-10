using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class InventoryManagement
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "PricePerKg" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.PricePerKg + "\t\t" + (data.Weight * data.PricePerKg));
                }
            }
        }

    }
}
Footer
© 2023 GitHub, Inc.