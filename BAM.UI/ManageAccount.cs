using BAM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAM.UI
{
    public partial class ManageAccount : Form
    {
        AccountRepository accountRepository = new AccountRepository();
        Account accountToEdit = null;
        decimal balanceToComit = 0M;

        public ManageAccount()
        {
            InitializeComponent();
        }

        //Overloaded cunstructor
        private string _customerId;
        private MainWindow mainForm = null;
        public ManageAccount(string customerId, Form callingForm)
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();

            //Set id
            _customerId = customerId;

            PopulateFields();
        }

        private void PopulateFields()
        {
            var accounts = accountRepository.GetAccountsFromJson();

            foreach (var account in accounts)
            {
                if (account.AccountId == _customerId)
                {
                    accountToEdit = account;
                }
            }

            labelCurrentAmount.Text = $"{accountToEdit.Balance},-";
        }

        //key press
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Text changed
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
            {
                decimal input = decimal.Parse(textBoxInput.Text);

                //Deposit
                if (radioButtonDeposit.Checked == true)
                {
                    balanceToComit = accountToEdit.Balance + input;
                }

                //Withdraw
                if (radioButtonWithdraw.Checked == true)
                {
                    balanceToComit = accountToEdit.Balance - input;
                }

                labelAfterAmount.Text = balanceToComit.ToString();
            }

        }

        //Radio button changed
        private void radioButtonDeposit_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInput_TextChanged(null, null);
        }

        //Commit change
        private void buttonCommit_Click(object sender, EventArgs e)
        {
            EditAndSaveAccountsToJson();

            //Update 
            this.mainForm.UpdateCustomerList();

            this.Close();
        }

        private void EditAndSaveAccountsToJson()
        {
            //Get data from json and add to list
            var accounts = accountRepository.GetAccountsFromJson();

            //Add all but the editet account to a list
            foreach (var account in accounts)
            {
                if (account.AccountId == _customerId)
                {
                    account.Balance = balanceToComit;
                }
            }

            //Reset list with the new content
            accountRepository.ResetJsonWithNewList(accounts);
        }
    }
}
