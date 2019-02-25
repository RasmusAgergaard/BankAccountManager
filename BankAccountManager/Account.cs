using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    public abstract class Account
    {
        private string _name;
        private float _balance;

        
        public Account()
        {

        }

        public void InitAccount(string ownerName, float startBalance)
        {
            _name = ownerName;
            _balance = startBalance;
        }

        public string ReturnName()
        {
            return _name;
        }

        public float ReturnBalance()
        {
            return _balance;
        }
        
    }
}
