/*

using Restaurent.Models;
using Restaurent.Utility;
using StringUtility;
using System;

namespace Restaurent.Services
{
    public class clsBillsService
    {

        public static clsBill[] GetAllBills(string FilePath)
        {
            string[] AllBillsStr = clsFileUtil.ReadAllFile(FilePath);
            clsBill[] AllBillsObj = new clsBill[AllBillsStr.Length];


            for (int i = 0; i < AllBillsStr.Length; i++)
            {
                //DateTime. Parse(date)
                clsBill Bill = new clsBill(0 , DateTime.Now);
                Bill.Id = int.Parse(StringUtil.SplitLine(AllBillsStr[i]).ElementAt(0));
                Bill.BillPrice = StringUtil.SplitLine(AllBillsStr[i]).ElementAt(1);
                Bill.BillDate = StringUtil.SplitLine(AllBillsStr[i]).ElementAt(3);
                Bill.IsPaid = StringUtil.SplitLine(AllBillsStr[i]).ElementAt(2);
                AllBillsObj[i] = Bill;
            }


            return AllBillsObj;

        }
    }
}
*/