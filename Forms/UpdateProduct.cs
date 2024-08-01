using Restaurent.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurent.Forms
{
    public partial class UpdateProduct : Form
    {

        public clsProduct product = null;
        string ImagePath = null;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductNameTextBox.Text.ToString()) ||
               string.IsNullOrEmpty(ProductOriginalPriceTextBox.Text.ToString()) ||
               string.IsNullOrEmpty(ProductCategoryComboBox.Text.ToString()) ||
               string.IsNullOrEmpty(ProductSalePriceTextBox.Text.ToString()) ||
               string.IsNullOrEmpty(product.ImagePath)
               )

            {
                MessageBox.Show("Invalid Operation, something missed");

            }
            else
            {
                product.Name = ProductNameTextBox.Text;
                product.Category = ProductCategoryComboBox.Text;
                product.SalePrice = float.Parse(ProductSalePriceTextBox.Text);
                product.OriginalPrice = float.Parse(ProductOriginalPriceTextBox.Text); 
                product.ImagePath = ImagePath; 
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            ProductImage.Image =Image.FromFile(product.ImagePath);
            ProductNameTextBox.Text = product.Name;
            ProductCategoryComboBox.Text = product.Category  ;
            ProductSalePriceTextBox.Text    = product.SalePrice.ToString();
            ProductOriginalPriceTextBox.Text= product.OriginalPrice.ToString();
            ImagePath = product.ImagePath; 
        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
                openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    product.ImagePath = openFileDialog1.FileName;
                    ProductImage.Image = Image.FromFile(product.ImagePath);
                    ImagePath = product.ImagePath; 

                }   
        }
    }
}
