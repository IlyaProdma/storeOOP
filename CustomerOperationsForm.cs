using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using DarkUI.Controls;

namespace Store
{
    public partial class CustomerOperationsForm : DarkForm
    {
        public CustomerOperationsForm(List<Operation> operations)
        {
            InitializeComponent();
            foreach (Operation operation in operations)
            {
                operationsList.Items.Add(new DarkListItem(string.Format("{0} - {1}", operation.Product, operation.Date)));
            }
        }
    }
}
