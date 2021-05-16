
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
            this.ChangeIconButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChangeLoginButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.NewLoginLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewLoginTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeIconButton
            // 
            this.ChangeIconButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeIconButton.BackgroundImage")));
            this.ChangeIconButton.Location = new System.Drawing.Point(26, 143);
            this.ChangeIconButton.Name = "ChangeIconButton";
            this.ChangeIconButton.Size = new System.Drawing.Size(52, 53);
            this.ChangeIconButton.TabIndex = 1;
            this.ChangeIconButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.Location = new System.Drawing.Point(124, 143);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(54, 53);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChangeLoginButton
            // 
            this.ChangeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLoginButton.Location = new System.Drawing.Point(38, 215);
            this.ChangeLoginButton.Name = "ChangeLoginButton";
            this.ChangeLoginButton.Size = new System.Drawing.Size(140, 30);
            this.ChangeLoginButton.TabIndex = 3;
            this.ChangeLoginButton.Text = "Change login";
            this.ChangeLoginButton.UseVisualStyleBackColor = true;
            this.ChangeLoginButton.Visible = false;
            this.ChangeLoginButton.Click += new System.EventHandler(this.ChangeLoginButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(38, 251);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(140, 33);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Visible = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLabel.Location = new System.Drawing.Point(331, 50);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(55, 16);
            this.ChangeLabel.TabIndex = 5;
            this.ChangeLabel.Text = "Change";
            this.ChangeLabel.Visible = false;
            // 
            // NewLoginLabel
            // 
            this.NewLoginLabel.AutoSize = true;
            this.NewLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLoginLabel.Location = new System.Drawing.Point(238, 88);
            this.NewLoginLabel.Name = "NewLoginLabel";
            this.NewLoginLabel.Size = new System.Drawing.Size(67, 16);
            this.NewLoginLabel.TabIndex = 6;
            this.NewLoginLabel.Text = "New login";
            this.NewLoginLabel.Visible = false;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(238, 122);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(91, 16);
            this.OldPasswordLabel.TabIndex = 7;
            this.OldPasswordLabel.Text = "Old password";
            this.OldPasswordLabel.Visible = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(238, 162);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(97, 16);
            this.NewPasswordLabel.TabIndex = 8;
            this.NewPasswordLabel.Text = "New password";
            this.NewPasswordLabel.Visible = false;
            // 
            // NewLoginTextBox
            // 
            this.NewLoginTextBox.Location = new System.Drawing.Point(345, 84);
            this.NewLoginTextBox.Name = "NewLoginTextBox";
            this.NewLoginTextBox.Size = new System.Drawing.Size(121, 20);
            this.NewLoginTextBox.TabIndex = 9;
            this.NewLoginTextBox.Visible = false;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(345, 118);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.OldPasswordTextBox.TabIndex = 10;
            this.OldPasswordTextBox.Visible = false;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(345, 158);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.NewPasswordTextBox.TabIndex = 11;
            this.NewPasswordTextBox.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(310, 201);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 31);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.BackgroundImage")));
            this.IconPictureBox.InitialImage = null;
            this.IconPictureBox.Location = new System.Drawing.Point(59, 40);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(91, 86);
            this.IconPictureBox.TabIndex = 13;
            this.IconPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 309);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.NewLoginTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.NewLoginLabel);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ChangeLoginButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ChangeIconButton);
            this.Name = "MyAccountForm";
            this.Text = "MyAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeIconButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ChangeLoginButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label NewLoginLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewLoginTextBox;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}