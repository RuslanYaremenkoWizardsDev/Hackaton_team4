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
        public MyAccountForm()
        {
            InitializeComponent();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ChangeLoginButton.Visible = true;
            ChangePasswordButton.Visible = true;
        }

        private void ChangeLoginButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = true;
            NewLoginLabel.Visible = true;
            NewLoginTextBox.Visible = true;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = true;
            OldPasswordLabel.Visible = true;
            OldPasswordTextBox.Visible = true;
            NewPasswordLabel.Visible = true;
            NewPasswordTextBox.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangeLabel.Visible = false;
            NewLoginLabel.Visible = false;
            NewLoginTextBox.Visible = false;
            OldPasswordLabel.Visible = false;
            OldPasswordTextBox.Visible = false;
            NewPasswordLabel.Visible = false;
            NewPasswordTextBox.Visible = false;
        }
    }
}
