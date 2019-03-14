using System;
using System.Collections.Generic;
using System.Text;

namespace BAM.BL
{
    public class AccountHandler
    {
        public Account CreateAccount(string accountId, string accountType)
        {
            //Create new account
            Account account = new Account(accountId, accountType);

            return account;
        }
    }
}
