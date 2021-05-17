
namespace ParMath
{
    partial class MyAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccountForm));
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ThemeButton = new System.Windows.Forms.Button();
            this.GoToTournamentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.Location = new System.Drawing.Point(58, 143);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(54, 53);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLabel.ForeColor = System.Drawing.Color.White;
            this.ChangeLabel.Location = new System.Drawing.Point(331, 50);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(55, 16);
            this.ChangeLabel.TabIndex = 5;
            this.ChangeLabel.Text = "Change";
            this.ChangeLabel.Visible = false;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.OldPasswordLabel.Location = new System.Drawing.Point(238, 93);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(91, 16);
            this.OldPasswordLabel.TabIndex = 7;
            this.OldPasswordLabel.Text = "Old password";
            this.OldPasswordLabel.Visible = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.NewPasswordLabel.Location = new System.Drawing.Point(238, 143);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(97, 16);
            this.NewPasswordLabel.TabIndex = 8;
            this.NewPasswordLabel.Text = "New password";
            this.NewPasswordLabel.Visible = false;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.OldPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.OldPasswordTextBox.Location = new System.Drawing.Point(345, 93);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.OldPasswordTextBox.TabIndex = 10;
            this.OldPasswordTextBox.Visible = false;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.NewPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(345, 143);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.NewPasswordTextBox.TabIndex = 11;
            this.NewPasswordTextBox.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(289, 190);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(142, 31);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Confirm changes";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.BackgroundImage")));
            this.IconPictureBox.InitialImage = null;
            this.IconPictureBox.Location = new System.Drawing.Point(38, 36);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(91, 86);
            this.IconPictureBox.TabIndex = 13;
            this.IconPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ThemeButton
            // 
            this.ThemeButton.BackColor = System.Drawing.Color.Black;
            this.ThemeButton.ForeColor = System.Drawing.Color.White;
            this.ThemeButton.Location = new System.Drawing.Point(422, 13);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Size = new System.Drawing.Size(75, 23);
            this.ThemeButton.TabIndex = 15;
            this.ThemeButton.Text = "Dark";
            this.ThemeButton.UseVisualStyleBackColor = false;
            this.ThemeButton.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // GoToTournamentButton
            // 
            this.GoToTournamentButton.BackColor = System.Drawing.Color.Black;
            this.GoToTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToTournamentButton.ForeColor = System.Drawing.Color.White;
            this.GoToTournamentButton.Location = new System.Drawing.Point(38, 245);
            this.GoToTournamentButton.Name = "GoToTournamentButton";
            this.GoToTournamentButton.Size = new System.Drawing.Size(140, 36);
            this.GoToTournamentButton.TabIndex = 17;
            this.GoToTournamentButton.Text = "Go to Tournament";
            this.GoToTournamentButton.UseVisualStyleBackColor = false;
            this.GoToTournamentButton.Click += new System.EventHandler(this.GoToTournamentButton_Click);
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(514, 309);
            this.Controls.Add(this.GoToTournamentButton);
            this.Controls.Add(this.ThemeButton);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.SettingsButton);
            this.Name = "MyAccountForm";
            this.Text = "MyAccountForm";
            this.Load += new System.EventHandler(this.MyAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ThemeButton;
        private System.Windows.Forms.Button GoToTournamentButton;
    }
}