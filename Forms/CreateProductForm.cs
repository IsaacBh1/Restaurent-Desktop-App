using Restaurent.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurent
{
    public partial class CreateProductForm : Form
    {
        public string strProductImagePath = string.Empty;
        public clsProduct product = null;
        public CreateProductForm()
        {
            InitializeComponent();
            ProductNameTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductImage_Click(object sender, EventArgs e)
        { 
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;"; 
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strProductImagePath = openFileDialog1.FileName;
                ProductImage.Image = Image.FromFile(strProductImagePath);

            }
        }

        private void ValidateProductName(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(ProductNameTextBox.Text))
            {
                e.Cancel = true;
                ProductNameTextBox.Focus();
                errorProvider.SetError(ProductNameTextBox, "the product name should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(ProductNameTextBox, ""); 
            }
        }

        private void ValidateOriginalPrice(object sender, CancelEventArgs e)
        {
            float price; 
            if (string.IsNullOrEmpty(ProductOriginalPriceTextBox.Text))
            {
                e.Cancel = true;
                ProductOriginalPriceTextBox.Focus();
                errorProvider.SetError(ProductOriginalPriceTextBox, "the original price should have a value");
            }
            else if (!float.TryParse(ProductOriginalPriceTextBox.Text, out price))
            {
                e.Cancel = true;
                ProductOriginalPriceTextBox.Focus();
                errorProvider.SetError(ProductOriginalPriceTextBox, "the original price should be a number");
            }
            
            else
            {
                e.Cancel = false;
                errorProvider.SetError(ProductOriginalPriceTextBox, "");
            }
        }

        private void ValidateSalePrice(object sender, CancelEventArgs e)
        {
            float price;
            if (string.IsNullOrEmpty(ProductSalePriceTextBox.Text) )
            {
                e.Cancel = true;
                ProductSalePriceTextBox.Focus();
                errorProvider.SetError(ProductSalePriceTextBox, "the sale price should have a value");
            }
            else if(!float.TryParse(ProductSalePriceTextBox.Text ,out price))
            {
                e.Cancel = true;
                ProductSalePriceTextBox.Focus();
                errorProvider.SetError(ProductSalePriceTextBox, "the sale price should be a number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(ProductSalePriceTextBox, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductNameTextBox.Text.ToString()) || 
                string.IsNullOrEmpty(ProductOriginalPriceTextBox.Text.ToString())||
                string.IsNullOrEmpty(ProductCategoryComboBox.Text.ToString()) ||
                string.IsNullOrEmpty(ProductSalePriceTextBox.Text.ToString()) ||
                string.IsNullOrEmpty(strProductImagePath)
                )

            {
                MessageBox.Show("Invalid Operation, something missed"); 

            }
            else
            {
                product = new clsProduct(ProductNameTextBox.Text,
                    ProductCategoryComboBox.Text,
                    float.Parse(ProductSalePriceTextBox.Text),
                    float.Parse(ProductOriginalPriceTextBox.Text),
                    openFileDialog1.FileName);
                    DialogResult = DialogResult.OK; Close(); 
            }
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
