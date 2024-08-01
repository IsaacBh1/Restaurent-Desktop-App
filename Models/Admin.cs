
using StringUtility;

namespace ResturantManagemantSys
{
    public class Admin : Person
    {
        private string Password;

        public Admin(string FirstName, string LastName, string Email, string PhoneNumber, string UserName, string Password)
            : base(FirstName, LastName, Email, UserName, PhoneNumber)
        {
            this.Password = Password;

        }


        public void SetPassword(string Password)
        {
            this.Password = StringUtil.encryptPassword(Password);
        }
        public string GetPassword() => StringUtil.decryptPassword(Password);


        public static Admin GetAdminObjFromInformations(string FirstName, string LastName, string Email, string PhoneNumber, string UserName, string Password)
        => new Admin(FirstName, LastName, Email, PhoneNumber, UserName, Password);

        public static string GetStrLineFromAdminObj(Admin admin, string seprator = "#") =>
            admin.FirstName + seprator + admin.LastName + seprator + admin.Email + seprator + admin.PhoneNumber + seprator + admin.UserName + seprator + admin.GetPassword();



    }

}
