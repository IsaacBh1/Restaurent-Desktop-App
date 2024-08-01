
using System.Windows.Forms;

namespace Restaurent.Models
{
    public class clsProductUi
    {
        public clsProduct ProductInformations = null;
        public Panel ProductUI = null;

        public clsProductUi(clsProduct ProductInformations, Panel ProductUI)
        {
            this.ProductUI = ProductUI;
            this.ProductInformations = ProductInformations;

        }

        public int GetNumberOfProductsSaled()
        {
            if ((ProductInformations != null) && (ProductUI != null))
            {
                return int.Parse(ProductUI.Controls[2].Text.ToString());
            }
            return -1;
        }
    }
}
