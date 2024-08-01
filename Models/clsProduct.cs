
using Restaurent.Components;
using Panel = System.Windows.Forms.Panel;
using System.Drawing;

namespace Restaurent.Models
{
    public class clsProduct
    {
        public static int CounterCreationData = 0 ; 
        public int id {  get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float SalePrice { get; set; }
        public float OriginalPrice { get; set; }
        public string ImagePath { get; set; }
        public clsProduct(string ProductName, string ProductCategory
        , float ProductSalePrice, float ProductOriginalPrice , string ImagePath)
        {
            Name = ProductName;
            Category = ProductCategory;
            SalePrice = ProductSalePrice;
            OriginalPrice = ProductOriginalPrice;
            id = CounterCreationData; 
            this.ImagePath= ImagePath;
            CounterCreationData ++;
        }

        public Panel ProductComponent()
        {
            return clsComponent.CreateItemUi(id, Name, Image.FromFile(ImagePath)); 
        }
      }
    
    }


    
