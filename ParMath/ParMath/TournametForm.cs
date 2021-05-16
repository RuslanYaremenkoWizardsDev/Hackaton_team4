using ParMath.Class;
using System;

using System.Windows.Forms;

namespace ParMath
{
    public partial class TournametForm : Form
    {
        AuthorizationForm authorizationForm;
        private Engine _currentEngine;

        public TournametForm()
        {
            InitializeComponent();
        }
        private void TournametForm_Load(object sender, EventArgs e)
        {
            authorizationForm = new AuthorizationForm();
            _currentEngine = Engine.GetEngine();
            
        }
        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            _currentEngine.SaveAllUsers();
            authorizationForm.Show();
            this.Hide();
        }
    }
}
