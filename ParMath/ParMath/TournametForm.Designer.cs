
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
            this.TournamentsSearchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByStartDateLabel = new System.Windows.Forms.Label();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.FromStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchByStateLabel = new System.Windows.Forms.Label();
            this.ToRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromRegDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchByRegDateLabel = new System.Windows.Forms.Label();
            this.TournamentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameTournamentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ModeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StartDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LastRegDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LevelRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ParticipantsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ScenarioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ActionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlaceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CreateTournamentTabPage = new System.Windows.Forms.TabPage();
            this.CupGridButton = new System.Windows.Forms.Button();
            this.StatsTabPage = new System.Windows.Forms.TabPage();
            this.StatsTournamentPanel = new System.Windows.Forms.Panel();
            this.TournamentsPanel = new System.Windows.Forms.Panel();
            this.TournamentsLabel = new System.Windows.Forms.Label();
            this.TournamentsStatsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FinishedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NotStartedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NumberOfTournamentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StatsPlayersPanel = new System.Windows.Forms.Panel();
            this.PlayersStatsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameStatsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GamesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.WinsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LosesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CupWinsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.GoToMyAccountButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TournamentsTabPage.SuspendLayout();
            this.TournamentsSearchPanel.SuspendLayout();
            this.TournamentsTableLayoutPanel.SuspendLayout();
            this.CreateTournamentTabPage.SuspendLayout();
            this.StatsTabPage.SuspendLayout();
            this.StatsTournamentPanel.SuspendLayout();
            this.TournamentsPanel.SuspendLayout();
            this.TournamentsStatsTableLayoutPanel.SuspendLayout();
            this.StatsPlayersPanel.SuspendLayout();
            this.PlayersStatsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutbutton.BackColor = System.Drawing.Color.Black;
            this.LogOutbutton.ForeColor = System.Drawing.Color.White;
            this.LogOutbutton.Location = new System.Drawing.Point(869, 5);
            this.LogOutbutton.Margin = new System.Windows.Forms.Padding(1);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(56, 42);
            this.LogOutbutton.TabIndex = 0;
            this.LogOutbutton.Text = "Log out";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TournamentsTabPage);
            this.TabControl.Controls.Add(this.CreateTournamentTabPage);
            this.TabControl.Controls.Add(this.StatsTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.Location = new System.Drawing.Point(4, 51);
            this.TabControl.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(40, 40);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(945, 457);
            this.TabControl.TabIndex = 1;
            // 
            // TournamentsTabPage
            // 
            this.TournamentsTabPage.Controls.Add(this.TournamentsSearchPanel);
            this.TournamentsTabPage.Controls.Add(this.TournamentsTableLayoutPanel);
            this.TournamentsTabPage.Controls.Add(this.ClearAllButton);
            this.TournamentsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentsTabPage.Location = new System.Drawing.Point(4, 107);
            this.TournamentsTabPage.Margin = new System.Windows.Forms.Padding(1);
            this.TournamentsTabPage.Name = "TournamentsTabPage";
            this.TournamentsTabPage.Padding = new System.Windows.Forms.Padding(1);
            this.TournamentsTabPage.Size = new System.Drawing.Size(937, 346);
            this.TournamentsTabPage.TabIndex = 0;
            this.TournamentsTabPage.Text = "Tournaments";
            this.TournamentsTabPage.UseVisualStyleBackColor = true;
            // 
            // TournamentsSearchPanel
            // 
            this.TournamentsSearchPanel.Controls.Add(this.label1);
            this.TournamentsSearchPanel.Controls.Add(this.SearchByStartDateLabel);
            this.TournamentsSearchPanel.Controls.Add(this.StateComboBox);
            this.TournamentsSearchPanel.Controls.Add(this.FromStartDateTimePicker);
            this.TournamentsSearchPanel.Controls.Add(this.SearchByStateLabel);
            this.TournamentsSearchPanel.Controls.Add(this.ToRegDateTimePicker);
            this.TournamentsSearchPanel.Controls.Add(this.ToStartDateTimePicker);
            this.TournamentsSearchPanel.Controls.Add(this.FromRegDateTimePicker);
            this.TournamentsSearchPanel.Controls.Add(this.SearchByRegDateLabel);
            this.TournamentsSearchPanel.Location = new System.Drawing.Point(7, 10);
            this.TournamentsSearchPanel.Name = "TournamentsSearchPanel";
            this.TournamentsSearchPanel.Size = new System.Drawing.Size(838, 96);
            this.TournamentsSearchPanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by rage date (from , to)";
            // 
            // SearchByStartDateLabel
            // 
            this.SearchByStartDateLabel.AutoSize = true;
            this.SearchByStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStartDateLabel.Location = new System.Drawing.Point(5, 13);
            this.SearchByStartDateLabel.Name = "SearchByStartDateLabel";
            this.SearchByStartDateLabel.Size = new System.Drawing.Size(202, 17);
            this.SearchByStartDateLabel.TabIndex = 5;
            this.SearchByStartDateLabel.Text = "Search by start date (from , to)";
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(630, 43);
            this.StateComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(188, 21);
            this.StateComboBox.TabIndex = 12;
            // 
            // FromStartDateTimePicker
            // 
            this.FromStartDateTimePicker.Location = new System.Drawing.Point(8, 32);
            this.FromStartDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.FromStartDateTimePicker.Name = "FromStartDateTimePicker";
            this.FromStartDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.FromStartDateTimePicker.TabIndex = 8;
            // 
            // SearchByStateLabel
            // 
            this.SearchByStateLabel.AutoSize = true;
            this.SearchByStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByStateLabel.Location = new System.Drawing.Point(1195, 24);
            this.SearchByStateLabel.Name = "SearchByStateLabel";
            this.SearchByStateLabel.Size = new System.Drawing.Size(107, 17);
            this.SearchByStateLabel.TabIndex = 7;
            this.SearchByStateLabel.Text = "Search by state";
            // 
            // ToRegDateTimePicker
            // 
            this.ToRegDateTimePicker.Location = new System.Drawing.Point(248, 32);
            this.ToRegDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.ToRegDateTimePicker.Name = "ToRegDateTimePicker";
            this.ToRegDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.ToRegDateTimePicker.TabIndex = 11;
            // 
            // ToStartDateTimePicker
            // 
            this.ToStartDateTimePicker.Location = new System.Drawing.Point(8, 64);
            this.ToStartDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.ToStartDateTimePicker.Name = "ToStartDateTimePicker";
            this.ToStartDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.ToStartDateTimePicker.TabIndex = 9;
            // 
            // FromRegDateTimePicker
            // 
            this.FromRegDateTimePicker.Location = new System.Drawing.Point(248, 63);
            this.FromRegDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.FromRegDateTimePicker.Name = "FromRegDateTimePicker";
            this.FromRegDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.FromRegDateTimePicker.TabIndex = 10;
            // 
            // SearchByRegDateLabel
            // 
            this.SearchByRegDateLabel.AutoSize = true;
            this.SearchByRegDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByRegDateLabel.Location = new System.Drawing.Point(627, 19);
            this.SearchByRegDateLabel.Name = "SearchByRegDateLabel";
            this.SearchByRegDateLabel.Size = new System.Drawing.Size(191, 17);
            this.SearchByRegDateLabel.TabIndex = 6;
            this.SearchByRegDateLabel.Text = "Search by reg date (from, to)";
            // 
            // TournamentsTableLayoutPanel
            // 
            this.TournamentsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TournamentsTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.TournamentsTableLayoutPanel.Controls.Add(this.StartDateRichTextBox, 3, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.LastRegDateRichTextBox, 4, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.StateRichTextBox, 5, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.LevelRichTextBox, 6, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ParticipantsRichTextBox, 7, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ScenarioRichTextBox, 8, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.ActionsRichTextBox, 9, 0);
            this.TournamentsTableLayoutPanel.Controls.Add(this.PlaceRichTextBox, 2, 0);
            this.TournamentsTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentsTableLayoutPanel.Location = new System.Drawing.Point(6, 110);
            this.TournamentsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.TournamentsTableLayoutPanel.Name = "TournamentsTableLayoutPanel";
            this.TournamentsTableLayoutPanel.RowCount = 3;
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TournamentsTableLayoutPanel.Size = new System.Drawing.Size(926, 146);
            this.TournamentsTableLayoutPanel.TabIndex = 4;
            // 
            // NameTournamentsRichTextBox
            // 
            this.NameTournamentsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTournamentsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.NameTournamentsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTournamentsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTournamentsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NameTournamentsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NameTournamentsRichTextBox.Name = "NameTournamentsRichTextBox";
            this.NameTournamentsRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameTournamentsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NameTournamentsRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.NameTournamentsRichTextBox.TabIndex = 0;
            this.NameTournamentsRichTextBox.Text = "Name";
            // 
            // ModeRichTextBox
            // 
            this.ModeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ModeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ModeRichTextBox.Location = new System.Drawing.Point(93, 1);
            this.ModeRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ModeRichTextBox.Name = "ModeRichTextBox";
            this.ModeRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModeRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ModeRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.ModeRichTextBox.TabIndex = 1;
            this.ModeRichTextBox.Text = "Mode";
            // 
            // StartDateRichTextBox
            // 
            this.StartDateRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateRichTextBox.BackColor = System.Drawing.Color.Black;
            this.StartDateRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateRichTextBox.ForeColor = System.Drawing.Color.White;
            this.StartDateRichTextBox.Location = new System.Drawing.Point(277, 1);
            this.StartDateRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.StartDateRichTextBox.Name = "StartDateRichTextBox";
            this.StartDateRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.StartDateRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.StartDateRichTextBox.TabIndex = 3;
            this.StartDateRichTextBox.Text = "Start date";
            // 
            // LastRegDateRichTextBox
            // 
            this.LastRegDateRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastRegDateRichTextBox.BackColor = System.Drawing.Color.Black;
            this.LastRegDateRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastRegDateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastRegDateRichTextBox.ForeColor = System.Drawing.Color.White;
            this.LastRegDateRichTextBox.Location = new System.Drawing.Point(369, 1);
            this.LastRegDateRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.LastRegDateRichTextBox.Name = "LastRegDateRichTextBox";
            this.LastRegDateRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastRegDateRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LastRegDateRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.LastRegDateRichTextBox.TabIndex = 4;
            this.LastRegDateRichTextBox.Text = "Last reg date";
            // 
            // StateRichTextBox
            // 
            this.StateRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StateRichTextBox.BackColor = System.Drawing.Color.Black;
            this.StateRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateRichTextBox.ForeColor = System.Drawing.Color.White;
            this.StateRichTextBox.Location = new System.Drawing.Point(461, 1);
            this.StateRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.StateRichTextBox.Name = "StateRichTextBox";
            this.StateRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StateRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.StateRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.StateRichTextBox.TabIndex = 5;
            this.StateRichTextBox.Text = "State";
            // 
            // LevelRichTextBox
            // 
            this.LevelRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelRichTextBox.BackColor = System.Drawing.Color.Black;
            this.LevelRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LevelRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelRichTextBox.ForeColor = System.Drawing.Color.White;
            this.LevelRichTextBox.Location = new System.Drawing.Point(553, 1);
            this.LevelRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.LevelRichTextBox.Name = "LevelRichTextBox";
            this.LevelRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LevelRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LevelRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.LevelRichTextBox.TabIndex = 6;
            this.LevelRichTextBox.Text = "Level";
            // 
            // ParticipantsRichTextBox
            // 
            this.ParticipantsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticipantsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ParticipantsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParticipantsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParticipantsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ParticipantsRichTextBox.Location = new System.Drawing.Point(645, 1);
            this.ParticipantsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ParticipantsRichTextBox.Name = "ParticipantsRichTextBox";
            this.ParticipantsRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParticipantsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ParticipantsRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.ParticipantsRichTextBox.TabIndex = 7;
            this.ParticipantsRichTextBox.Text = "Participants";
            // 
            // ScenarioRichTextBox
            // 
            this.ScenarioRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ScenarioRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScenarioRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScenarioRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ScenarioRichTextBox.Location = new System.Drawing.Point(737, 1);
            this.ScenarioRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ScenarioRichTextBox.Name = "ScenarioRichTextBox";
            this.ScenarioRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScenarioRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ScenarioRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.ScenarioRichTextBox.TabIndex = 8;
            this.ScenarioRichTextBox.Text = "Scenario";
            this.ScenarioRichTextBox.TextChanged += new System.EventHandler(this.ScenarioRichTextBox_TextChanged);
            // 
            // ActionsRichTextBox
            // 
            this.ActionsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ActionsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActionsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ActionsRichTextBox.Location = new System.Drawing.Point(829, 1);
            this.ActionsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ActionsRichTextBox.Name = "ActionsRichTextBox";
            this.ActionsRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActionsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ActionsRichTextBox.Size = new System.Drawing.Size(96, 46);
            this.ActionsRichTextBox.TabIndex = 9;
            this.ActionsRichTextBox.Text = "Actions";
            // 
            // PlaceRichTextBox
            // 
            this.PlaceRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceRichTextBox.BackColor = System.Drawing.Color.Black;
            this.PlaceRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaceRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceRichTextBox.ForeColor = System.Drawing.Color.White;
            this.PlaceRichTextBox.Location = new System.Drawing.Point(185, 1);
            this.PlaceRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.PlaceRichTextBox.Name = "PlaceRichTextBox";
            this.PlaceRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlaceRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PlaceRichTextBox.Size = new System.Drawing.Size(90, 46);
            this.PlaceRichTextBox.TabIndex = 2;
            this.PlaceRichTextBox.Text = "Place";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.BackColor = System.Drawing.Color.Black;
            this.ClearAllButton.ForeColor = System.Drawing.Color.White;
            this.ClearAllButton.Location = new System.Drawing.Point(861, 10);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(56, 42);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Clear all";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentTabPage
            // 
            this.CreateTournamentTabPage.Controls.Add(this.CupGridButton);
            this.CreateTournamentTabPage.Location = new System.Drawing.Point(4, 107);
            this.CreateTournamentTabPage.Margin = new System.Windows.Forms.Padding(1);
            this.CreateTournamentTabPage.Name = "CreateTournamentTabPage";
            this.CreateTournamentTabPage.Padding = new System.Windows.Forms.Padding(1);
            this.CreateTournamentTabPage.Size = new System.Drawing.Size(937, 346);
            this.CreateTournamentTabPage.TabIndex = 1;
            this.CreateTournamentTabPage.Text = "Create tournament";
            this.CreateTournamentTabPage.UseVisualStyleBackColor = true;
            // 
            // CupGridButton
            // 
            this.CupGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CupGridButton.BackColor = System.Drawing.Color.Black;
            this.CupGridButton.ForeColor = System.Drawing.Color.White;
            this.CupGridButton.Location = new System.Drawing.Point(386, 108);
            this.CupGridButton.Margin = new System.Windows.Forms.Padding(1);
            this.CupGridButton.Name = "CupGridButton";
            this.CupGridButton.Size = new System.Drawing.Size(192, 90);
            this.CupGridButton.TabIndex = 1;
            this.CupGridButton.Text = "Cup grid";
            this.CupGridButton.UseVisualStyleBackColor = false;
            this.CupGridButton.Click += new System.EventHandler(this.CupGridButton_Click);
            // 
            // StatsTabPage
            // 
            this.StatsTabPage.Controls.Add(this.tableLayoutPanel1);
            this.StatsTabPage.Controls.Add(this.StatsTournamentPanel);
            this.StatsTabPage.Controls.Add(this.StatsPlayersPanel);
            this.StatsTabPage.Location = new System.Drawing.Point(4, 107);
            this.StatsTabPage.Margin = new System.Windows.Forms.Padding(1);
            this.StatsTabPage.Name = "StatsTabPage";
            this.StatsTabPage.Padding = new System.Windows.Forms.Padding(1);
            this.StatsTabPage.Size = new System.Drawing.Size(937, 346);
            this.StatsTabPage.TabIndex = 2;
            this.StatsTabPage.Text = "Stats";
            this.StatsTabPage.UseVisualStyleBackColor = true;
            // 
            // StatsTournamentPanel
            // 
            this.StatsTournamentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatsTournamentPanel.Controls.Add(this.TournamentsPanel);
            this.StatsTournamentPanel.Controls.Add(this.TournamentsStatsTableLayoutPanel);
            this.StatsTournamentPanel.Location = new System.Drawing.Point(22, 478);
            this.StatsTournamentPanel.Name = "StatsTournamentPanel";
            this.StatsTournamentPanel.Size = new System.Drawing.Size(2175, 350);
            this.StatsTournamentPanel.TabIndex = 5;
            // 
            // TournamentsPanel
            // 
            this.TournamentsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TournamentsPanel.Controls.Add(this.TournamentsLabel);
            this.TournamentsPanel.Location = new System.Drawing.Point(15, 3);
            this.TournamentsPanel.Name = "TournamentsPanel";
            this.TournamentsPanel.Size = new System.Drawing.Size(2144, 98);
            this.TournamentsPanel.TabIndex = 1;
            // 
            // TournamentsLabel
            // 
            this.TournamentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TournamentsLabel.AutoSize = true;
            this.TournamentsLabel.Location = new System.Drawing.Point(916, 22);
            this.TournamentsLabel.Name = "TournamentsLabel";
            this.TournamentsLabel.Size = new System.Drawing.Size(133, 24);
            this.TournamentsLabel.TabIndex = 0;
            this.TournamentsLabel.Text = "Tournaments";
            // 
            // TournamentsStatsTableLayoutPanel
            // 
            this.TournamentsStatsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TournamentsStatsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.TournamentsStatsTableLayoutPanel.Name = "TournamentsStatsTableLayoutPanel";
            this.TournamentsStatsTableLayoutPanel.RowCount = 2;
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TournamentsStatsTableLayoutPanel.Size = new System.Drawing.Size(2149, 217);
            this.TournamentsStatsTableLayoutPanel.TabIndex = 3;
            // 
            // ActiveRichTextBox
            // 
            this.ActiveRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ActiveRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ActiveRichTextBox.Location = new System.Drawing.Point(538, 1);
            this.ActiveRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ActiveRichTextBox.Name = "ActiveRichTextBox";
            this.ActiveRichTextBox.Size = new System.Drawing.Size(535, 106);
            this.ActiveRichTextBox.TabIndex = 1;
            this.ActiveRichTextBox.Text = "Active";
            // 
            // FinishedRichTextBox
            // 
            this.FinishedRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishedRichTextBox.BackColor = System.Drawing.Color.Black;
            this.FinishedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishedRichTextBox.ForeColor = System.Drawing.Color.White;
            this.FinishedRichTextBox.Location = new System.Drawing.Point(1075, 1);
            this.FinishedRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.FinishedRichTextBox.Name = "FinishedRichTextBox";
            this.FinishedRichTextBox.Size = new System.Drawing.Size(535, 106);
            this.FinishedRichTextBox.TabIndex = 2;
            this.FinishedRichTextBox.Text = "Finished";
            // 
            // NotStartedRichTextBox
            // 
            this.NotStartedRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotStartedRichTextBox.BackColor = System.Drawing.Color.Black;
            this.NotStartedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotStartedRichTextBox.ForeColor = System.Drawing.Color.White;
            this.NotStartedRichTextBox.Location = new System.Drawing.Point(1612, 1);
            this.NotStartedRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NotStartedRichTextBox.Name = "NotStartedRichTextBox";
            this.NotStartedRichTextBox.Size = new System.Drawing.Size(536, 106);
            this.NotStartedRichTextBox.TabIndex = 3;
            this.NotStartedRichTextBox.Text = "Not started";
            // 
            // NumberOfTournamentsRichTextBox
            // 
            this.NumberOfTournamentsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfTournamentsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.NumberOfTournamentsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTournamentsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.NumberOfTournamentsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NumberOfTournamentsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NumberOfTournamentsRichTextBox.Name = "NumberOfTournamentsRichTextBox";
            this.NumberOfTournamentsRichTextBox.Size = new System.Drawing.Size(535, 106);
            this.NumberOfTournamentsRichTextBox.TabIndex = 0;
            this.NumberOfTournamentsRichTextBox.Text = "Number of tournaments";
            // 
            // StatsPlayersPanel
            // 
            this.StatsPlayersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatsPlayersPanel.Controls.Add(this.label3);
            this.StatsPlayersPanel.Controls.Add(this.label2);
            this.StatsPlayersPanel.Controls.Add(this.PlayersStatsTableLayoutPanel);
            this.StatsPlayersPanel.Location = new System.Drawing.Point(3, 4);
            this.StatsPlayersPanel.Name = "StatsPlayersPanel";
            this.StatsPlayersPanel.Size = new System.Drawing.Size(927, 306);
            this.StatsPlayersPanel.TabIndex = 4;
            // 
            // PlayersStatsTableLayoutPanel
            // 
            this.PlayersStatsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.PlayersStatsTableLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.PlayersStatsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.PlayersStatsTableLayoutPanel.Name = "PlayersStatsTableLayoutPanel";
            this.PlayersStatsTableLayoutPanel.RowCount = 2;
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayersStatsTableLayoutPanel.Size = new System.Drawing.Size(926, 106);
            this.PlayersStatsTableLayoutPanel.TabIndex = 2;
            // 
            // NameStatsRichTextBox
            // 
            this.NameStatsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameStatsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.NameStatsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStatsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.NameStatsRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.NameStatsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NameStatsRichTextBox.Name = "NameStatsRichTextBox";
            this.NameStatsRichTextBox.Size = new System.Drawing.Size(183, 51);
            this.NameStatsRichTextBox.TabIndex = 0;
            this.NameStatsRichTextBox.Text = "Name";
            // 
            // GamesRichTextBox
            // 
            this.GamesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamesRichTextBox.BackColor = System.Drawing.Color.Black;
            this.GamesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesRichTextBox.ForeColor = System.Drawing.Color.White;
            this.GamesRichTextBox.Location = new System.Drawing.Point(186, 1);
            this.GamesRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.GamesRichTextBox.Name = "GamesRichTextBox";
            this.GamesRichTextBox.Size = new System.Drawing.Size(183, 51);
            this.GamesRichTextBox.TabIndex = 1;
            this.GamesRichTextBox.Text = "Games";
            // 
            // WinsRichTextBox
            // 
            this.WinsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.WinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.WinsRichTextBox.Location = new System.Drawing.Point(371, 1);
            this.WinsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.WinsRichTextBox.Name = "WinsRichTextBox";
            this.WinsRichTextBox.Size = new System.Drawing.Size(183, 51);
            this.WinsRichTextBox.TabIndex = 2;
            this.WinsRichTextBox.Text = "Wins";
            // 
            // LosesRichTextBox
            // 
            this.LosesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LosesRichTextBox.BackColor = System.Drawing.Color.Black;
            this.LosesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LosesRichTextBox.ForeColor = System.Drawing.Color.White;
            this.LosesRichTextBox.Location = new System.Drawing.Point(556, 1);
            this.LosesRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.LosesRichTextBox.Name = "LosesRichTextBox";
            this.LosesRichTextBox.Size = new System.Drawing.Size(183, 51);
            this.LosesRichTextBox.TabIndex = 3;
            this.LosesRichTextBox.Text = "Loses";
            // 
            // CupWinsRichTextBox
            // 
            this.CupWinsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CupWinsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.CupWinsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CupWinsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.CupWinsRichTextBox.Location = new System.Drawing.Point(741, 1);
            this.CupWinsRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.CupWinsRichTextBox.Name = "CupWinsRichTextBox";
            this.CupWinsRichTextBox.Size = new System.Drawing.Size(184, 51);
            this.CupWinsRichTextBox.TabIndex = 4;
            this.CupWinsRichTextBox.Text = "Cup wins";
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.ForeColor = System.Drawing.Color.White;
            this.PlayersLabel.Location = new System.Drawing.Point(366, 9);
            this.PlayersLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(78, 24);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players";
            // 
            // GoToMyAccountButton
            // 
            this.GoToMyAccountButton.BackColor = System.Drawing.Color.Black;
            this.GoToMyAccountButton.ForeColor = System.Drawing.Color.White;
            this.GoToMyAccountButton.Location = new System.Drawing.Point(596, 5);
            this.GoToMyAccountButton.Name = "GoToMyAccountButton";
            this.GoToMyAccountButton.Size = new System.Drawing.Size(164, 42);
            this.GoToMyAccountButton.TabIndex = 2;
            this.GoToMyAccountButton.Text = "Go to My Account";
            this.GoToMyAccountButton.UseVisualStyleBackColor = false;
            this.GoToMyAccountButton.Click += new System.EventHandler(this.GoToMyAccountButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 203);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 106);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 51);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Number of Tournament";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(232, 1);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(229, 51);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Active";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.BackColor = System.Drawing.Color.Black;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(463, 1);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(1);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(229, 51);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "Finished";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox4.BackColor = System.Drawing.Color.Black;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(694, 1);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(1);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(231, 51);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "Not started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(397, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tournament";
            // 
            // TournametForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 518);
            this.Controls.Add(this.GoToMyAccountButton);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LogOutbutton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "TournametForm";
            this.Text = "TournamentForm";
            this.TabControl.ResumeLayout(false);
            this.TournamentsTabPage.ResumeLayout(false);
            this.TournamentsSearchPanel.ResumeLayout(false);
            this.TournamentsSearchPanel.PerformLayout();
            this.TournamentsTableLayoutPanel.ResumeLayout(false);
            this.CreateTournamentTabPage.ResumeLayout(false);
            this.StatsTabPage.ResumeLayout(false);
            this.StatsTournamentPanel.ResumeLayout(false);
            this.TournamentsPanel.ResumeLayout(false);
            this.TournamentsPanel.PerformLayout();
            this.TournamentsStatsTableLayoutPanel.ResumeLayout(false);
            this.StatsPlayersPanel.ResumeLayout(false);
            this.StatsPlayersPanel.PerformLayout();
            this.PlayersStatsTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TournamentsTabPage;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TabPage CreateTournamentTabPage;
        private System.Windows.Forms.TabPage StatsTabPage;
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
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.DateTimePicker ToRegDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromRegDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromStartDateTimePicker;
        private System.Windows.Forms.Label SearchByStateLabel;
        private System.Windows.Forms.Label SearchByRegDateLabel;
        private System.Windows.Forms.Label SearchByStartDateLabel;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Button GoToMyAccountButton;
        private System.Windows.Forms.Panel TournamentsPanel;
        private System.Windows.Forms.Label TournamentsLabel;
        private System.Windows.Forms.Panel StatsPlayersPanel;
        private System.Windows.Forms.Panel StatsTournamentPanel;
        private System.Windows.Forms.Panel TournamentsSearchPanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel TournamentsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}