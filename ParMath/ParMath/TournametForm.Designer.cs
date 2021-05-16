﻿
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
            this.SearchByStartDateLabel = new System.Windows.Forms.Label();
            this.SearchByRegDateLabel = new System.Windows.Forms.Label();
            this.SearchByStateLabel = new System.Windows.Forms.Label();
            this.FromStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
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
            this.LogOutbutton.Location = new System.Drawing.Point(2083, 12);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(150, 100);
            this.LogOutbutton.TabIndex = 0;
            this.LogOutbutton.Text = "Log out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TournamentsTabPage);
            this.TabControl.Controls.Add(this.CreateTournamentTabPage);
            this.TabControl.Controls.Add(this.StatsTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(12, 129);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(40, 40);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(2241, 1200);
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
            this.TournamentsTabPage.Location = new System.Drawing.Point(10, 141);
            this.TournamentsTabPage.Name = "TournamentsTabPage";
            this.TournamentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TournamentsTabPage.Size = new System.Drawing.Size(2221, 1049);
            this.TournamentsTabPage.TabIndex = 0;
            this.TournamentsTabPage.Text = "Tournaments";
            this.TournamentsTabPage.UseVisualStyleBackColor = true;
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
            this.TournamentsTableLayoutPanel.Location = new System.Drawing.Point(15, 262);
            this.TournamentsTableLayoutPanel.Name = "TournamentsTableLayoutPanel";
            this.TournamentsTableLayoutPanel.RowCount = 3;
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.Size = new System.Drawing.Size(2216, 406);
            this.TournamentsTableLayoutPanel.TabIndex = 4;
            // 
            // NameTournamentsRichTextBox
            // 
            this.NameTournamentsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTournamentsRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.NameTournamentsRichTextBox.Name = "NameTournamentsRichTextBox";
            this.NameTournamentsRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.NameTournamentsRichTextBox.TabIndex = 0;
            this.NameTournamentsRichTextBox.Text = "Name";
            // 
            // ModeRichTextBox
            // 
            this.ModeRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeRichTextBox.Location = new System.Drawing.Point(224, 3);
            this.ModeRichTextBox.Name = "ModeRichTextBox";
            this.ModeRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.ModeRichTextBox.TabIndex = 1;
            this.ModeRichTextBox.Text = "Mode";
            // 
            // PlaceRichTextBox
            // 
            this.PlaceRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlaceRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceRichTextBox.Location = new System.Drawing.Point(445, 3);
            this.PlaceRichTextBox.Name = "PlaceRichTextBox";
            this.PlaceRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.PlaceRichTextBox.TabIndex = 2;
            this.PlaceRichTextBox.Text = "Place";
            // 
            // StartDateRichTextBox
            // 
            this.StartDateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateRichTextBox.Location = new System.Drawing.Point(666, 3);
            this.StartDateRichTextBox.Name = "StartDateRichTextBox";
            this.StartDateRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.StartDateRichTextBox.TabIndex = 3;
            this.StartDateRichTextBox.Text = "Start date";
            // 
            // LastRegDateRichTextBox
            // 
            this.LastRegDateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastRegDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastRegDateRichTextBox.Location = new System.Drawing.Point(887, 3);
            this.LastRegDateRichTextBox.Name = "LastRegDateRichTextBox";
            this.LastRegDateRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.LastRegDateRichTextBox.TabIndex = 4;
            this.LastRegDateRichTextBox.Text = "Last reg date";
            // 
            // StateRichTextBox
            // 
            this.StateRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateRichTextBox.Location = new System.Drawing.Point(1108, 3);
            this.StateRichTextBox.Name = "StateRichTextBox";
            this.StateRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.StateRichTextBox.TabIndex = 5;
            this.StateRichTextBox.Text = "State";
            // 
            // LevelRichTextBox
            // 
            this.LevelRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LevelRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelRichTextBox.Location = new System.Drawing.Point(1329, 3);
            this.LevelRichTextBox.Name = "LevelRichTextBox";
            this.LevelRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.LevelRichTextBox.TabIndex = 6;
            this.LevelRichTextBox.Text = "Level";
            // 
            // ParticipantsRichTextBox
            // 
            this.ParticipantsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParticipantsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParticipantsRichTextBox.Location = new System.Drawing.Point(1550, 3);
            this.ParticipantsRichTextBox.Name = "ParticipantsRichTextBox";
            this.ParticipantsRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.ParticipantsRichTextBox.TabIndex = 7;
            this.ParticipantsRichTextBox.Text = "Participants";
            // 
            // ScenarioRichTextBox
            // 
            this.ScenarioRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScenarioRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScenarioRichTextBox.Location = new System.Drawing.Point(1771, 3);
            this.ScenarioRichTextBox.Name = "ScenarioRichTextBox";
            this.ScenarioRichTextBox.Size = new System.Drawing.Size(215, 129);
            this.ScenarioRichTextBox.TabIndex = 8;
            this.ScenarioRichTextBox.Text = "Scenario";
            // 
            // ActionsRichTextBox
            // 
            this.ActionsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsRichTextBox.Location = new System.Drawing.Point(2003, 3);
            this.ActionsRichTextBox.Name = "ActionsRichTextBox";
            this.ActionsRichTextBox.Size = new System.Drawing.Size(198, 129);
            this.ActionsRichTextBox.TabIndex = 9;
            this.ActionsRichTextBox.Text = "Actions";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(2050, 45);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(150, 100);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Clear all";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentTabPage
            // 
            this.CreateTournamentTabPage.Controls.Add(this.CupGridButton);
            this.CreateTournamentTabPage.Controls.Add(this.FieldsButton);
            this.CreateTournamentTabPage.Location = new System.Drawing.Point(10, 141);
            this.CreateTournamentTabPage.Name = "CreateTournamentTabPage";
            this.CreateTournamentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTournamentTabPage.Size = new System.Drawing.Size(2221, 1049);
            this.CreateTournamentTabPage.TabIndex = 1;
            this.CreateTournamentTabPage.Text = "Create tournament";
            this.CreateTournamentTabPage.UseVisualStyleBackColor = true;
            // 
            // CupGridButton
            // 
            this.CupGridButton.Location = new System.Drawing.Point(1188, 33);
            this.CupGridButton.Name = "CupGridButton";
            this.CupGridButton.Size = new System.Drawing.Size(1000, 800);
            this.CupGridButton.TabIndex = 1;
            this.CupGridButton.Text = "Cup grid";
            this.CupGridButton.UseVisualStyleBackColor = true;
            // 
            // FieldsButton
            // 
            this.FieldsButton.Location = new System.Drawing.Point(27, 33);
            this.FieldsButton.Name = "FieldsButton";
            this.FieldsButton.Size = new System.Drawing.Size(1000, 800);
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
            this.StatsTabPage.Location = new System.Drawing.Point(10, 141);
            this.StatsTabPage.Name = "StatsTabPage";
            this.StatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatsTabPage.Size = new System.Drawing.Size(2221, 1049);
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
            this.TournamentsStatsTableLayoutPanel.Location = new System.Drawing.Point(16, 665);
            this.TournamentsStatsTableLayoutPanel.Name = "TournamentsStatsTableLayoutPanel";
            this.TournamentsStatsTableLayoutPanel.RowCount = 2;
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.Size = new System.Drawing.Size(2150, 211);
            this.TournamentsStatsTableLayoutPanel.TabIndex = 3;
            // 
            // ActiveRichTextBox
            // 
            this.ActiveRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveRichTextBox.Location = new System.Drawing.Point(540, 3);
            this.ActiveRichTextBox.Name = "ActiveRichTextBox";
            this.ActiveRichTextBox.Size = new System.Drawing.Size(531, 99);
            this.ActiveRichTextBox.TabIndex = 1;
            this.ActiveRichTextBox.Text = "Active";
            // 
            // FinishedRichTextBox
            // 
            this.FinishedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishedRichTextBox.Location = new System.Drawing.Point(1077, 3);
            this.FinishedRichTextBox.Name = "FinishedRichTextBox";
            this.FinishedRichTextBox.Size = new System.Drawing.Size(525, 99);
            this.FinishedRichTextBox.TabIndex = 2;
            this.FinishedRichTextBox.Text = "Finished";
            // 
            // NotStartedRichTextBox
            // 
            this.NotStartedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotStartedRichTextBox.Location = new System.Drawing.Point(1614, 3);
            this.NotStartedRichTextBox.Name = "NotStartedRichTextBox";
            this.NotStartedRichTextBox.Size = new System.Drawing.Size(533, 99);
            this.NotStartedRichTextBox.TabIndex = 3;
            this.NotStartedRichTextBox.Text = "Not started";
            // 
            // NumberOfTournamentsRichTextBox
            // 
            this.NumberOfTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTournamentsRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.NumberOfTournamentsRichTextBox.Name = "NumberOfTournamentsRichTextBox";
            this.NumberOfTournamentsRichTextBox.Size = new System.Drawing.Size(531, 99);
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
            this.PlayersStatsTableLayoutPanel.Location = new System.Drawing.Point(16, 166);
            this.PlayersStatsTableLayoutPanel.Name = "PlayersStatsTableLayoutPanel";
            this.PlayersStatsTableLayoutPanel.RowCount = 2;
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.Size = new System.Drawing.Size(2150, 192);
            this.PlayersStatsTableLayoutPanel.TabIndex = 2;
            // 
            // NameStatsRichTextBox
            // 
            this.NameStatsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStatsRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.NameStatsRichTextBox.Name = "NameStatsRichTextBox";
            this.NameStatsRichTextBox.Size = new System.Drawing.Size(418, 90);
            this.NameStatsRichTextBox.TabIndex = 0;
            this.NameStatsRichTextBox.Text = "Name";
            // 
            // GamesRichTextBox
            // 
            this.GamesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesRichTextBox.Location = new System.Drawing.Point(433, 3);
            this.GamesRichTextBox.Name = "GamesRichTextBox";
            this.GamesRichTextBox.Size = new System.Drawing.Size(419, 90);
            this.GamesRichTextBox.TabIndex = 1;
            this.GamesRichTextBox.Text = "Games";
            // 
            // WinsRichTextBox
            // 
            this.WinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinsRichTextBox.Location = new System.Drawing.Point(863, 3);
            this.WinsRichTextBox.Name = "WinsRichTextBox";
            this.WinsRichTextBox.Size = new System.Drawing.Size(424, 90);
            this.WinsRichTextBox.TabIndex = 2;
            this.WinsRichTextBox.Text = "Wins";
            // 
            // LosesRichTextBox
            // 
            this.LosesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LosesRichTextBox.Location = new System.Drawing.Point(1293, 3);
            this.LosesRichTextBox.Name = "LosesRichTextBox";
            this.LosesRichTextBox.Size = new System.Drawing.Size(422, 90);
            this.LosesRichTextBox.TabIndex = 3;
            this.LosesRichTextBox.Text = "Loses";
            // 
            // CupWinsRichTextBox
            // 
            this.CupWinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CupWinsRichTextBox.Location = new System.Drawing.Point(1723, 3);
            this.CupWinsRichTextBox.Name = "CupWinsRichTextBox";
            this.CupWinsRichTextBox.Size = new System.Drawing.Size(424, 90);
            this.CupWinsRichTextBox.TabIndex = 4;
            this.CupWinsRichTextBox.Text = "Cup wins";
            // 
            // TournamentsPanel
            // 
            this.TournamentsPanel.Controls.Add(this.TournamentsLabel);
            this.TournamentsPanel.Location = new System.Drawing.Point(16, 453);
            this.TournamentsPanel.Name = "TournamentsPanel";
            this.TournamentsPanel.Size = new System.Drawing.Size(2150, 100);
            this.TournamentsPanel.TabIndex = 1;
            // 
            // TournamentsLabel
            // 
            this.TournamentsLabel.AutoSize = true;
            this.TournamentsLabel.Location = new System.Drawing.Point(917, 23);
            this.TournamentsLabel.Name = "TournamentsLabel";
            this.TournamentsLabel.Size = new System.Drawing.Size(319, 55);
            this.TournamentsLabel.TabIndex = 0;
            this.TournamentsLabel.Text = "Tournaments";
            // 
            // PlayersPanel
            // 
            this.PlayersPanel.Controls.Add(this.PlayersLabel);
            this.PlayersPanel.Location = new System.Drawing.Point(16, 31);
            this.PlayersPanel.Name = "PlayersPanel";
            this.PlayersPanel.Size = new System.Drawing.Size(2150, 100);
            this.PlayersPanel.TabIndex = 0;
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(975, 22);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(191, 55);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players";
            // 
            // SearchByStartDateLabel
            // 
            this.SearchByStartDateLabel.AutoSize = true;
            this.SearchByStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStartDateLabel.Location = new System.Drawing.Point(11, 39);
            this.SearchByStartDateLabel.Name = "SearchByStartDateLabel";
            this.SearchByStartDateLabel.Size = new System.Drawing.Size(472, 39);
            this.SearchByStartDateLabel.TabIndex = 5;
            this.SearchByStartDateLabel.Text = "Search by start date (from , to)";
            // 
            // SearchByRegDateLabel
            // 
            this.SearchByRegDateLabel.AutoSize = true;
            this.SearchByRegDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByRegDateLabel.Location = new System.Drawing.Point(777, 39);
            this.SearchByRegDateLabel.Name = "SearchByRegDateLabel";
            this.SearchByRegDateLabel.Size = new System.Drawing.Size(447, 39);
            this.SearchByRegDateLabel.TabIndex = 6;
            this.SearchByRegDateLabel.Text = "Search by reg date (from, to)";
            // 
            // SearchByStateLabel
            // 
            this.SearchByStateLabel.AutoSize = true;
            this.SearchByStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStateLabel.Location = new System.Drawing.Point(1537, 39);
            this.SearchByStateLabel.Name = "SearchByStateLabel";
            this.SearchByStateLabel.Size = new System.Drawing.Size(252, 39);
            this.SearchByStateLabel.TabIndex = 7;
            this.SearchByStateLabel.Text = "Search by state";
            // 
            // FromStartDateTimePicker
            // 
            this.FromStartDateTimePicker.Location = new System.Drawing.Point(18, 103);
            this.FromStartDateTimePicker.Name = "FromStartDateTimePicker";
            this.FromStartDateTimePicker.Size = new System.Drawing.Size(570, 38);
            this.FromStartDateTimePicker.TabIndex = 8;
            // 
            // ToStartDateTimePicker
            // 
            this.ToStartDateTimePicker.Location = new System.Drawing.Point(18, 147);
            this.ToStartDateTimePicker.Name = "ToStartDateTimePicker";
            this.ToStartDateTimePicker.Size = new System.Drawing.Size(570, 38);
            this.ToStartDateTimePicker.TabIndex = 9;
            // 
            // FromRegDateTimePicker
            // 
            this.FromRegDateTimePicker.Location = new System.Drawing.Point(784, 103);
            this.FromRegDateTimePicker.Name = "FromRegDateTimePicker";
            this.FromRegDateTimePicker.Size = new System.Drawing.Size(570, 38);
            this.FromRegDateTimePicker.TabIndex = 10;
            // 
            // ToRegDateTimePicker
            // 
            this.ToRegDateTimePicker.Location = new System.Drawing.Point(784, 147);
            this.ToRegDateTimePicker.Name = "ToRegDateTimePicker";
            this.ToRegDateTimePicker.Size = new System.Drawing.Size(570, 38);
            this.ToRegDateTimePicker.TabIndex = 11;
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(1544, 102);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(447, 39);
            this.StateComboBox.TabIndex = 12;
            // 
            // TournametForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2278, 1375);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LogOutbutton);
            this.Name = "TournametForm";
            this.Text = "TournamentForm";
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