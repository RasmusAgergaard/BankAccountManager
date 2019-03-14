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

        public EditCustomer()
        {
            InitializeComponent();
        }

        private string _customerId;
        public EditCustomer(string customerId)
        {
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
            

            //Remove existing customer from list

            //Add new customer to list

            //Write data to json
        }
    }
}
