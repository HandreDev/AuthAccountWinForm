using AuthAccountWinForm.App_code;
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

namespace AuthAccountWinForm
{
    public partial class StartUp : Form
    {
        private LinqToSQLDataContext _context = new LinqToSQLDataContext();
        private bool[] requirments = new bool[5];
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (requirments.All(x => x))
            {
                User user = new User();
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.DOB = dtpDOB.Value;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.IsAdmin = false;

                _context.Users.InsertOnSubmit(user);

                _context.SubmitChanges();
            }
            else 
            {
                MessageBox.Show("Please fill in the required Sections");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_context.Users.Any(user => user.Email == txtLoginEmail.Text))
            {
                lblLoginEmailException.Text = "";
                var userPassword = (from User in _context.Users where User.Email == txtLoginEmail.Text select User.Password).FirstOrDefault();

                if (userPassword == txtLoginPassword.Text)
                {
                    lblLoginPasswordException.Text = "";

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Accounts accounts = new Accounts();
                    accounts.Show();
                }
                else
                {
                    lblLoginPasswordException.Text = "Password Incorrect";
                }
            }
            else
            {
                lblLoginEmailException.Text = "Email Doesn't Exist";
            }
        }

        private void TextChangedName(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblNameException.Text = "Name required";
                requirments[0] = false;
            }
            else
            {
                lblNameException.Text = "";
                requirments[0] = true;
            }
        }

        private void TextChangedSurname(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                lblSurnameException.Text = "Surname required";
                requirments[1] = false;
            }
            else
            {
                lblSurnameException.Text = "";
                requirments[1] = true;
            }
        }

        private void TextChangedEmail(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmailException.Text = "Email required";
                requirments[2] = false;
            }
            else if (_context.Users.Any(user => user.Email == txtEmail.Text))
            {
                lblEmailException.Text = "Email already used";
                requirments[2] = false;
            }
            else
            {
                lblEmailException.Text = "";
                requirments[2] = true;
            }
        }

        private void TextChangedPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPasswordException.Text = "Password required";
                requirments[3] = false;
            }
            else if (!Regex.Match(txtPassword.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", RegexOptions.IgnoreCase).Success)
            {
                lblPasswordException.Text = "Passwords must be at least 8 characters and\ncontain at 3 of 4 of the following: upper case (A-Z),\nlower case (a-z), number (0-9) and special\ncharacter (e.g. !@#$%^&*)";
                requirments[3] = false;
            }
            else
            {
                lblPasswordException.Text = "";
                requirments[3] = true;
            }
        }

        private void TextChangedConfirmPassword(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblConfirmPasswordException.Text = "Password Should Match";
                requirments[4] = false;
            }
            else
            {
                lblConfirmPasswordException.Text = "";
                requirments[4] = true;
            }
        }

    }
}
