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
