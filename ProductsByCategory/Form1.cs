using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindLibrary;
using NorthWindLibrary.Classes;

namespace ProductsByCategory
{
    public partial class Form1 : Form
    {
        private DataOperations _operations = new DataOperations();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = _operations.GetCategories();
        }

        private void BeveragesButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = _operations.GetProductsWithCategoryBeverages();
        }

        private void ConfectionsButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = _operations.GetProductsWithCategoryConfections();
        }

        private void FreeFormSelectCategoryButton_Click(object sender, EventArgs e)
        {
            var category = (Category) CategoryComboBox.SelectedItem;
            listBox1.DataSource = _operations
                .GetProducts(category.CategoryID);
        }

        private void TwoCategoryForProductsButton_Click(object sender, EventArgs e)
        {
            var resultsBeveragesAndCondiments = _operations.GetBeveragesAndCondiments();
            MessageBox.Show($"There are {resultsBeveragesAndCondiments.Count} for both categories");

        }
    }
}
