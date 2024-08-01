using StringUtility;
using ResturantManagemantSys;
using System.Linq;
using Restaurent.Utility;

namespace RestirantManagement.Utility
{
    public static class AdminOperations
    {
        public static Admin[] GetAllAdminsObj(string FilePath)
        {
            string[] AllAdminsStr = clsFileUtil.ReadAllFile(FilePath);


            Admin[] AllAdminsObj = new Admin[AllAdminsStr.Length];

            for (int i = 0; i < AllAdminsStr.Length; i++)
            {
                Admin admin = new Admin(null, null, null, null, null, null);
                admin.FirstName = StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(0);
                admin.LastName = StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(1);
                admin.Email = StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(2);
                admin.UserName = StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(3);
                admin.PhoneNumber = StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(4);
                admin.SetPassword(StringUtil.SplitLine(AllAdminsStr[i]).ElementAt(5));
                AllAdminsObj[i] = admin;
            }
            return AllAdminsObj;

        }
        public static Admin SarchAdmin(string UserName, string Password, Admin[] Admins)
        {
            foreach (Admin admin in Admins)
            {
                if ((admin.UserName == UserName) && (admin.GetPassword() == StringUtil.decryptPassword(Password))) return admin;

            }
            return null;
        }

    }


}
