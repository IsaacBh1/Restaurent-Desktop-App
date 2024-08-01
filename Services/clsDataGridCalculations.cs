using System.Windows.Forms;

namespace Restaurent.Services
{
    public static partial class clsDataGridCalculations
    {
        public static double CalculateBill(DataGridView dataGridViewPOS)
        {
            float NumberofItems;
            double ItemPrice;
            double amount = 0;
            for (int i = 0; i < dataGridViewPOS.Rows.Count; i++)
            {
                //the cell 3 is about the product price 
                // the cell 2 is about the numbe of products 
                if (!((dataGridViewPOS.Rows[i].Cells[1] is null) || (dataGridViewPOS.Rows[i].Cells[1].Value is null)))
                {
                    NumberofItems = float.Parse(dataGridViewPOS.Rows[i].Cells[3].Value.ToString());
                    ItemPrice = double.Parse(dataGridViewPOS.Rows[i].Cells[2].Value.ToString());
                    amount += NumberofItems * ItemPrice;

                }
            }
            return amount;
        }

    }
}