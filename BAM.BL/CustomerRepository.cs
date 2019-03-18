using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            //Sort the list by firstname
            var query = customerList.OrderByDescending(c => c.FirstName);

            //Return list
            return query.ToList();
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
            AccountHandler accountHandler = new AccountHandler();
            Random random = new Random();

            //Create a new list
            var customers = new List<Customer>()
            {
                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Christian",
                    LastName = "Jensen",
                    Email = "john@jensen.dk",
                    PhoneNumber = "45454545"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Andrea",
                    LastName = "Thomsen",
                    Email = "tina@webweb.dk",
                    PhoneNumber = "45784575"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Benny",
                    LastName = "Hansen",
                    Email = "ole@erglad.dk",
                    PhoneNumber = "12345678"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Thomas T.",
                    LastName = "Svendsen",
                    Email = "sjov@mail.org",
                    PhoneNumber = "88888888"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Svend M.",
                    LastName = "Sved",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Gunnar",
                    LastName = "Svendsen",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Zenia",
                    LastName = "Hendriksen",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Lotte",
                    LastName = "Lottesen",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Torsten",
                    LastName = "Hammersøn",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"},

                new Customer(Guid.NewGuid().ToString()){
                    FirstName = "Erik",
                    LastName = "Eriksen",
                    Email = "groen@slagter.dk",
                    PhoneNumber = "45685475"}
            };

            //Create accounts for each customer
            var accounts = new List<Account>()
            {
                new Account(customers[0].CustomerId, "CheckingAccount"),
                new Account(customers[1].CustomerId, "CheckingAccount"),
                new Account(customers[2].CustomerId, "SavingsAccount"),
                new Account(customers[3].CustomerId, "SavingsAccount"),
                new Account(customers[4].CustomerId, "BusinessAccount"),
                new Account(customers[5].CustomerId, "BusinessAccount"),
                new Account(customers[6].CustomerId, "BusinessAccount"),
                new Account(customers[7].CustomerId, "BusinessAccount"),
                new Account(customers[8].CustomerId, "BusinessAccount"),
                new Account(customers[9].CustomerId, "BusinessAccount")
            };

            for (int i = 0; i < accounts.Count; i++)
            {
                accounts[i].Balance = random.Next(100000);
            }

            //Save accounts to json
            var filePath = Path.Combine(Environment.CurrentDirectory, "account_database.json");
            var jsonData = JsonConvert.SerializeObject(accounts);
            File.WriteAllText(filePath, jsonData);

            //Save customers to json
            filePath = Path.Combine(Environment.CurrentDirectory, "customer_database.json");
            jsonData = JsonConvert.SerializeObject(customers);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
