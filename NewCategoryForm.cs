using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DarkUI.Controls;
using DarkUI.Forms;
using Newtonsoft.Json;

namespace Store
{
    public partial class NewCategoryForm : DarkForm
    {
        private bool CategoryNotSubcategory;
        public NewCategoryForm(bool CategoryNotSubcategory)
        {
            InitializeComponent();
            this.CategoryNotSubcategory = CategoryNotSubcategory;
            List<Category> categories = Utils.readAllCategories();
            foreach (var category in categories)
            {
                categoriesListView.Items.Add(new DarkListItem(category.Name));
            }
            if (CategoryNotSubcategory)
            {
                this.Text = "Новая категория";
            }
            else
            {
                this.Text = "Новая подкатегория";
            }
        }

        private void categoriesListView_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (categoriesListView.SelectedIndices.Count > 0 && nameTextBox.Text.Length > 0)
            {
                buttonApply.Enabled = true;
            }
            else
            {
                buttonApply.Enabled = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (categoriesListView.SelectedIndices.Count > 0 && nameTextBox.Text.Length > 0 && CategoryNotSubcategory == false)
            {
                buttonApply.Enabled = true;
            }
            else if (CategoryNotSubcategory && nameTextBox.Text.Length > 0)
            {
                buttonApply.Enabled = true;
            }
            else
            {
                buttonApply.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            List<Category> categories = Utils.readAllCategories();
            if (CategoryNotSubcategory)
            {
                if (categories.Find(cat => cat.Name.Equals(nameTextBox.Text)) != null)
                {
                    DarkMessageBox.ShowError("Такая категория уже существует!", "Ошибка");
                }
                else
                {
                    categories.Add(new Category(nameTextBox.Text));
                    categoriesListView.Items.Clear();
                    foreach (Category category in categories)
                    {
                        categoriesListView.Items.Add(new DarkListItem(category.Name));
                    }
                    Utils.writeCategories(categories);
                    DarkMessageBox.ShowInformation("Новая категория успешно создана.", "Успешно");
                    Close();
                }
            }
            else
            {
                int index = categories.FindIndex(cat => cat.Name.Equals(categoriesListView.Items[categoriesListView.SelectedIndices[0]].Text));
                if (categories[index].Subcategories.Find(subcat => subcat.Name.Equals(nameTextBox.Text)) != null)
                {
                    DarkMessageBox.ShowError("Такая подкатегория уже существует в данной категории!", "Ошибка");
                }
                else
                {
                    categories[index].Subcategories.Add(new Subcategory(nameTextBox.Text));
                    Utils.writeCategories(categories);
                    DarkMessageBox.ShowInformation($"Новая подкатегория для категории \"{categories[index].Name}\" успешно создана.", "Успешно");
                    Close();
                }
            }
        }
    }
}
