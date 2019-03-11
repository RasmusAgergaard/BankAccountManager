using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BAM.BL
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");

            //Read existing json data
            var jsonData = File.ReadAllText(filePath);

            //De-serialize to object or create a new list
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonData)
                                        ?? new List<Customer>();

            //Add customer to list
            customerList.Add(customer);

            //Update json data string
            jsonData = JsonConvert.SerializeObject(customerList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
