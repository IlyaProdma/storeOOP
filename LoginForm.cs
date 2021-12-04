using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DarkUI.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;


namespace Store
{
    public partial class LoginForm : DarkForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textboxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonSignIn.Enabled = (textboxLogin.Text != "" && textboxPassword.Text != "");
        }

        private void textboxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonSignIn.Enabled = (textboxLogin.Text != "" && textboxPassword.Text != "");
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            labelAlertNoUsersInFile.Visible = false;
            string json = File.ReadAllText("customers.json");
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            byte[] tmpSource = UTF8Encoding.UTF8.GetBytes(textboxPassword.Text);
            byte[] inputPassword = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            if (customers == null)
            {
                labelAlertNoUsersInFile.Text = "There are currently no users, please sign up to continue.";
                labelAlertNoUsersInFile.Visible = true;
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    if (customer.Login == textboxLogin.Text && customer.Password.SequenceEqual(inputPassword))
                    {
                        textboxLogin.Text = "EBAT'";
                    }
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            labelAlertNoUsersInFile.Visible = false;
            string json = File.ReadAllText("customers.json");
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            byte[] tmpSource = UTF8Encoding.UTF8.GetBytes(textboxPassword.Text);
            byte[] inputPassword = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            if (customers == null || customers.Where<Customer>(cs => cs.Login.ToLower() == textboxLogin.Text.ToLower()).Count() <= 0)
            {
                Customer newCustomer = new Customer(textboxLogin.Text, textboxPassword.Text);
                if (customers == null)
                {
                    customers = new List<Customer>();
                }
                customers.Add(newCustomer);
                json = JsonConvert.SerializeObject(customers, Formatting.Indented);
                File.WriteAllText("customers.json", json.ToString());
                labelAlertNoUsersInFile.Text = "Successfull sign up.";
                labelAlertNoUsersInFile.Visible = true;
            }
            else if (customers.Where<Customer>(cs => cs.Login.ToLower() == textboxLogin.Text.ToLower()).Count() > 0)
            {
                labelAlertNoUsersInFile.Text = "There is already a user with this name.";
                labelAlertNoUsersInFile.Visible = true;
            }
        }
    }
}
