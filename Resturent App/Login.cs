using System;
using System.Windows.Forms;
using RestirantManagement.Utility;
using ResturantManagemantSys;
using GlobalItems;
using System.Drawing;
namespace Resturent_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigneUp SigneUpForme = new SigneUp();
            SigneUpForme.Show();
        }

        private Admin ValidateLogin()
        {
            
            ErrorMessage.Text = string.Empty;

            Admin[] Admins = AdminOperations.GetAllAdminsObj(Global.FileAdminsPath);
            Admin admin  = AdminOperations.SarchAdmin(UserNameTextBox.Text , PasswordTextBox.Text , Admins);
            if (admin is null)
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Invalid Informations try agein";
                UserNameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                return null; 
            }
            else
            {
                return admin;

            }


        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!(ValidateLogin() is null))
            {
                MainForm mainForm = new MainForm();
                Hide(); 
                mainForm.ShowDialog();
            }
        }
    }
}
