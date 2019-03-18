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
using Newtonsoft.Json;

namespace BAM.UI
{
    public partial class MainWindow : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();
        AccountRepository accountRepository = new AccountRepository();
        string searchInput = "";

        public MainWindow()
        {
            InitializeComponent();
            UpdateCustomerList();
        }

        //Create new customer
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var formCreateCustomer = new CreateCustomer(this);
            formCreateCustomer.Show();
        }

        //Reset the list, and create test customers
        private void buttonTest_Click(object sender, EventArgs e)
        {
            customerRepository.ResetListAndAddTestCustomers();

            UpdateCustomerList();
        }

        //Delete customer
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                Customer customer = listBoxCustomers.SelectedItem as Customer;

                customerRepository.RemoveCustomerFromJson(customer.CustomerId);

                UpdateCustomerList();

                ResetCustomerInfo();
            }
        }

        //Edit customer
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                Customer customer = listBoxCustomers.SelectedItem as Customer;

                var formEditCustomer = new EditCustomer(customer.CustomerId, this);
                formEditCustomer.Show();
            }
        }

        //Manage account
        private void buttonManageAccount_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                Customer customer = listBoxCustomers.SelectedItem as Customer;

                var formManageAccount = new ManageAccount(customer.CustomerId, this);
                formManageAccount.Show();
            }
        }

        //Search
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchInput = textBoxSearch.Text;
            UpdateCustomerList();
        }

        //Update the customer list
        public void UpdateCustomerList()
        {
            //Clear the listbox
            listBoxCustomers.Items.Clear();

            //Create a repository and get customers
            var customerRepository = new CustomerRepository();
            var customers = customerRepository.GetCustomersFromJson();

            //Sort the list
            customers = customers.Where(c => c.FirstName.Contains(searchInput))
                                 .OrderBy(c => c.FirstName).ToList();

            //Add the customers to the list box
            foreach (var customer in customers)
            {
                listBoxCustomers.Items.Add(customer);
            }

            listBoxCustomers.DisplayMember = "FirstName";

            ResetCustomerInfo();
        }

        //Select a customer
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                //Selected customer
                Customer customer = listBoxCustomers.SelectedItem as Customer;

                //Find selected customer account
                var accounts = accountRepository.GetAccountsFromJson();
                Account accountToDisplay = new Account("",""); ;

                foreach (var account in accounts)
                {
                    if (account.AccountId == customer.CustomerId)
                    {
                        accountToDisplay = account;
                        break;
                    }
                }

                //Add text
                labelCustomerInfo.Text = $"ID: {customer.CustomerId}\n" +
                                         $"\n" +
                                         $"First name: {customer.FirstName}\n" +
                                         $"Last name: {customer.LastName}\n" +
                                         $"Email address: {customer.Email}\n" +
                                         $"Phone number: {customer.PhoneNumber}\n" +
                                         $"\n" +
                                         $"Account type: {accountToDisplay.Type}\n" +
                                         $"Balance: {accountToDisplay.Balance}\n";
            }

        }

        //Reset customer
        private void ResetCustomerInfo()
        {
            labelCustomerInfo.Text = "Select a customer...";
        }

        //Reset Search field
        private void ResetSearchField()
        {
            textBoxSearch.Text = "";
        }


    }
}
