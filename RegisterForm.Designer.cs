namespace kurca4
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nicknameField = new System.Windows.Forms.TextBox();
            this.mailField = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.rollupButton = new System.Windows.Forms.PictureBox();
            this.mailButton = new System.Windows.Forms.PictureBox();
            this.nicknameButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.eyeButton = new System.Windows.Forms.PictureBox();
            this.passwordButton = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicknameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Freestyle Script", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(364, 351);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(300, 87);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Enter";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(105, 259);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(288, 64);
            this.passField.TabIndex = 16;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            this.passField.MouseEnter += new System.EventHandler(this.passField_MouseEnter);
            this.passField.MouseLeave += new System.EventHandler(this.passField_MouseLeave);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(105, 156);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(367, 64);
            this.nameField.TabIndex = 14;
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            this.nameField.MouseEnter += new System.EventHandler(this.nameField_MouseEnter);
            this.nameField.MouseLeave += new System.EventHandler(this.nameField_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 122);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // nicknameField
            // 
            this.nicknameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.nicknameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameField.ForeColor = System.Drawing.Color.Black;
            this.nicknameField.Location = new System.Drawing.Point(621, 156);
            this.nicknameField.Multiline = true;
            this.nicknameField.Name = "nicknameField";
            this.nicknameField.Size = new System.Drawing.Size(367, 64);
            this.nicknameField.TabIndex = 28;
            this.nicknameField.Enter += new System.EventHandler(this.nicknameField_Enter);
            this.nicknameField.Leave += new System.EventHandler(this.nicknameField_Leave);
            this.nicknameField.MouseEnter += new System.EventHandler(this.nicknameField_MouseEnter);
            this.nicknameField.MouseLeave += new System.EventHandler(this.nicknameField_MouseLeave);
            // 
            // mailField
            // 
            this.mailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.mailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailField.ForeColor = System.Drawing.Color.Black;
            this.mailField.Location = new System.Drawing.Point(621, 259);
            this.mailField.Multiline = true;
            this.mailField.Name = "mailField";
            this.mailField.Size = new System.Drawing.Size(367, 64);
            this.mailField.TabIndex = 29;
            this.mailField.Enter += new System.EventHandler(this.mailField_Enter);
            this.mailField.Leave += new System.EventHandler(this.mailField_Leave);
            this.mailField.MouseEnter += new System.EventHandler(this.mailField_MouseEnter);
            this.mailField.MouseLeave += new System.EventHandler(this.mailField_MouseLeave);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(455, 448);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(108, 57);
            this.loginLabel.TabIndex = 30;
            this.loginLabel.Text = "Log in?";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            this.loginLabel.MouseEnter += new System.EventHandler(this.loginLabel_MouseEnter);
            this.loginLabel.MouseLeave += new System.EventHandler(this.loginLabel_MouseLeave);
            // 
            // rollupButton
            // 
            this.rollupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.rollupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollupButton.Image = global::kurca4.Properties.Resources._8664917_window_minimize_icon;
            this.rollupButton.Location = new System.Drawing.Point(854, 12);
            this.rollupButton.Name = "rollupButton";
            this.rollupButton.Size = new System.Drawing.Size(64, 64);
            this.rollupButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollupButton.TabIndex = 31;
            this.rollupButton.TabStop = false;
            this.rollupButton.Click += new System.EventHandler(this.rollupButton_Click);
            this.rollupButton.MouseEnter += new System.EventHandler(this.rollupButton_MouseEnter);
            this.rollupButton.MouseLeave += new System.EventHandler(this.rollupButton_MouseLeave);
            // 
            // mailButton
            // 
            this.mailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailButton.Image = global::kurca4.Properties.Resources.envelopemailmessageicon_;
            this.mailButton.Location = new System.Drawing.Point(509, 259);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(64, 64);
            this.mailButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailButton.TabIndex = 27;
            this.mailButton.TabStop = false;
            this.mailButton.MouseEnter += new System.EventHandler(this.mailButton_MouseEnter);
            this.mailButton.MouseLeave += new System.EventHandler(this.mailButton_MouseLeave);
            // 
            // nicknameButton
            // 
            this.nicknameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nicknameButton.Image = global::kurca4.Properties.Resources.facekissicon;
            this.nicknameButton.Location = new System.Drawing.Point(509, 156);
            this.nicknameButton.Name = "nicknameButton";
            this.nicknameButton.Size = new System.Drawing.Size(64, 64);
            this.nicknameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nicknameButton.TabIndex = 26;
            this.nicknameButton.TabStop = false;
            this.nicknameButton.Click += new System.EventHandler(this.nicknameButton_Click);
            this.nicknameButton.DoubleClick += new System.EventHandler(this.nicknameButton_DoubleClick);
            this.nicknameButton.MouseEnter += new System.EventHandler(this.nicknameButton_MouseEnter);
            this.nicknameButton.MouseLeave += new System.EventHandler(this.nicknameButton_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(13, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(64, 64);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsButton.TabIndex = 25;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(924, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 64);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 24;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // eyeButton
            // 
            this.eyeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeButton.Image = ((System.Drawing.Image)(resources.GetObject("eyeButton.Image")));
            this.eyeButton.Location = new System.Drawing.Point(408, 259);
            this.eyeButton.Name = "eyeButton";
            this.eyeButton.Size = new System.Drawing.Size(64, 64);
            this.eyeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeButton.TabIndex = 17;
            this.eyeButton.TabStop = false;
            this.eyeButton.Click += new System.EventHandler(this.eyeButton_Click);
            this.eyeButton.MouseEnter += new System.EventHandler(this.eyeButton_MouseEnter);
            this.eyeButton.MouseLeave += new System.EventHandler(this.eyeButton_MouseLeave);
            // 
            // passwordButton
            // 
            this.passwordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordButton.Image = global::kurca4.Properties.Resources.handgesture;
            this.passwordButton.Location = new System.Drawing.Point(12, 259);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(64, 64);
            this.passwordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordButton.TabIndex = 15;
            this.passwordButton.TabStop = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            this.passwordButton.DoubleClick += new System.EventHandler(this.passwordButton_DoubleClick);
            this.passwordButton.MouseEnter += new System.EventHandler(this.passwordButton_MouseEnter);
            this.passwordButton.MouseLeave += new System.EventHandler(this.passwordButton_MouseLeave);
            // 
            // profileButton
            // 
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(13, 156);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(64, 64);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 13;
            this.profileButton.TabStop = false;
            this.profileButton.MouseEnter += new System.EventHandler(this.profileButton_MouseEnter);
            this.profileButton.MouseLeave += new System.EventHandler(this.profileButton_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1000, 514);
            this.Controls.Add(this.rollupButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.mailField);
            this.Controls.Add(this.nicknameField);
            this.Controls.Add(this.mailButton);
            this.Controls.Add(this.nicknameButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.eyeButton);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.profileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicknameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox eyeButton;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox passwordButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox nicknameButton;
        private System.Windows.Forms.TextBox nicknameField;
        private System.Windows.Forms.TextBox mailField;
        private System.Windows.Forms.PictureBox mailButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox rollupButton;
    }
}