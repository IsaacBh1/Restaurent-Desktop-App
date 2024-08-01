using System.Drawing;
using System.Windows.Forms;
namespace Restaurent.Services
{
    public static class clsPrintService
    {
        public static void PrintBill(PrintPreviewDialog printPreviewDialog, System.Drawing.Printing.PrintPageEventArgs e, DataGridView dataGridViewPOS , string Price)
        {
            printPreviewDialog.Width = 600;
            printPreviewDialog.Height = 600;

            int yPos = 0;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;

            // Print header
            foreach (DataGridViewColumn column in dataGridViewPOS.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, leftMargin, topMargin + yPos);
                leftMargin += column.Width;
            }

            yPos += 30;
            leftMargin = e.MarginBounds.Left;

            // Draw a line under the header
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, topMargin + yPos, e.MarginBounds.Right, topMargin + yPos);

            
            foreach (DataGridViewRow row in dataGridViewPOS.Rows)
            {
                if (row.IsNewRow) continue;
                yPos += 5; 
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), new Font("Arial", 10), Brushes.Black, leftMargin, topMargin + yPos);
                    leftMargin += cell.OwningColumn.Width;
                }
                yPos += 30;
                leftMargin = e.MarginBounds.Left;

                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, topMargin + yPos, e.MarginBounds.Right, topMargin + yPos);

            }
            e.Graphics.DrawString("Total : " + Price, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, leftMargin, topMargin + yPos + 40);

        }
    }
}
