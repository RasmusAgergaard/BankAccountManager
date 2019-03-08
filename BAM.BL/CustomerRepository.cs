using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BAM.BL
{
    public class CustomerRepository
    {
        public bool Save(Customer customer)
        {
            //Serialize object
            //string seriallizedJason = JsonConvert.SerializeObject(customer);

            //File.WriteAllText(@"c:\test\test.json", seriallizedJason);

            using (StreamWriter file = File.CreateText(@"c:\test\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, customer);
            }

            return true;
        }
    }
}
