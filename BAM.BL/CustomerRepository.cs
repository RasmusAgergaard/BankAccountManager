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

        public void RemoveCustomerFromJson(string customerId)
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

        public void ResetJsonWithNewList(List<Customer> customerList)
        {
            //Save to json
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");
            var jsonData = JsonConvert.SerializeObject(customerList);
            File.WriteAllText(filePath, jsonData);
        }

        //Test
        public void ResetListAndAddTestCustomers()
        {
            //Create a new list
            var customers = new List<Customer>()
            {
                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "John",
                    LastName = "Jensen",
                    Email = "john@jensen.dk",
                    PhoneNumber = "45454545"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Tina",
                    LastName = "Nielsen",
                    Email = "tina@webweb.dk",
                    PhoneNumber = "45784575"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Ole",
                    LastName = "Hansen",
                    Email = "ole@erglad.dk",
                    PhoneNumber = "12345678"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Rasmus A.",
                    LastName = "Bruntse",
                    Email = "sjov@mail.org",
                    PhoneNumber = "88888888"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Svend",
                    LastName = "Sved",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"}
            };

            //Save to json
            var filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");
            var jsonData = JsonConvert.SerializeObject(customers);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
