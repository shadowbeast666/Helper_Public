using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Windows
{
    public partial class ChangePassword : Form
    {


        public ChangePassword()
        {
            InitializeComponent();
        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,20}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                errorlabel.Text = ErrorMessage;
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                errorlabel.Text = ErrorMessage;
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than 8 or greater than 20 characters";
                errorlabel.Text = ErrorMessage;
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                errorlabel.Text = ErrorMessage;
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                errorlabel.Text = ErrorMessage;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var current_password = currenttextBox.Text;
            var new_password = newtextBox.Text;
            var confirm_password = newtextBox.Text;
            string ErrorMessage;

            DataAccess db = new DataAccess();
            if (current_password == String.Empty || new_password == String.Empty || confirm_password == String.Empty)
            {
                ErrorMessage = "Password should not be empty !";
                errorlabel.Text = ErrorMessage;

            }
            else if(!db.LoginValidation(Login.Username, current_password))
            {
                ErrorMessage = "The current password does not match !";
                errorlabel.Text = ErrorMessage;

            }
            else if (new_password != confirm_password)
            {
                ErrorMessage = "The passwords provided do not match !";
                errorlabel.Text = ErrorMessage;
            }
            else if(!ValidatePassword(new_password, out ErrorMessage))
            {
                errorlabel.Text = ErrorMessage;
            }
            else
            {
                var hash = SecurePasswordHasher.Hash(new_password);
                if (SecurePasswordHasher.Verify(new_password, hash))
                {
                    db.ChangePassword(Login.Username, hash);
                }
                

            }
        }

        private void currenttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
