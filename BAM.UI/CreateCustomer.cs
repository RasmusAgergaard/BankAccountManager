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
            var account = accountHandler.CreateAccount(customer.CustomerId, comboBoxAccountType.Text);

            //Save customer
            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.SaveCustomerToJson(customer);

            //Save account
            AccountRepository accountRepository = new AccountRepository();
            accountRepository.SaveAccountToJson(account);

            labelShowText.Text = "OK";
        }
    }
}
