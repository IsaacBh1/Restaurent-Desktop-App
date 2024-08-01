using System.IO;
namespace Restaurent.Utility
{
    public static class clsFileUtil
    {
        public static string[] ReadAllFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string[] Lines = File.ReadAllLines(FilePath);
                return Lines;
            }
            return null;
        }

        public static void WriteLineIntoFile(string FilePath, string Line)
        {
            if (File.Exists(FilePath))
            {
                File.AppendAllText(FilePath, Line + "\n");
            }
        }
    }
}
