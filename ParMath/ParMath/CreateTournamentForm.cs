using ParMath.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParMath
{
    public partial class CreateTournamentForm : Form
    {
        private Tournament _tournament;
        private Engine _currentEngine;

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {
            _tournament = new Tournament();
            _currentEngine = Engine.GetEngine();
            LevelComboBox.SelectedIndex = 0;
            CountOfParticipantsComboBox.SelectedIndex = 5;
            StateComboBox.SelectedIndex = 1;
            ScenaryComboBox.SelectedIndex = 1;
        }
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

        private void Create_Click(object sender, EventArgs e)
        {

            if (!(NameOfTournamentTextBox.Text.Length >= 255) || !(NameOfTournamentTextBox.Text.Length <= 3))
            {
                ErrorMessage.Visible = false;
                _tournament.NameTournament = NameOfTournamentTextBox.Text;
            }
            else
            {
                ErrorMessage.Text = "Error: max length name tournament most be not 3 <= or >= 255 symbol.";
            }
            if (!(DescriptionTextBox.Text.Length >= 10000) || !(DescriptionTextBox.Text.Length <= 50))
            {
                ErrorMessage.Visible = false;
                _tournament.Description = DescriptionTextBox.Text;
            }
            else
            {
                ErrorMessage.Text = "Error: max length name tournament most be not 50 <= or >= 10000 symbol.";
            }
            if (!(StartDateDateTimePicker.Value > LastRegistrationDateDateTimePicker.Value))
            {
                ErrorMessage.Visible = false;
                _tournament.StartDate = StartDateDateTimePicker.Text;
                _tournament.LastRegistDate = LastRegistrationDateDateTimePicker.Text;
            }
            else
            {
                ErrorMessage.Text = "Error: The end date of the tournament must not be earlier than the end date of registration.";
            }
            if (!(PlaceTextBox.Text.Length >= 255) || !(PlaceTextBox.Text.Length <= 10))
            {
                ErrorMessage.Visible = false;
                _tournament.Place = PlaceTextBox.Text;
            }
            else
            {
                ErrorMessage.Text = "Error: max length place most be not 3 <= or >= 255 symbol.";

            }
            _tournament.Level = (MyEnum.Level)LevelComboBox.SelectedIndex;
            _tournament.State = (MyEnum.State)StateComboBox.SelectedIndex;
            _tournament.Scenary = (MyEnum.Scenari)ScenaryComboBox.SelectedIndex;
            _tournament.Partiseted = (int)CountOfParticipantsComboBox.SelectedIndex;
            _currentEngine.CurrentUser.CurrentTournament.Add(_tournament);
            ErrorMessage.Visible = true;
            ErrorMessage.BackColor = Color.Green;
            ErrorMessage.Text = "Succes";
        }
    }
}