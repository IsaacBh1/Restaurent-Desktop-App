using System;
using System.Windows.Forms;

namespace Restaurent
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Forms.LoginForm AppForm = new Forms.LoginForm();
            Application.Run(AppForm);
        }
    }
}
