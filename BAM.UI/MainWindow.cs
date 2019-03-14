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

        public MainWindow()
        {
            InitializeComponent();
            UpdateCustomerList();
        }

        private static int uniqueCustomerId = 1;

        //Create new customer
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var formCreateCustomer = new CreateCustomer(this);
            formCreateCustomer.Show();

            uniqueCustomerId += 1;
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

        //Update the customer list
        public void UpdateCustomerList()
        {
            //Clear the listbox
            listBoxCustomers.Items.Clear();

            //Create a repository and get customers
            var customerRepository = new CustomerRepository();
            var customers = customerRepository.GetCustomersFromJson();

            //Add the customers to the list box
            foreach (var customer in customers)
            {
                listBoxCustomers.Items.Add(customer);
            }

            listBoxCustomers.DisplayMember = "FirstName";
        }

        //Select a customer
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = listBoxCustomers.SelectedItem as Customer;

            labelCustomerInfo.Text = $"ID: {customer.CustomerId}\n" +
                                     $"First name: {customer.FirstName}\n" +
                                     $"Last name: {customer.LastName}\n" +
                                     $"Email address: {customer.Email}\n" +
                                     $"Phone number: {customer.PhoneNumber}\n";
        }

        //Deselect customer
        private void ResetCustomerInfo()
        {
            labelCustomerInfo.Text = "";
        }


    }
}
