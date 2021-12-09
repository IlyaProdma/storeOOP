using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;

namespace Store
{
    public partial class RedactOperationsForm : DarkForm
    {

        private List<Customer> tempCustomers;

        public RedactOperationsForm()
        {
            InitializeComponent();
            fillUserList();
            userOperationsListView.FullRowSelect = true;
            statusDropdown.Items.Add(new DarkDropdownItem("в обработке"));
            statusDropdown.Items.Add(new DarkDropdownItem("отменен"));
            statusDropdown.Items.Add(new DarkDropdownItem("завершен"));
            statusDropdown.SelectedItem = null;
            tempCustomers = Utils.readAllCustomers();
        }

        private void fillUserList()
        {
            List<Customer> customers = Utils.readAllCustomers().Where(cs => cs.Access == AccessLevel.customer).ToList();
            foreach (var customer in customers)
            {
                usersListView.Items.Add(new DarkListItem(customer.Login));
            }
        }

        private void fillOperationsList(string Login)
        {
            List<Operation> operations = tempCustomers.Find(cs => cs.Login.Equals(Login)).Operations;
            foreach (var operation in operations)
            {
                userOperationsListView.Items.Add(new ListViewItem(new string[] { 
                                                                                operation.Product,
                                                                                operation.Date.ToString(),
                                                                                operation.Status.getDescription()
                                                                                }));
            }
        }

        private void usersListView_SelectedIndicesChanged(object sender, EventArgs e)
        {
            userOperationsListView.Items.Clear();
            statusDropdown.SelectedItem = null;
            if (usersListView.SelectedIndices.Count > 0)
            {
                fillOperationsList(usersListView.Items[usersListView.SelectedIndices[0]].Text);
            }

        }

        private void userOperationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userOperationsListView.SelectedItems.Count > 0)
            {
                switch (userOperationsListView.SelectedItems[0].SubItems[2].Text)
                {
                    case "в обработке":
                        statusDropdown.SelectedItem = statusDropdown.Items[0];
                        break;
                    case "отменен":
                        statusDropdown.SelectedItem = statusDropdown.Items[1];
                        break;
                    case "завершен":
                        statusDropdown.SelectedItem = statusDropdown.Items[2];
                        break;
                }
            }
            else
            {
                statusDropdown.SelectedItem = null;
            }
        }

        private void statusDropdown_SelectedItemChanged(object sender, EventArgs e)
        {
            if (userOperationsListView.SelectedItems.Count > 0)
            {
                userOperationsListView.SelectedItems[0].SubItems[2].Text = statusDropdown.SelectedItem.Text;
                OperationStatus newStatus;
                switch (statusDropdown.SelectedItem.Text)
                {
                    case "в обработке":
                        newStatus = OperationStatus.Processing;
                        break;
                    case "отменен":
                        newStatus = OperationStatus.Cancelled;
                        break;
                    case "завершен":
                        newStatus = OperationStatus.Completed;
                        break;
                    default:
                        newStatus = OperationStatus.Processing;
                        break;
                }
                tempCustomers.Find(cs => cs.Login.Equals(usersListView.Items[usersListView.SelectedIndices[0]].Text))
                    .Operations.Find(op => op.Date.ToString().Equals(userOperationsListView.SelectedItems[0].SubItems[1].Text))
                    .Status = newStatus;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            bool allOk = true;
            List<Product> allProducts = Utils.readAllProducts();
            List<Customer> allCustomers = Utils.readAllCustomers();
            for (int i = 0; i < tempCustomers.Count; ++i)
            {
                for (int j = 0; j < tempCustomers[i].Operations.Count; ++j)
                {
                    if (tempCustomers[i].Operations[j].Status != allCustomers[i].Operations[j].Status
                        && tempCustomers[i].Operations[j].Status == OperationStatus.Completed)
                    {
                        var op = tempCustomers[i].Operations[j];
                        if (allProducts.Find(p => p.Name.Equals(op.Product)).QuantityInStock > 0)
                        {
                            allProducts.Find(p => p.Name.Equals(op.Product)).QuantityInStock -= 1;
                        }
                        else
                        {
                            DarkMessageBox.ShowError($"Невозможно подтвердить заказ, на складе недостаточно товаров: \"{op.Product}\"", "Ошибка");
                            allOk = false;
                        }
                    }
                    else if (tempCustomers[i].Operations[j].Status != allCustomers[i].Operations[j].Status
                            && allCustomers[i].Operations[j].Status == OperationStatus.Completed)
                    {
                        var op = tempCustomers[i].Operations[j];
                        allProducts.Find(p => p.Name.Equals(op.Product)).QuantityInStock += 1;
                    }
                }
            }
            if (allOk)
            {
                Utils.writeCustomers(tempCustomers);
                Utils.writeProducts(allProducts);
                Close();
            }
        }
    }
}
