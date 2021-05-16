
namespace ParMath
{
    partial class TournametForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TournamentsTabPage = new System.Windows.Forms.TabPage();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.ToRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchByStateLabel = new System.Windows.Forms.Label();
            this.SearchByRegDateLabel = new System.Windows.Forms.Label();
            this.SearchByStartDateLabel = new System.Windows.Forms.Label();
            this.TournamentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameTournamentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ModeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlaceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StartDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LastRegDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LevelRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ParticipantsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ScenarioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ActionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CreateTournamentTabPage = new System.Windows.Forms.TabPage();
            this.CupGridButton = new System.Windows.Forms.Button();
            this.FieldsButton = new System.Windows.Forms.Button();
            this.StatsTabPage = new System.Windows.Forms.TabPage();
            this.TournamentsStatsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FinishedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NotStartedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NumberOfTournamentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlayersStatsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameStatsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GamesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.WinsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LosesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CupWinsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TournamentsPanel = new System.Windows.Forms.Panel();
            this.TournamentsLabel = new System.Windows.Forms.Label();
            this.PlayersPanel = new System.Windows.Forms.Panel();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TournamentsTabPage.SuspendLayout();
            this.TournamentsTableLayoutPanel.SuspendLayout();
            this.CreateTournamentTabPage.SuspendLayout();
            this.StatsTabPage.SuspendLayout();
            this.TournamentsStatsTableLayoutPanel.SuspendLayout();
            this.PlayersStatsTableLayoutPanel.SuspendLayout();
            this.TournamentsPanel.SuspendLayout();
            this.PlayersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(781, 5);
            this.LogOutbutton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(56, 42);
            this.LogOutbutton.TabIndex = 0;
            this.LogOutbutton.Text = "Log out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TournamentsTabPage);
            this.TabControl.Controls.Add(this.CreateTournamentTabPage);
            this.TabControl.Controls.Add(this.StatsTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(4, 54);
            this.TabControl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(40, 40);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(840, 503);
            this.TabControl.TabIndex = 1;
            // 
            // TournamentsTabPage
            // 
            this.TournamentsTabPage.Controls.Add(this.StateComboBox);
            this.TournamentsTabPage.Controls.Add(this.ToRegDateTimePicker);
            this.TournamentsTabPage.Controls.Add(this.FromRegDateTimePicker);
            this.TournamentsTabPage.Controls.Add(this.ToStartDateTimePicker);
            this.TournamentsTabPage.Controls.Add(this.FromStartDateTimePicker);
            this.TournamentsTabPage.Controls.Add(this.SearchByStateLabel);
            this.TournamentsTabPage.Controls.Add(this.SearchByRegDateLabel);
            this.TournamentsTabPage.Controls.Add(this.SearchByStartDateLabel);
            this.TournamentsTabPage.Controls.Add(this.TournamentsTableLayoutPanel);
            this.TournamentsTabPage.Controls.Add(this.ClearAllButton);
            this.TournamentsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentsTabPage.Location = new System.Drawing.Point(4, 107);
            this.TournamentsTabPage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TournamentsTabPage.Name = "TournamentsTabPage";
            this.TournamentsTabPage.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TournamentsTabPage.Size = new System.Drawing.Size(832, 392);
            this.TournamentsTabPage.TabIndex = 0;
            this.TournamentsTabPage.Text = "Tournaments";
            this.TournamentsTabPage.UseVisualStyleBackColor = true;
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(579, 43);
            this.StateComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(170, 21);
            this.StateComboBox.TabIndex = 12;
            // 
            // ToRegDateTimePicker
            // 
            this.ToRegDateTimePicker.Location = new System.Drawing.Point(294, 62);
            this.ToRegDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ToRegDateTimePicker.Name = "ToRegDateTimePicker";
            this.ToRegDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.ToRegDateTimePicker.TabIndex = 11;
            // 
            // FromRegDateTimePicker
            // 
            this.FromRegDateTimePicker.Location = new System.Drawing.Point(294, 43);
            this.FromRegDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FromRegDateTimePicker.Name = "FromRegDateTimePicker";
            this.FromRegDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.FromRegDateTimePicker.TabIndex = 10;
            // 
            // ToStartDateTimePicker
            // 
            this.ToStartDateTimePicker.Location = new System.Drawing.Point(7, 62);
            this.ToStartDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ToStartDateTimePicker.Name = "ToStartDateTimePicker";
            this.ToStartDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.ToStartDateTimePicker.TabIndex = 9;
            // 
            // FromStartDateTimePicker
            // 
            this.FromStartDateTimePicker.Location = new System.Drawing.Point(7, 43);
            this.FromStartDateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FromStartDateTimePicker.Name = "FromStartDateTimePicker";
            this.FromStartDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.FromStartDateTimePicker.TabIndex = 8;
            // 
            // SearchByStateLabel
            // 
            this.SearchByStateLabel.AutoSize = true;
            this.SearchByStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStateLabel.Location = new System.Drawing.Point(576, 16);
            this.SearchByStateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SearchByStateLabel.Name = "SearchByStateLabel";
            this.SearchByStateLabel.Size = new System.Drawing.Size(107, 17);
            this.SearchByStateLabel.TabIndex = 7;
            this.SearchByStateLabel.Text = "Search by state";
            // 
            // SearchByRegDateLabel
            // 
            this.SearchByRegDateLabel.AutoSize = true;
            this.SearchByRegDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByRegDateLabel.Location = new System.Drawing.Point(291, 16);
            this.SearchByRegDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SearchByRegDateLabel.Name = "SearchByRegDateLabel";
            this.SearchByRegDateLabel.Size = new System.Drawing.Size(191, 17);
            this.SearchByRegDateLabel.TabIndex = 6;
            this.SearchByRegDateLabel.Text = "Search by reg date (from, to)";
            // 
            // SearchByStartDateLabel
            // 
            this.SearchByStartDateLabel.AutoSize = true;
            this.SearchByStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStartDateLabel.Location = new System.Drawing.Point(4, 16);
            this.SearchByStartDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SearchByStartDateLabel.Name = "SearchByStartDateLabel";
            this.SearchByStartDateLabel.Size = new System.Drawing.Size(202, 17);
            this.SearchByStartDateLabel.TabIndex = 5;
            this.SearchByStartDateLabel.Text = "Search by start date (from , to)";
            // 
            // TournamentsTableLayoutPanel
            // 
            this.TournamentsTableLayoutPanel.ColumnCount = 10;
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TournamentsTableLayoutPanel.Controls.Add(this.NameTournamentsRichTextBox, 0, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ModeRichTextBox, 1, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.PlaceRichTextBox, 2, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.StartDateRichTextBox, 3, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.LastRegDateRichTextBox, 4, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.StateRichTextBox, 5, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.LevelRichTextBox, 6, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ParticipantsRichTextBox, 7, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ScenarioRichTextBox, 8, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ActionsRichTextBox, 9, 0);
            this.TournamentsTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentsTableLayoutPanel.Location = new System.Drawing.Point(6, 110);
            this.TournamentsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TournamentsTableLayoutPanel.Name = "TournamentsTableLayoutPanel";
            this.TournamentsTableLayoutPanel.RowCount = 3;
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.Size = new System.Drawing.Size(831, 170);
            this.TournamentsTableLayoutPanel.TabIndex = 4;
            // 
            // NameTournamentsRichTextBox
            // 
            this.NameTournamentsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTournamentsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NameTournamentsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NameTournamentsRichTextBox.Name = "NameTournamentsRichTextBox";
            this.NameTournamentsRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.NameTournamentsRichTextBox.TabIndex = 0;
            this.NameTournamentsRichTextBox.Text = "Name";
            // 
            // ModeRichTextBox
            // 
            this.ModeRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeRichTextBox.Location = new System.Drawing.Point(84, 1);
            this.ModeRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ModeRichTextBox.Name = "ModeRichTextBox";
            this.ModeRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.ModeRichTextBox.TabIndex = 1;
            this.ModeRichTextBox.Text = "Mode";
            // 
            // PlaceRichTextBox
            // 
            this.PlaceRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlaceRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceRichTextBox.Location = new System.Drawing.Point(167, 1);
            this.PlaceRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PlaceRichTextBox.Name = "PlaceRichTextBox";
            this.PlaceRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.PlaceRichTextBox.TabIndex = 2;
            this.PlaceRichTextBox.Text = "Place";
            // 
            // StartDateRichTextBox
            // 
            this.StartDateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateRichTextBox.Location = new System.Drawing.Point(250, 1);
            this.StartDateRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StartDateRichTextBox.Name = "StartDateRichTextBox";
            this.StartDateRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.StartDateRichTextBox.TabIndex = 3;
            this.StartDateRichTextBox.Text = "Start date";
            // 
            // LastRegDateRichTextBox
            // 
            this.LastRegDateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastRegDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastRegDateRichTextBox.Location = new System.Drawing.Point(333, 1);
            this.LastRegDateRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LastRegDateRichTextBox.Name = "LastRegDateRichTextBox";
            this.LastRegDateRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.LastRegDateRichTextBox.TabIndex = 4;
            this.LastRegDateRichTextBox.Text = "Last reg date";
            // 
            // StateRichTextBox
            // 
            this.StateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateRichTextBox.Location = new System.Drawing.Point(416, 1);
            this.StateRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StateRichTextBox.Name = "StateRichTextBox";
            this.StateRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.StateRichTextBox.TabIndex = 5;
            this.StateRichTextBox.Text = "State";
            // 
            // LevelRichTextBox
            // 
            this.LevelRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LevelRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelRichTextBox.Location = new System.Drawing.Point(499, 1);
            this.LevelRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LevelRichTextBox.Name = "LevelRichTextBox";
            this.LevelRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.LevelRichTextBox.TabIndex = 6;
            this.LevelRichTextBox.Text = "Level";
            // 
            // ParticipantsRichTextBox
            // 
            this.ParticipantsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParticipantsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParticipantsRichTextBox.Location = new System.Drawing.Point(582, 1);
            this.ParticipantsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ParticipantsRichTextBox.Name = "ParticipantsRichTextBox";
            this.ParticipantsRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.ParticipantsRichTextBox.TabIndex = 7;
            this.ParticipantsRichTextBox.Text = "Participants";
            // 
            // ScenarioRichTextBox
            // 
            this.ScenarioRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScenarioRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScenarioRichTextBox.Location = new System.Drawing.Point(665, 1);
            this.ScenarioRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ScenarioRichTextBox.Name = "ScenarioRichTextBox";
            this.ScenarioRichTextBox.Size = new System.Drawing.Size(81, 54);
            this.ScenarioRichTextBox.TabIndex = 8;
            this.ScenarioRichTextBox.Text = "Scenario";
            // 
            // ActionsRichTextBox
            // 
            this.ActionsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsRichTextBox.Location = new System.Drawing.Point(750, 1);
            this.ActionsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ActionsRichTextBox.Name = "ActionsRichTextBox";
            this.ActionsRichTextBox.Size = new System.Drawing.Size(77, 54);
            this.ActionsRichTextBox.TabIndex = 9;
            this.ActionsRichTextBox.Text = "Actions";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(769, 19);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(56, 42);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Clear all";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentTabPage
            // 
            this.CreateTournamentTabPage.Controls.Add(this.CupGridButton);
            this.CreateTournamentTabPage.Controls.Add(this.FieldsButton);
            this.CreateTournamentTabPage.Location = new System.Drawing.Point(4, 107);
            this.CreateTournamentTabPage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CreateTournamentTabPage.Name = "CreateTournamentTabPage";
            this.CreateTournamentTabPage.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CreateTournamentTabPage.Size = new System.Drawing.Size(832, 392);
            this.CreateTournamentTabPage.TabIndex = 1;
            this.CreateTournamentTabPage.Text = "Create tournament";
            this.CreateTournamentTabPage.UseVisualStyleBackColor = true;
            // 
            // CupGridButton
            // 
            this.CupGridButton.Location = new System.Drawing.Point(446, 14);
            this.CupGridButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CupGridButton.Name = "CupGridButton";
            this.CupGridButton.Size = new System.Drawing.Size(375, 335);
            this.CupGridButton.TabIndex = 1;
            this.CupGridButton.Text = "Cup grid";
            this.CupGridButton.UseVisualStyleBackColor = true;
            // 
            // FieldsButton
            // 
            this.FieldsButton.Location = new System.Drawing.Point(10, 14);
            this.FieldsButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FieldsButton.Name = "FieldsButton";
            this.FieldsButton.Size = new System.Drawing.Size(375, 335);
            this.FieldsButton.TabIndex = 0;
            this.FieldsButton.Text = "Fields";
            this.FieldsButton.UseVisualStyleBackColor = true;
            // 
            // StatsTabPage
            // 
            this.StatsTabPage.Controls.Add(this.TournamentsStatsTableLayoutPanel);
            this.StatsTabPage.Controls.Add(this.PlayersStatsTableLayoutPanel);
            this.StatsTabPage.Controls.Add(this.TournamentsPanel);
            this.StatsTabPage.Controls.Add(this.PlayersPanel);
            this.StatsTabPage.Location = new System.Drawing.Point(4, 107);
            this.StatsTabPage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StatsTabPage.Name = "StatsTabPage";
            this.StatsTabPage.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StatsTabPage.Size = new System.Drawing.Size(832, 392);
            this.StatsTabPage.TabIndex = 2;
            this.StatsTabPage.Text = "Stats";
            this.StatsTabPage.UseVisualStyleBackColor = true;
            // 
            // TournamentsStatsTableLayoutPanel
            // 
            this.TournamentsStatsTableLayoutPanel.ColumnCount = 4;
            this.TournamentsStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TournamentsStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TournamentsStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TournamentsStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TournamentsStatsTableLayoutPanel.Controls.Add(this.ActiveRichTextBox, 1, 0);
            this.TournamentsStatsTableLayoutPanel.Controls.Add(this.FinishedRichTextBox, 2, 0);
            this.TournamentsStatsTableLayoutPanel.Controls.Add(this.NotStartedRichTextBox, 3, 0);
            this.TournamentsStatsTableLayoutPanel.Controls.Add(this.NumberOfTournamentsRichTextBox, 0, 0);
            this.TournamentsStatsTableLayoutPanel.Location = new System.Drawing.Point(6, 279);
            this.TournamentsStatsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TournamentsStatsTableLayoutPanel.Name = "TournamentsStatsTableLayoutPanel";
            this.TournamentsStatsTableLayoutPanel.RowCount = 2;
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.Size = new System.Drawing.Size(806, 88);
            this.TournamentsStatsTableLayoutPanel.TabIndex = 3;
            // 
            // ActiveRichTextBox
            // 
            this.ActiveRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveRichTextBox.Location = new System.Drawing.Point(202, 1);
            this.ActiveRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ActiveRichTextBox.Name = "ActiveRichTextBox";
            this.ActiveRichTextBox.Size = new System.Drawing.Size(199, 42);
            this.ActiveRichTextBox.TabIndex = 1;
            this.ActiveRichTextBox.Text = "Active";
            // 
            // FinishedRichTextBox
            // 
            this.FinishedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishedRichTextBox.Location = new System.Drawing.Point(403, 1);
            this.FinishedRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FinishedRichTextBox.Name = "FinishedRichTextBox";
            this.FinishedRichTextBox.Size = new System.Drawing.Size(199, 42);
            this.FinishedRichTextBox.TabIndex = 2;
            this.FinishedRichTextBox.Text = "Finished";
            // 
            // NotStartedRichTextBox
            // 
            this.NotStartedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotStartedRichTextBox.Location = new System.Drawing.Point(604, 1);
            this.NotStartedRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NotStartedRichTextBox.Name = "NotStartedRichTextBox";
            this.NotStartedRichTextBox.Size = new System.Drawing.Size(201, 42);
            this.NotStartedRichTextBox.TabIndex = 3;
            this.NotStartedRichTextBox.Text = "Not started";
            // 
            // NumberOfTournamentsRichTextBox
            // 
            this.NumberOfTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTournamentsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NumberOfTournamentsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NumberOfTournamentsRichTextBox.Name = "NumberOfTournamentsRichTextBox";
            this.NumberOfTournamentsRichTextBox.Size = new System.Drawing.Size(199, 42);
            this.NumberOfTournamentsRichTextBox.TabIndex = 0;
            this.NumberOfTournamentsRichTextBox.Text = "Number of tournaments";
            // 
            // PlayersStatsTableLayoutPanel
            // 
            this.PlayersStatsTableLayoutPanel.ColumnCount = 5;
            this.PlayersStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayersStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayersStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayersStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayersStatsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayersStatsTableLayoutPanel.Controls.Add(this.NameStatsRichTextBox, 0, 0);
            this.PlayersStatsTableLayoutPanel.Controls.Add(this.GamesRichTextBox, 1, 0);
            this.PlayersStatsTableLayoutPanel.Controls.Add(this.WinsRichTextBox, 2, 0);
            this.PlayersStatsTableLayoutPanel.Controls.Add(this.LosesRichTextBox, 3, 0);
            this.PlayersStatsTableLayoutPanel.Controls.Add(this.CupWinsRichTextBox, 4, 0);
            this.PlayersStatsTableLayoutPanel.Location = new System.Drawing.Point(6, 70);
            this.PlayersStatsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PlayersStatsTableLayoutPanel.Name = "PlayersStatsTableLayoutPanel";
            this.PlayersStatsTableLayoutPanel.RowCount = 2;
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.Size = new System.Drawing.Size(806, 81);
            this.PlayersStatsTableLayoutPanel.TabIndex = 2;
            // 
            // NameStatsRichTextBox
            // 
            this.NameStatsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStatsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NameStatsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NameStatsRichTextBox.Name = "NameStatsRichTextBox";
            this.NameStatsRichTextBox.Size = new System.Drawing.Size(159, 38);
            this.NameStatsRichTextBox.TabIndex = 0;
            this.NameStatsRichTextBox.Text = "Name";
            // 
            // GamesRichTextBox
            // 
            this.GamesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesRichTextBox.Location = new System.Drawing.Point(162, 1);
            this.GamesRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GamesRichTextBox.Name = "GamesRichTextBox";
            this.GamesRichTextBox.Size = new System.Drawing.Size(159, 38);
            this.GamesRichTextBox.TabIndex = 1;
            this.GamesRichTextBox.Text = "Games";
            // 
            // WinsRichTextBox
            // 
            this.WinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinsRichTextBox.Location = new System.Drawing.Point(323, 1);
            this.WinsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.WinsRichTextBox.Name = "WinsRichTextBox";
            this.WinsRichTextBox.Size = new System.Drawing.Size(159, 38);
            this.WinsRichTextBox.TabIndex = 2;
            this.WinsRichTextBox.Text = "Wins";
            // 
            // LosesRichTextBox
            // 
            this.LosesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LosesRichTextBox.Location = new System.Drawing.Point(484, 1);
            this.LosesRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LosesRichTextBox.Name = "LosesRichTextBox";
            this.LosesRichTextBox.Size = new System.Drawing.Size(159, 38);
            this.LosesRichTextBox.TabIndex = 3;
            this.LosesRichTextBox.Text = "Loses";
            // 
            // CupWinsRichTextBox
            // 
            this.CupWinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CupWinsRichTextBox.Location = new System.Drawing.Point(645, 1);
            this.CupWinsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CupWinsRichTextBox.Name = "CupWinsRichTextBox";
            this.CupWinsRichTextBox.Size = new System.Drawing.Size(160, 38);
            this.CupWinsRichTextBox.TabIndex = 4;
            this.CupWinsRichTextBox.Text = "Cup wins";
            // 
            // TournamentsPanel
            // 
            this.TournamentsPanel.Controls.Add(this.TournamentsLabel);
            this.TournamentsPanel.Location = new System.Drawing.Point(6, 190);
            this.TournamentsPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TournamentsPanel.Name = "TournamentsPanel";
            this.TournamentsPanel.Size = new System.Drawing.Size(806, 42);
            this.TournamentsPanel.TabIndex = 1;
            // 
            // TournamentsLabel
            // 
            this.TournamentsLabel.AutoSize = true;
            this.TournamentsLabel.Location = new System.Drawing.Point(344, 10);
            this.TournamentsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TournamentsLabel.Name = "TournamentsLabel";
            this.TournamentsLabel.Size = new System.Drawing.Size(133, 24);
            this.TournamentsLabel.TabIndex = 0;
            this.TournamentsLabel.Text = "Tournaments";
            // 
            // PlayersPanel
            // 
            this.PlayersPanel.Controls.Add(this.PlayersLabel);
            this.PlayersPanel.Location = new System.Drawing.Point(6, 13);
            this.PlayersPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PlayersPanel.Name = "PlayersPanel";
            this.PlayersPanel.Size = new System.Drawing.Size(806, 42);
            this.PlayersPanel.TabIndex = 0;
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(366, 9);
            this.PlayersLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(78, 24);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players";
            // 
            // TournametForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 314);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LogOutbutton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "TournametForm";
            this.Text = "TournamentForm";
            this.Load += new System.EventHandler(this.TournametForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TournamentsTabPage.ResumeLayout(false);
            this.TournamentsTabPage.PerformLayout();
            this.TournamentsTableLayoutPanel.ResumeLayout(false);
            this.CreateTournamentTabPage.ResumeLayout(false);
            this.StatsTabPage.ResumeLayout(false);
            this.TournamentsStatsTableLayoutPanel.ResumeLayout(false);
            this.PlayersStatsTableLayoutPanel.ResumeLayout(false);
            this.TournamentsPanel.ResumeLayout(false);
            this.TournamentsPanel.PerformLayout();
            this.PlayersPanel.ResumeLayout(false);
            this.PlayersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TournamentsTabPage;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TabPage CreateTournamentTabPage;
        private System.Windows.Forms.TabPage StatsTabPage;
        private System.Windows.Forms.TableLayoutPanel TournamentsTableLayoutPanel;
        private System.Windows.Forms.RichTextBox NameTournamentsRichTextBox;
        private System.Windows.Forms.RichTextBox ModeRichTextBox;
        private System.Windows.Forms.RichTextBox PlaceRichTextBox;
        private System.Windows.Forms.RichTextBox StartDateRichTextBox;
        private System.Windows.Forms.RichTextBox LastRegDateRichTextBox;
        private System.Windows.Forms.RichTextBox StateRichTextBox;
        private System.Windows.Forms.RichTextBox LevelRichTextBox;
        private System.Windows.Forms.RichTextBox ParticipantsRichTextBox;
        private System.Windows.Forms.RichTextBox ScenarioRichTextBox;
        private System.Windows.Forms.RichTextBox ActionsRichTextBox;
        private System.Windows.Forms.Button CupGridButton;
        private System.Windows.Forms.Button FieldsButton;
        private System.Windows.Forms.TableLayoutPanel TournamentsStatsTableLayoutPanel;
        private System.Windows.Forms.RichTextBox ActiveRichTextBox;
        private System.Windows.Forms.RichTextBox FinishedRichTextBox;
        private System.Windows.Forms.RichTextBox NotStartedRichTextBox;
        private System.Windows.Forms.RichTextBox NumberOfTournamentsRichTextBox;
        private System.Windows.Forms.TableLayoutPanel PlayersStatsTableLayoutPanel;
        private System.Windows.Forms.RichTextBox NameStatsRichTextBox;
        private System.Windows.Forms.RichTextBox GamesRichTextBox;
        private System.Windows.Forms.RichTextBox WinsRichTextBox;
        private System.Windows.Forms.RichTextBox LosesRichTextBox;
        private System.Windows.Forms.RichTextBox CupWinsRichTextBox;
        private System.Windows.Forms.Panel TournamentsPanel;
        private System.Windows.Forms.Label TournamentsLabel;
        private System.Windows.Forms.Panel PlayersPanel;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.DateTimePicker ToRegDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromRegDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromStartDateTimePicker;
        private System.Windows.Forms.Label SearchByStateLabel;
        private System.Windows.Forms.Label SearchByRegDateLabel;
        private System.Windows.Forms.Label SearchByStartDateLabel;
        private System.Windows.Forms.ComboBox StateComboBox;
    }
}