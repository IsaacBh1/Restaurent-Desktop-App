using RestirantManagement.Utility;
using ResturantManagemantSys;
using System;
using System.Drawing;

using System.Windows.Forms;

namespace Restaurent.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private Admin ValidateLogin()
        {

            ErrorMessage.Text = string.Empty;

            Admin[] Admins = AdminOperations.GetAllAdminsObj(clsGlobal.FileAdminPath);
            Admin admin = AdminOperations.SarchAdmin(UserNameTextBox.Text, UserNameTextBox.Text, Admins);
            if (admin is null)
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Invalid Informations try again";
                UserNameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                return null;
            }
            else  return admin;
            
        }

        private void Login(object sender, EventArgs e)
        {
            if (!(ValidateLogin() is null))
            {
                Hide();
                MainForm Main = new MainForm();
                Main.ShowDialog();
                Close();
            }

        }

        private void Close(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
