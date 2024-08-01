
using System.Text;

namespace StringUtility
{
    public static class StringUtil
    {
        public static string encryptPassword(string password)
        {
            if (password == null) return null;

            byte[] pass = Encoding.UTF8.GetBytes(password);
            for (int i = 0; i < pass.Length; i++)
            {
                pass[i]++;
            }

            password = Encoding.UTF8.GetString(pass);

            return password;
        }

        public static string decryptPassword(string password)
        {
            if (password == null) return null;

            byte[] pass = Encoding.UTF8.GetBytes(password);

            for (int i = 0; i < pass.Length; i++)
            {
                pass[i]--;
            }
            password = Encoding.UTF8.GetString(pass);
            return password;
        }

        public static string[] SplitLine(string Line, char Separator = '#') => Line.Split(Separator);


        public static string FirstCharUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }
    }
}
