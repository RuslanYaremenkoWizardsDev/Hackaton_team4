using ParMath.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParMath
{
    public partial class MyAccountForm : Form
    {
        private Engine _currentEngine;
        public MyAccountForm()
        {
            InitializeComponent();
        }
        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            ChangeThemeMethod();
            _currentEngine = Engine.GetEngine();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = true;
            OldPasswordLabel.Visible = true;
            OldPasswordTextBox.Visible = true;
            NewPasswordLabel.Visible = true;
            NewPasswordTextBox.Visible = true;
            SaveButton.Visible = true;
        }

        private void ChangeLoginButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = true;
        }

        private void ChangeThemeMethod() 
        {
            if (ChangeTheme.thememode == true)
            {
                this.BackColor = Color.White;
                ThemeButton.BackColor = Color.White;
                ThemeButton.ForeColor = Color.Black;
                SaveButton.BackColor = Color.White;
                SaveButton.ForeColor = Color.Black;
                ChangeLabel.ForeColor = Color.Black;
                OldPasswordLabel.ForeColor = Color.Black;
                NewPasswordLabel.ForeColor = Color.Black;
                NewPasswordTextBox.BackColor = Color.White;
                NewPasswordTextBox.ForeColor = Color.Black;
                OldPasswordTextBox.BackColor = Color.White;
                OldPasswordTextBox.ForeColor = Color.Black;
                GoToTournamentButton.BackColor = Color.White;
                GoToTournamentButton.ForeColor = Color.Black;
                ThemeButton.Text = "Light";
            }
            else if (ChangeTheme.thememode == false)
            {
                this.BackColor = Color.Black;
                ThemeButton.BackColor = Color.Black;
                ThemeButton.ForeColor = Color.White;
                SaveButton.BackColor = Color.Black;
                SaveButton.ForeColor = Color.White;
                ChangeLabel.ForeColor = Color.White;
                OldPasswordLabel.ForeColor = Color.White;
                NewPasswordLabel.ForeColor = Color.White;
                NewPasswordTextBox.BackColor = Color.Black;
                NewPasswordTextBox.ForeColor = Color.White;
                OldPasswordTextBox.BackColor = Color.Black;
                OldPasswordTextBox.ForeColor = Color.White;
                GoToTournamentButton.BackColor = Color.Black;
                GoToTournamentButton.ForeColor = Color.White;
                ThemeButton.Text = "Dark";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = false;
            OldPasswordLabel.Visible = false;
            OldPasswordTextBox.Visible = false;
            NewPasswordLabel.Visible = false;
            NewPasswordTextBox.Visible = false;
            SaveButton.Visible = false;
            if (!(OldPasswordTextBox.Text.Length >= 255) || !(NewPasswordTextBox.Text.Length >= 255) || !(OldPasswordTextBox.Text.Length < 6) || !(NewPasswordTextBox.Text.Length < 6))
            {
                if (OldPasswordTextBox.Text == NewPasswordTextBox.Text)
                {
                    ErrorMessage.Text = "";
                    _currentEngine.CurrentUser.Password = NewPasswordTextBox.Text;
                } else
                {
                    ErrorMessage.Text = "Error: password mismatch";
                }
            } else
            {
                ErrorMessage.Text = "Error: password must be between 6 and 255 characters.";
            }
        }

        private void GoToAuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
            this.Hide();
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if(ChangeTheme.thememode)
            {
                ChangeTheme.thememode = false;
            }
            else
            {
                ChangeTheme.thememode = true;
            }
            ChangeThemeMethod();
        }
        private void GoToTournierButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm createTournament = new CreateTournamentForm();
            createTournament.Show();
            this.Hide();
        }

        private void GoToTournamentButton_Click(object sender, EventArgs e)
        {
            TournametForm tournametForm = new TournametForm();
            tournametForm.Show();
            this.Hide();
        }
    }
}
