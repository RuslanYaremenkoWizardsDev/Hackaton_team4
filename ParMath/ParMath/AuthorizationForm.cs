using System;
using ParMath.Class;
using System.Windows.Forms;
using System.Drawing;

namespace ParMath
{
    public partial class AuthorizationForm : Form
    {
        private Engine _currentUsers = new Engine();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            ConfirmPasswordLabel.Visible = true;
            ConfirmPasswordTextBox.Visible = true;
            ConfirmRegistrationButton.Visible = true;
            SignInButton.Enabled = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
        }

        private void ConfirmRegistrationButton_Click(object sender, EventArgs e)
        {
            User registrationUser = User.CreateUser(LoginTextBox.Text, PasswordTextBox.Text);

            if (registrationUser == null )
            {
                ErrorMessage.Visible = true;
            } else
            {
                _currentUsers.Users.Add(registrationUser);
                _currentUsers.AddToDictionary(registrationUser);

                ErrorMessage.Visible = false;
                ConfirmPasswordLabel.Visible = false;
                ConfirmPasswordTextBox.Visible = false;
                ConfirmRegistrationButton.Visible = false;
                SignInButton.Enabled = true;
                ConfirmPasswordTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                LoginTextBox.Text = string.Empty;
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
        }
    }
}
