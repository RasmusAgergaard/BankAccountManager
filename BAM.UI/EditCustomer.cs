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
    public partial class EditCustomer : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();
        AccountRepository accountRepository = new AccountRepository();
        CustomerHandler customerHandler = new CustomerHandler();

        public EditCustomer()
        {
            InitializeComponent();
        }

        //Overloaded constructor
        private string _customerId;
        private MainWindow mainForm = null;
        public EditCustomer(string customerId, Form callingForm)
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();
            
            //Set id
            _customerId = customerId;

            //Load data into fields
            PopulateFields();
        }

        private void PopulateFields()
        {
            //Get data from json and add to list
            var customers = customerRepository.GetCustomersFromJson();

            //Find customer from list
            Customer customerToEdit = null;

            foreach (var customer in customers)
            {
                if (customer.CustomerId == _customerId)
                {
                    customerToEdit = customer;

                }
            }

            //Get data from json and add to list
            var accounts = accountRepository.GetAccountsFromJson();

            //If the account id matches the customer id - populate the combobox
            foreach (var account in accounts)
            {
                if (account.AccountId == _customerId)
                {
                    //Populate comboBox
                    comboBoxAccountType.Text = account.Type.ToString();
                    break;
                }
            }

            //Populate the rest of the fields
            textBoxFirstName.Text = customerToEdit.FirstName;
            textBoxLastName.Text = customerToEdit.LastName;
            textBoxEmail.Text = customerToEdit.Email;
            textBoxPhone.Text = customerToEdit.PhoneNumber;
        }

        //Edit customer
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditAndSaveCustomersToJson();

            EditAndSaveAccountsToJson();

            //Update 
            this.mainForm.UpdateCustomerList();

            this.Close();
        }

        private void EditAndSaveCustomersToJson()
        {
            //Get data from json and add to list
            var customers = customerRepository.GetCustomersFromJson();

            //Remove existing customer from list
            foreach (var customer in customers)
            {
                if (customer.CustomerId == _customerId)
                {
                    customer.FirstName = textBoxFirstName.Text;
                    customer.LastName = textBoxLastName.Text;
                    customer.Email = textBoxEmail.Text;
                    customer.PhoneNumber = textBoxPhone.Text;
                }
            }

            //Reset list with the new content
            customerRepository.ResetJsonWithNewList(customers);
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
                    //Set account type
                    switch (comboBoxAccountType.Text)
                    {
                        case "CheckingAccount":
                            account.Type = Account.AccountType.CheckingAccount;
                            break;

                        case "SavingsAccount":
                            account.Type = Account.AccountType.SavingsAccount;
                            break;

                        case "BusinessAccount":
                            account.Type = Account.AccountType.BusinessAccount;
                            break;
                    }
                }
            }

            //Reset list with the new content
            accountRepository.ResetJsonWithNewList(accounts);
        }
    }
}
