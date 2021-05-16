using System;
using ParMath.Class;
using System.Windows.Forms;

namespace ParMath
{
    public partial class AuthorizationForm : Form
    {
        private Engine _currentEngine;
        private TournametForm _tournametForm;
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            _currentEngine = Engine.GetEngine();
            _currentEngine.Seeds(7);
            _tournametForm = new TournametForm();
            
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
            if (_currentEngine.FindUser(LoginTextBox.Text, PasswordTextBox.Text))
            {
                _tournametForm.Show();
                this.Hide();
            } else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Error: incorrect username or password";
                ConfirmPasswordTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                LoginTextBox.Text = string.Empty;
            }
        }

        private void ConfirmRegistrationButton_Click(object sender, EventArgs e)
        {
            if (_currentEngine.UniquelyUser(LoginTextBox.Text))
            {
                if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
                {
                    User registrationUser = User.CreateUser(LoginTextBox.Text, PasswordTextBox.Text);
                    if (registrationUser == null)
                    {
                        ErrorMessage.Visible = true;
                        ErrorMessage.Text = "Error: Confirm password and Password do not match";
                        ConfirmPasswordTextBox.Text = string.Empty;
                        PasswordTextBox.Text = string.Empty;
                        LoginTextBox.Text = string.Empty;
                    }
                    else
                    {
                        _currentEngine.Users.Add(registrationUser);
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
                else
                {
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = "Error: Confirm password and Password do not match";
                    ConfirmPasswordTextBox.Text = string.Empty;
                    PasswordTextBox.Text = string.Empty;
                    LoginTextBox.Text = string.Empty;
                }
            } else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Error: users already exist";
                ConfirmPasswordTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                LoginTextBox.Text = string.Empty;
            }
        }
    }
}
