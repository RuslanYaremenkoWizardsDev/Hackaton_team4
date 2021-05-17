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
    public partial class CreateTournamentForm : Form
    {
        public CreateTournamentForm()
        {
            InitializeComponent();
            if (ChangeTheme.thememode == true)
            {
                this.BackColor = Color.White;
                NameOfTournamentLabel.ForeColor = Color.Black;
                StartDateLabel.ForeColor = Color.Black;
                LastRegistrationDateLabel.ForeColor = Color.Black;
                LevelLabel.ForeColor = Color.Black;
                CountOfParticipantsLabel.ForeColor = Color.Black;
                StateLabel.ForeColor = Color.Black;
                ScenarioLabel.ForeColor = Color.Black;
                PlaceLabel.ForeColor = Color.Black;
                DescriptionLabel.ForeColor = Color.Black;
                Create.BackColor = Color.White;
                Create.ForeColor = Color.Black;
                NameOfTournamentTextBox.BackColor = Color.White;
                NameOfTournamentTextBox.ForeColor = Color.Black;
                PlaceTextBox.BackColor = Color.White;
                PlaceTextBox.ForeColor = Color.Black;
                DescriptionListBox.BackColor = Color.White;
                DescriptionListBox.ForeColor = Color.Black;
                StartDateDateTimePicker.CalendarForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                NameOfTournamentLabel.ForeColor = Color.White;
                StartDateLabel.ForeColor = Color.White;
                LastRegistrationDateLabel.ForeColor = Color.White;
                LevelLabel.ForeColor = Color.White;
                CountOfParticipantsLabel.ForeColor = Color.White;
                StateLabel.ForeColor = Color.White;
                ScenarioLabel.ForeColor = Color.White;
                PlaceLabel.ForeColor = Color.White;
                DescriptionLabel.ForeColor = Color.White;
                Create.BackColor = Color.Black;
                Create.ForeColor = Color.White;
                NameOfTournamentTextBox.BackColor = Color.Black;
                NameOfTournamentTextBox.ForeColor = Color.White;
                PlaceTextBox.BackColor = Color.Black;
                PlaceTextBox.ForeColor = Color.White;
                DescriptionListBox.BackColor = Color.Black;
                DescriptionListBox.ForeColor = Color.White;
                StartDateDateTimePicker.CalendarForeColor = Color.White;
            }
        }

        private void GoToMyAccountButton_Click(object sender, EventArgs e)
        {
            MyAccountForm myAccountForm = new MyAccountForm();
            myAccountForm.Show();
            this.Hide();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            TournametForm tournamet = new TournametForm();
            tournamet.Show();
            this.Hide();
        }
    }
}
