using System;
using System.Windows.Forms;
using ResturantManagemantSys;
using RestirantManagement.Utility;
using GlobalItems;
using ResturantManagemantSys.Utility;
using StringUtility;
namespace Resturent_App
{
        

    public partial class SigneUp : Form
    {
        private Admin admin;

        private delegate bool ValidateType(string P); 

        Information InformationValid; 
        private bool IsInformationsValid() =>  InformationValid.FirstNameValid && InformationValid.LastNameValid  &&InformationValid.UserNameValid  &&InformationValid.EmailValid  &&InformationValid.PhoneNumberValid  && InformationValid.PasswordValid; 

        public SigneUp()
        {
            InitializeComponent();
        }

        private void SaveInformationsTodataBase()
        {
            FileUtil.WriteLineIntoFile(Global.FileAdminsPath,Admin.GetStrLineFromAdminObj(admin) ); 
        }

        private bool Validate(string InputValue , string Message , Label label , ValidateType fun)
        {
            label.Text = ""; 
            if (!fun(InputValue.ToString()))
            {
                label.Text = Message ;
                 return false;

            }
            return true;
        }

        private void ValidateInformations()
        {

            InformationValid.FirstNameValid =   Validate(FirstNameTextBox.Text, "Invalid First Name" , FirstNameValidate, (string F) => clsValidate.ValidateName(StringUtil.FirstCharUpper(F)) ); 
            InformationValid.LastNameValid =    Validate(LastNameTextBox.Text , "Invalid Last Name " , LastNameValidate , (string F) => clsValidate.ValidateName(StringUtil.FirstCharUpper(F))); 
            InformationValid.UserNameValid =    Validate(UserNameTextBox.Text , "Invalid User Name " , UserNameValidate  , (string F) => clsValidate.ValidateName(StringUtil.FirstCharUpper(F))); 
            InformationValid.EmailValid =       Validate(EmailTextBox.Text , "Invalid Email " , EmailValidate, (string F) => clsValidate.ValidateEmail(F));
            InformationValid.PhoneNumberValid = Validate(PhoneNumberTextBox.Text , "Invalid Phone Number " , PhoneNumberValidate, (string F) => clsValidate.ValidatePhoneNumber(F));
            InformationValid.PasswordValid =    Validate(PasswordTextBox.Text , "Invalid Password " , PasswordValidate, (string F) => clsValidate.ValidatePassword(F));
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            ValidateInformations(); 
            if (IsInformationsValid())
            {
                admin = new Admin(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PhoneNumberTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text); 
                SaveInformationsTodataBase(); 
                this.Close();
            }
        }
    }
}
