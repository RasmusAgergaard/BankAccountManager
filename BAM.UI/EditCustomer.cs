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
        CustomerHandler customerHandler = new CustomerHandler();

        public EditCustomer()
        {
            InitializeComponent();
        }

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

            //Populate fields
            textBoxFirstName.Text = customerToEdit.FirstName;
            textBoxLastName.Text = customerToEdit.LastName;
            textBoxEmail.Text = customerToEdit.Email;
            textBoxPhone.Text = customerToEdit.PhoneNumber;
        }

        //Edit customer
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Get data from json and add to list
            var customersOldList = customerRepository.GetCustomersFromJson();
            var customersNewList = new List<Customer>();

            //Remove existing customer from list
            foreach (var customer in customersOldList)
            {
                if (customer.CustomerId != _customerId)
                {
                    customersNewList.Add(customer);
                }
            }

            //Add updated customer to list
            var newCustomer = new Customer(_customerId)
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhone.Text
            };

            customersNewList.Add(newCustomer);

            //Reset list with the new content
            customerRepository.ResetJsonWithNewList(customersNewList);

            //Update 
            this.mainForm.UpdateCustomerList();

            this.Close();
        }
    }
}
