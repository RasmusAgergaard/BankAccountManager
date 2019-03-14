using System;
using System.Collections.Generic;
using System.Text;

namespace BAM.BL
{
    public class Account
    {
        public enum AccountType { CheckingAccount, SavingsAccount, BusinessAccount};
        public enum AccountState { Active, Locked, Deactive};

        public Account(string accountId, string accountType)
        {
            //Set ID
            AccountId = accountId;

            //Set account type
            switch (accountType)
            {
                case "CheckingAccount":
                    Type = AccountType.CheckingAccount;
                    break;

                case "SavingsAccount":
                    Type = AccountType.SavingsAccount;
                    break;

                case "BusinessAccount":
                    Type = AccountType.BusinessAccount;
                    break;
            }

            //Set state
            State = AccountState.Active;

            //Set balance
            Balance = 0M;
        }

        public string AccountId { get; set; }
        public AccountType Type { get; set; }
        public AccountState State { get; set; }
        public decimal Balance { get; set; }
    }
}
