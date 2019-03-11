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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        //Create customer
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Create customer
            CustomerHandler customerHandler = new CustomerHandler();
            var customer = customerHandler.CreateCustomer(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);

            //Create Account
            AccountHandler accountHandler = new AccountHandler();
            var account = accountHandler.CreateAccount(customer.CustomerId, "SavingsAccount");

            //Save customer
            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.Save(customer);

            //This should save the data instead of showing it
            labelShowText.Text = "";

            labelShowText.Text += "ID: " + customer.CustomerId.ToString() + "\n";
            labelShowText.Text += customer.FirstName.ToString() + "\n";
            labelShowText.Text += customer.LastName.ToString() + "\n";
            labelShowText.Text += customer.Email.ToString() + "\n";
            labelShowText.Text += customer.PhoneNumber.ToString();
            labelShowText.Text += "\n\n"; //Space
            labelShowText.Text += "Account ID: " + account.AccountId.ToString() + "\n";
            labelShowText.Text += account.Type.ToString() + "\n";
            labelShowText.Text += account.State.ToString() + "\n";
            labelShowText.Text += account.Balance.ToString() + "\n";
        }
    }
}
