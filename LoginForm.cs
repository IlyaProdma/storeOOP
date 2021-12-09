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
            List<Customer> customers = Utils.readAllCustomers();
            //byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(textboxPassword.Text);
            //string inputPassword = BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(tmpSource));
            string inputPassword = textboxPassword.Text;
            if (customers == null)
            {
                DarkMessageBox.ShowError("В базе нет пользователей.", "Ошибка");
            }
            else
            {
                bool correctLogin = false;
                bool correctPassword = false;
                foreach (Customer customer in customers)
                {
                    if (customer.Login.Equals(textboxLogin.Text) && customer.Password.Equals(inputPassword))
                    {
                        correctLogin = true;
                        correctPassword = true;
                        DarkMessageBox.ShowInformation("Успешный вход в систему.", "Успешно");
                        if (customer.Access == AccessLevel.customer)
                        {
                            Hide();
                            StoreCustomerForm storeCustomerForm = new StoreCustomerForm(customer);
                            storeCustomerForm.Closed += (s, args) => this.Close();
                            storeCustomerForm.Show();
                            break;
                        }
                        else if (customer.Access == AccessLevel.staff)
                        {
                            Hide();
                            StoreStaffForm storeStaffForm = new StoreStaffForm();
                            storeStaffForm.FormClosed += (s, args) => this.Close();
                            storeStaffForm.Show();
                            break;
                        }
                    }
                    else if (!customer.Password.Equals(inputPassword))
                    {
                        correctLogin = true;
                        correctPassword = false;
                    }
                }
                if (correctLogin == false)
                {
                    DarkMessageBox.ShowError("Такого пользователя нет!", "Ошибка");
                }
                if (correctPassword == false)
                {
                    DarkMessageBox.ShowError("Неверный пароль!", "Ошибка");
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            labelAlertNoUsersInFile.Visible = false;
            List<Customer> customers = Utils.readAllCustomers();
            if (customers == null || customers.Where<Customer>(cs => cs.Login.ToLower() == textboxLogin.Text.ToLower()).Count() <= 0)
            {
                Customer newCustomer = new Customer(textboxLogin.Text, textboxPassword.Text);
                if (customers == null)
                {
                    customers = new List<Customer>();
                }
                customers.Add(newCustomer);
                Utils.writeCustomers(customers);
                DarkMessageBox.ShowInformation("Успешная регистрация новго пользователя.", "Успешно");
            }
            else if (customers.Where<Customer>(cs => cs.Login.ToLower() == textboxLogin.Text.ToLower()).Count() > 0)
            {
                DarkMessageBox.ShowError("Такой пользователь уже есть!", "Ошибка");
            }
        }
    }
}
