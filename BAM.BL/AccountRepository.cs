using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BAM.BL
{
    public class AccountRepository
    {
        public void SaveAccountToJson(Account account)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "account_database.json");

            //Read existing json data
            var jsonData = File.ReadAllText(filePath);

            //De-serialize to object or create a new list
            var accountList = JsonConvert.DeserializeObject<List<Account>>(jsonData) ?? new List<Account>();

            //Add customer to list
            accountList.Add(account);

            //Update json data string
            jsonData = JsonConvert.SerializeObject(accountList);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
