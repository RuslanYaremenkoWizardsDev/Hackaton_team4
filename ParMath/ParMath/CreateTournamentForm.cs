using ParMath.Class;
using System;

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
        }

        private void Create_Click(object sender, EventArgs e)
        {
            
            if (!(NameOfTournamentTextBox.Text.Length >= 255))
            {
                _tournament.NameTournament = NameOfTournamentTextBox.Text;
            } else
            {
                ErrorMessage.Text = "Error: max length name tournament most be 255 symbol.";
            }
            if (!(DescriptionTextBox.Text.Length >= 10000))
            {
                _tournament.Description = DescriptionTextBox.Text;
            } else
            {
                ErrorMessage.Text = "Error: max length description tournament most be 10000 symbol.";
            }
            if (!(StartDateDateTimePicker.Value > LastRegistrationDateDateTimePicker.Value))
            {
                _tournament.StartDate = StartDateDateTimePicker.Text;
                _tournament.LastRegistDate = LastRegistrationDateDateTimePicker.Text;
            } else
            {
                ErrorMessage.Text = "Error: The end date of the tournament must not be earlier than the end date of registration.";
            }
            if (!(PlaceTextBox.Text.Length >= 255))
            {
                _tournament.Place = PlaceTextBox.Text;
            } else
            {
                ErrorMessage.Text = "Error: max length place tournament most be 255 symbol.";

            }
            _tournament.Level = (MyEnum.Level)LevelComboBox.SelectedIndex;
            _tournament.State = (MyEnum.State)StateComboBox.SelectedIndex;
            _tournament.Scenary = (MyEnum.Scenari)ScenaryComboBox.SelectedIndex;
            _tournament.Partiseted = (int)CountOfParticipantsComboBox.SelectedIndex;
        }


    }
}
