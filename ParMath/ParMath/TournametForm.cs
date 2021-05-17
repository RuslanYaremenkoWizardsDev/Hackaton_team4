using ParMath.Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParMath
{
    public partial class TournametForm : Form
    {
        AuthorizationForm authorizationForm;
        private Engine _currentEngine;
        private CreateTournamentForm CreateTournamentForm = new CreateTournamentForm();

        public TournametForm()
        {
            InitializeComponent();

            if (ChangeTheme.thememode == true)
            {
                this.BackColor = Color.White;
                GoToMyAccountButton.BackColor = Color.White;
                GoToMyAccountButton.ForeColor = Color.Black;
                LogOutbutton.BackColor = Color.White;
                LogOutbutton.ForeColor = Color.Black;
                ClearAllButton.BackColor = Color.White;
                ClearAllButton.ForeColor = Color.Black;
                CupGridButton.BackColor = Color.White;
                CupGridButton.ForeColor = Color.Black;
                TournamentsPanel.BackColor = Color.White;
                TournamentsPanel.ForeColor = Color.Black;
                PlayersPanel.BackColor = Color.White;
                PlayersPanel.ForeColor = Color.Black;
                NameTournamentsRichTextBox.BackColor = Color.White;
                NameTournamentsRichTextBox.ForeColor = Color.Black;
                ModeRichTextBox.BackColor = Color.White;
                ModeRichTextBox.ForeColor = Color.Black;
                PlaceRichTextBox.BackColor = Color.White;
                PlaceRichTextBox.ForeColor = Color.Black;
                StartDateRichTextBox.BackColor = Color.White;
                StartDateRichTextBox.ForeColor = Color.Black;
                LastRegDateRichTextBox.BackColor = Color.White;
                LastRegDateRichTextBox.ForeColor = Color.Black;
                StateRichTextBox.BackColor = Color.White;
                StateRichTextBox.ForeColor = Color.Black;
                LevelRichTextBox.BackColor = Color.White;
                LevelRichTextBox.ForeColor = Color.Black;
                ParticipantsRichTextBox.BackColor = Color.White;
                ParticipantsRichTextBox.ForeColor = Color.Black;
                ScenarioRichTextBox.BackColor = Color.White;
                ScenarioRichTextBox.ForeColor = Color.Black;
                ActionsRichTextBox.BackColor = Color.White;
                ActionsRichTextBox.ForeColor = Color.Black;
                NameStatsRichTextBox.BackColor = Color.White;
                NameStatsRichTextBox.ForeColor = Color.Black;
                GamesRichTextBox.BackColor = Color.White;
                GamesRichTextBox.ForeColor = Color.Black;
                WinsRichTextBox.BackColor = Color.White;
                WinsRichTextBox.ForeColor = Color.Black;
                LosesRichTextBox.BackColor = Color.White;
                LosesRichTextBox.ForeColor = Color.Black;
                CupWinsRichTextBox.BackColor = Color.White;
                CupWinsRichTextBox.ForeColor = Color.Black;
                NumberOfTournamentsRichTextBox.BackColor = Color.White;
                NumberOfTournamentsRichTextBox.ForeColor = Color.Black;
                ActiveRichTextBox.BackColor = Color.White;
                ActiveRichTextBox.ForeColor = Color.Black;
                FinishedRichTextBox.BackColor = Color.White;
                FinishedRichTextBox.ForeColor = Color.Black;
                NotStartedRichTextBox.BackColor = Color.White;
                NotStartedRichTextBox.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                GoToMyAccountButton.BackColor = Color.Black;
                GoToMyAccountButton.ForeColor = Color.White;
                LogOutbutton.BackColor = Color.Black;
                LogOutbutton.ForeColor = Color.White;
                ClearAllButton.BackColor = Color.Black;
                ClearAllButton.ForeColor = Color.White;
                CupGridButton.BackColor = Color.Black;
                CupGridButton.ForeColor = Color.White;
                TournamentsPanel.BackColor = Color.Black;
                TournamentsPanel.ForeColor = Color.White;
                PlayersPanel.BackColor = Color.Black;
                PlayersPanel.ForeColor = Color.White;
                NameTournamentsRichTextBox.BackColor = Color.Black;
                NameTournamentsRichTextBox.ForeColor = Color.White;
                ModeRichTextBox.BackColor = Color.Black;
                ModeRichTextBox.ForeColor = Color.White;
                PlaceRichTextBox.BackColor = Color.Black;
                PlaceRichTextBox.ForeColor = Color.White;
                StartDateRichTextBox.BackColor = Color.Black;
                StartDateRichTextBox.ForeColor = Color.White;
                LastRegDateRichTextBox.BackColor = Color.Black;
                LastRegDateRichTextBox.ForeColor = Color.White;
                StateRichTextBox.BackColor = Color.Black;
                StateRichTextBox.ForeColor = Color.White;
                LevelRichTextBox.BackColor = Color.Black;
                LevelRichTextBox.ForeColor = Color.White;
                ParticipantsRichTextBox.BackColor = Color.Black;
                ParticipantsRichTextBox.ForeColor = Color.White;
                ScenarioRichTextBox.BackColor = Color.Black;
                ScenarioRichTextBox.ForeColor = Color.White;
                ActionsRichTextBox.BackColor = Color.Black;
                ActionsRichTextBox.ForeColor = Color.White;
                NameStatsRichTextBox.BackColor = Color.Black;
                NameStatsRichTextBox.ForeColor = Color.White;
                GamesRichTextBox.BackColor = Color.Black;
                GamesRichTextBox.ForeColor = Color.White;
                WinsRichTextBox.BackColor = Color.Black;
                WinsRichTextBox.ForeColor = Color.White;
                LosesRichTextBox.BackColor = Color.Black;
                LosesRichTextBox.ForeColor = Color.White;
                CupWinsRichTextBox.BackColor = Color.Black;
                CupWinsRichTextBox.ForeColor = Color.White;
                NumberOfTournamentsRichTextBox.BackColor = Color.Black;
                NumberOfTournamentsRichTextBox.ForeColor = Color.White;
                ActiveRichTextBox.BackColor = Color.Black;
                ActiveRichTextBox.ForeColor = Color.White;
                FinishedRichTextBox.BackColor = Color.Black;
                FinishedRichTextBox.ForeColor = Color.White;
                NotStartedRichTextBox.BackColor = Color.Black;
                NotStartedRichTextBox.ForeColor = Color.White;
            }

            _currentEngine = Engine.GetEngine();
            authorizationForm = new AuthorizationForm();
        }
        private void TournametForm_Load(object sender, EventArgs e)
        {
            CreateTournamentForm = new CreateTournamentForm();
            authorizationForm = new AuthorizationForm();
            _currentEngine = Engine.GetEngine();
            
        }
        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            _currentEngine.SaveAllUsers();
            authorizationForm.Show();
            this.Hide();
        }

        private void GoToMyAccountButton_Click(object sender, EventArgs e)
        {
            MyAccountForm myAccount = new MyAccountForm();
            myAccount.Show();
            this.Hide();
        }

        private void CupGridButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm.Show();
            this.Hide();
        }
    }
}
