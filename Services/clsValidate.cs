using System.Text.RegularExpressions;
namespace ResturantManagemantSys.Utility
{
    public static class clsValidate
    {


        public static bool ValidateName(string field)
        {
            return Regex.Match(field, @"([A-Z][a-z]*)([\\s\\\'-][A-Z][a-z]*)*").Success;
        }

        public static bool ValidateEmail(string Email)
        {

            if (Email.Contains(" ")) return false;
            return Email.EndsWith("@gmail.com") || Email.EndsWith("@yahoo.com") || Email.EndsWith("@outlook.com") || Email.EndsWith("@hotmail.com");

        }

        public static bool ValidatePhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber.Length < 10) return false;
            foreach (char c in PhoneNumber)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidatePassword(string Password) => !(Password is null || Password.Length < 5);

    }
}
