using Restaurent.Models;
using Restaurent.Utility;
using StringUtility;
using System.IO;
using System.Linq;
namespace Restaurent.Services
{
    public sealed class clsProductOperations
    {
        public static clsProduct[] GetAllProducts(string FilePath)
        {
            string[] AllProductsStr = clsFileUtil.ReadAllFile(FilePath);
            clsProduct[] AllProductsObj = new clsProduct[AllProductsStr.Length];


            for (int i = 0; i < AllProductsStr.Length; i++)
            {
                clsProduct product = new clsProduct(null, null, -1, -1, null);
                product.id = int.Parse(StringUtil.SplitLine(AllProductsStr[i]).ElementAt(0));
                product.Name = StringUtil.SplitLine(AllProductsStr[i]).ElementAt(1);
                product.Category = StringUtil.SplitLine(AllProductsStr[i]).ElementAt(2);
                product.OriginalPrice = float.Parse(StringUtil.SplitLine(AllProductsStr[i]).ElementAt(3));
                product.SalePrice = float.Parse(StringUtil.SplitLine(AllProductsStr[i]).ElementAt(4));
                product.ImagePath = StringUtil.SplitLine(AllProductsStr[i]).ElementAt(5);
                AllProductsObj[i] = product;
            }


            return AllProductsObj;

        }


        public static void AddProductToFile(string FilePath, clsProduct product)
        {

            if (!(product is null))
            {
                string Line = product.id.ToString()+ '#' + product.Name + '#' + product.Category + '#' + product.OriginalPrice + '#' + product.SalePrice + '#' + product.ImagePath;
                clsFileUtil.WriteLineIntoFile(FilePath, Line);
            }
        }

        public static clsProduct SarchProduct(int id, clsProduct[] Admins)
        {
            foreach (clsProduct product in Admins)
            {
                if (product.id == id)
                {
                    return product;
                }

            }
            return null;
        }
        public static void RemoveProduct(int id)
        {
            clsProduct[] AllProducts = GetAllProducts(clsGlobal.FileProductsPath);
            //that means make the file empty
            File.WriteAllText(clsGlobal.FileProductsPath , string.Empty);
            
            int Id = 0;
            clsProduct.CounterCreationData = 0; 
            foreach (clsProduct product in AllProducts)
            {
                if(product.id != id)
                {
                    product.id = Id++;
                    AddProductToFile(clsGlobal.FileProductsPath, product); 
                    
                }
                
            }

        }


        public static void UpdateProduct(int id , clsProduct Updatedproduct)
        {
            clsProduct[] AllProducts = GetAllProducts(clsGlobal.FileProductsPath);
            //that means make the file empty
            File.WriteAllText(clsGlobal.FileProductsPath, string.Empty);
            clsProduct.CounterCreationData = 0; 
            int counter = 0; 
            foreach (clsProduct product in AllProducts)
            {
                if (product.id == id)
                {
                    AllProducts[id] = Updatedproduct;
                }
                AddProductToFile(clsGlobal.FileProductsPath, AllProducts[counter]);
                counter++;

            }

        }


    }
}