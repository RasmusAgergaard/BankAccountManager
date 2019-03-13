using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BAM.BL
{
    public class CustomerRepository
    {
        public void SaveCustomerToJson(Customer customer)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");

            //Read existing json data
            var jsonData = File.ReadAllText(filePath);

            //De-serialize to object or create a new list
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonData) ?? new List<Customer>();

            //Add customer to list
            customerList.Add(customer);

            //Update json data string
            jsonData = JsonConvert.SerializeObject(customerList);
            File.WriteAllText(filePath, jsonData);
        }

        public void RemoveCustomerFromJson(int customerId)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");

            //Read existing json data
            var jsonData = File.ReadAllText(filePath);

            //De-serialize to object or create a new list
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonData) ?? new List<Customer>();

            //Run though customers and remove the one with the right ID
            foreach (var customer in customerList)
            {
                if (customer.CustomerId == customerId)
                {
                    customerList.Remove(customer);
                    break;
                }
            }

            //Update json data string
            jsonData = JsonConvert.SerializeObject(customerList);
            File.WriteAllText(filePath, jsonData);
        }

        public List<Customer> GetCustomersFromJson()
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");

            //Read existing json data
            var jsonData = File.ReadAllText(filePath);

            //De-serialize to object or create a new list
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonData) ?? new List<Customer>();

            //Return list
            return customerList;
        }
    }
}
