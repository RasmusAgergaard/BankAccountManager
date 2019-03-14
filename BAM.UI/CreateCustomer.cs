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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        //Overloaded constructor - To create link to the form calling it
        private MainWindow mainForm = null;
        public CreateCustomer(Form callingForm) 
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Create objects
            var customerHandler = new CustomerHandler();
            var customerRepository = new CustomerRepository();
            var accountHandler = new AccountHandler();
            var accountRepository = new AccountRepository();

            //Create a customer and save him
            var customer = customerHandler.CreateCustomer(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhone.Text);
            customerRepository.SaveCustomerToJson(customer);

            //Create a account and save it
            var account = accountHandler.CreateAccount(customer.CustomerId, comboBoxAccountType.Text);
            accountRepository.SaveAccountToJson(account);

            //Update 
            this.mainForm.UpdateCustomerList();

            this.Close();
        }
    }
}
