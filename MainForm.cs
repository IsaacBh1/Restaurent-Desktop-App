using Restaurent.Forms;
using Restaurent.Models;
using Restaurent.Properties;
using Restaurent.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Panel = System.Windows.Forms.Panel; 
namespace Restaurent
{
    public partial class MainForm : Form
    {
        public List<clsProductUi> ListOfProducts = new List<clsProductUi>();

        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
            LoadAll(); 
        }

        public void StoreProductIntoFile(clsProduct product)
        {
            clsProductOperations.AddProductToFile(clsGlobal.FileProductsPath, product);
        }

        public void LoadAllProductsFromFile()
        {
            clsProduct[] AllProducts = clsProductOperations.GetAllProducts(clsGlobal.FileProductsPath);
            foreach (clsProduct item in AllProducts)
            {
                ListOfProducts.Add(new clsProductUi(item, item.ProductComponent())); 
            }
        }


        public void LoadAll()
        {

            ListOfProducts.Clear();
            ClearAllProductsFromUI();
            ClearListOfProductsUI(); 
            LoadAllProductsFromFile();
            LoadAllProductToUI();
            LoadProductsToProductsSection();

        }

        public void ClearListOfProductsUI()
        {
            dataGridProductOperations.Rows.Clear();

        }



        public void LoadAllProductToUI()
        {

            foreach (clsProductUi product in ListOfProducts)
            {
                AddProductToUI(product); 
            }
        }

        public void LoadProductsToProductsSection()
        {
            foreach (clsProductUi item in ListOfProducts)
            {
                    dataGridProductOperations.Rows.Add(item.ProductInformations.id,
                    item.ProductInformations.Name, 
                    item.ProductInformations.Category, 
                    item.ProductInformations.OriginalPrice, 
                    item.ProductInformations.SalePrice, 
                    Resources.pen_tool, 
                    Resources.delete);
            }
        }
        private void CalculateBill()
        {
            lblAmountPrice.Text = clsDataGridCalculations.CalculateBill(dataGridViewPOS).ToString() + " AD";
        }

        private void addProduct_OnClick(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)sender).Tag.ToString());
            int numberOfItems = ListOfProducts[index].GetNumberOfProductsSaled(); 
            dataGridViewPOS.Rows.Add( clsGlobal.NumberOfItemsSealed ,ListOfProducts[index].ProductInformations.Name, ListOfProducts[index].ProductInformations.SalePrice, numberOfItems);
            clsGlobal.NumberOfItemsSealed++; 
            CalculateBill();

        }

        private void AddProductToUI(clsProductUi product) {
            product.ProductUI.Controls[3].Click += new EventHandler(addProduct_OnClick);
            // the logic that add every item to his category panel
            switch (product.ProductInformations.Category) {
                case "Fast Food":
                    FastFoodflowLayoutPanel.Controls.Add(product.ProductUI); 
                break;
                case "Traditional Food":
                    TraditionalflowLayoutPanel.Controls.Add(product.ProductUI);
                    break;  
                case "Modern Food": 
                    ModernFoodflowLayoutPanel.Controls.Add(product.ProductUI);
                    break;
                case "Drinks":
                    DrinksflowLayoutPanel.Controls.Add(product.ProductUI);
                    break; 
            }


        }
        private void ChangeTabIndex(object sender, EventArgs e)
        {
            MenuOfSystem.SelectedIndex = int.Parse(((Button)sender).Tag.ToString());
        }
        private void clearFloatViewScrren(FlowLayoutPanel floatpanel)
        {
            foreach (Panel controle in floatpanel.Controls)
            {
                controle.Controls[2].Text = "1";
            }
        }

        private void btnClearDataGridVew_Click(object sender, EventArgs e)
        {
            dataGridViewPOS.Rows.Clear();
            clearFloatViewScrren(FastFoodflowLayoutPanel); 
            clearFloatViewScrren(DrinksflowLayoutPanel);
            clearFloatViewScrren(ModernFoodflowLayoutPanel);
            clearFloatViewScrren(TraditionalflowLayoutPanel);
            clsGlobal.NumberOfItemsSealed = 1;

            lblAmountPrice.Text = "0 AD"; 

        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateBill();

        }

        private void ChangeBill(object sender, DataGridViewCellEventArgs e)
        {
            CalculateBill();

        }
        private void ExitWindow(object sender, EventArgs e)
        {
            Close(); 
        }

        private void AddProductbtn_Click(object sender, EventArgs e)
        {
            CreateProductForm ProductForm = new CreateProductForm();
            var result = ProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                clsProduct product = ProductForm.product;
                clsProductUi ProductUi = new clsProductUi(product, product.ProductComponent());
                AddProductToUI(ProductUi);
                ListOfProducts.Add(ProductUi);
                StoreProductIntoFile(product); 
            }
            //this  is when refresh the DataGrid View 
            ClearListOfProductsUI();
            LoadProductsToProductsSection();

        }



        private void ClearAllProductsFromUI()
        {
            FastFoodflowLayoutPanel.Controls.Clear();
            DrinksflowLayoutPanel.Controls.Clear();
            ModernFoodflowLayoutPanel.Controls.Clear();
            TraditionalflowLayoutPanel.Controls.Clear(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss"); 
        }

        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            ClearListOfProductsUI(); 
            LoadProductsToProductsSection();

        }

        private void PrintBill(object sender, PrintPageEventArgs e)
        {
            clsPrintService.PrintBill(printPreviewDialog, e, dataGridViewPOS , lblAmountPrice.Text.ToString()); 
        }


        private void button10_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog(); 
            printDialog.ShowDialog();  
        }


        private void RemoveProduct(int Id)
        {
            DialogResult Result = MessageBox.Show("Do You Want to remove this Product", "Question", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
            clsProductOperations.RemoveProduct(Id);
            LoadAll(); 


            }
                    
        }


        private void UpdateProduct(int Id)
        {

            UpdateProduct ProductForm = new UpdateProduct();
            ProductForm.product = ListOfProducts[Id].ProductInformations; 
            var result = ProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                clsProduct product = ProductForm.product;
                ListOfProducts[Id].ProductInformations = ProductForm.product;
                
                clsProductOperations.UpdateProduct(Id , product); 
            }
            //this  is when refresh the DataGrid View

            LoadAll(); 
        }

        private void CellOperationDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                 int ProductId = Convert.ToInt32(dataGridProductOperations.Rows[e.RowIndex].Cells[0].Value);
                UpdateProduct(ProductId); 
                            }
            else if (e.ColumnIndex == 6)
            {
                int ProductId = Convert.ToInt32(dataGridProductOperations.Rows[e.RowIndex].Cells[0].Value);
                RemoveProduct(ProductId);
            }
        }

        private void AboutUsClicked(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }
    }
}
