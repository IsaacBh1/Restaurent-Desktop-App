using System;

namespace Restaurent.Models
{
    public class clsBill
    {
        private static int BillsCounter = 0; 
        public int Id { get; set; }
        public float BillPrice { get; set; }
        public DateTime BillDate { get; set; }
        public bool IsPaid { get; set; }

        public clsBill(float BillPrice , DateTime BillDate , bool IsPaid = true) { 
            
            this.BillPrice = BillPrice;
            this.BillDate = BillDate;
            this.IsPaid = IsPaid;
            Id = BillsCounter++;
        }
        public clsBill() { 
            Id = BillsCounter++;
        }

        public static void ResetCounter()
        {
            BillsCounter = 0;
        }

    }
}
