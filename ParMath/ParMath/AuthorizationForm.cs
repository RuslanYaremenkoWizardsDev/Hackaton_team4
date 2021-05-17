using System;
using ParMath.Class;
using System.Windows.Forms;
using System.Drawing;

namespace ParMath
{
    public partial class AuthorizationForm : Form
    {
        private Engine _currentEngine;
        private TournametForm _tournametForm;
        public AuthorizationForm()
        {
            InitializeComponent();
            if (ChangeTheme.thememode == true)
            {
                this.BackColor = Color.White;
                LoginLabel.ForeColor = Color.Black;
                PasswordLabel.ForeColor = Color.Black;
                ConfirmPasswordLabel.ForeColor = Color.Black;
                LoginTextBox.BackColor = Color.White;
                LoginTextBox.ForeColor = Color.Black;
                PasswordTextBox.BackColor = Color.White;
                PasswordTextBox.ForeColor = Color.Black;
                ConfirmPasswordTextBox.BackColor = Color.White;
                ConfirmPasswordTextBox.ForeColor = Color.Black;
                ConfirmRegistrationButton.BackColor = Color.White;
                ConfirmRegistrationButton.ForeColor = Color.Black;
                RegistrationButton.BackColor = Color.White;
                RegistrationButton.ForeColor = Color.Black;
                SignInButton.BackColor = Color.White;
                SignInButton.ForeColor = Color.Black;
            }
            else 
            {
                this.BackColor = Color.Black;
                LoginLabel.ForeColor = Color.White;
                PasswordLabel.ForeColor = Color.White;
                ConfirmPasswordLabel.ForeColor = Color.White;
                LoginTextBox.BackColor = Color.Black;
                LoginTextBox.ForeColor = Color.White;
                PasswordTextBox.BackColor = Color.Black;
                PasswordTextBox.ForeColor = Color.White;
                ConfirmPasswordTextBox.BackColor = Color.Black;
                ConfirmPasswordTextBox.ForeColor = Color.White;
                ConfirmRegistrationButton.BackColor = Color.Black;
                ConfirmRegistrationButton.ForeColor = Color.White;
                RegistrationButton.BackColor = Color.Black;
                RegistrationButton.ForeColor = Color.White;
                SignInButton.BackColor = Color.Black;
                SignInButton.ForeColor = Color.White;
                SignInButton.FlatAppearance.BorderSize = 0;
                SignInButton.FlatStyle = FlatStyle.Flat;
            }
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
