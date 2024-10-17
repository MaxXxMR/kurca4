namespace kurca4
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel6 = new System.Windows.Forms.Panel();
            this.rollupButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.eyeButton = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.passwordButton = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.rollupButton);
            this.panel6.Controls.Add(this.settingsButton);
            this.panel6.Controls.Add(this.closeButton);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(541, 122);
            this.panel6.TabIndex = 4;
            // 
            // rollupButton
            // 
            this.rollupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.rollupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollupButton.Image = global::kurca4.Properties.Resources._8664917_window_minimize_icon1;
            this.rollupButton.Location = new System.Drawing.Point(395, 12);
            this.rollupButton.Name = "rollupButton";
            this.rollupButton.Size = new System.Drawing.Size(64, 64);
            this.rollupButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollupButton.TabIndex = 13;
            this.rollupButton.TabStop = false;
            this.rollupButton.Click += new System.EventHandler(this.rollupButton_Click);
            this.rollupButton.MouseEnter += new System.EventHandler(this.rollupButton_MouseEnter);
            this.rollupButton.MouseLeave += new System.EventHandler(this.rollupButton_MouseLeave);
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
            this.settingsButton.TabIndex = 12;
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
            this.closeButton.Location = new System.Drawing.Point(465, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 64);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 11;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(103, 160);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(426, 64);
            this.nameField.TabIndex = 6;
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            this.nameField.MouseEnter += new System.EventHandler(this.nameField_MouseEnter);
            this.nameField.MouseLeave += new System.EventHandler(this.nameField_MouseLeave);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passField.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(103, 263);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(356, 64);
            this.passField.TabIndex = 8;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            this.passField.MouseEnter += new System.EventHandler(this.passField_MouseEnter);
            this.passField.MouseLeave += new System.EventHandler(this.passField_MouseLeave);
            // 
            // enterButton
            // 
            this.enterButton.AutoSize = true;
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Freestyle Script", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.Black;
            this.enterButton.Location = new System.Drawing.Point(133, 359);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(300, 87);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(203, 449);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(145, 57);
            this.registerLabel.TabIndex = 11;
            this.registerLabel.Text = "Register?";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            this.registerLabel.MouseEnter += new System.EventHandler(this.registerLabel_MouseEnter);
            this.registerLabel.MouseLeave += new System.EventHandler(this.registerLabel_MouseLeave);
            // 
            // eyeButton
            // 
            this.eyeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeButton.Image = global::kurca4.Properties.Resources.eyeslashicon;
            this.eyeButton.Location = new System.Drawing.Point(465, 263);
            this.eyeButton.Name = "eyeButton";
            this.eyeButton.Size = new System.Drawing.Size(64, 64);
            this.eyeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeButton.TabIndex = 9;
            this.eyeButton.TabStop = false;
            this.eyeButton.Click += new System.EventHandler(this.eyeButton_Click);
            this.eyeButton.MouseEnter += new System.EventHandler(this.eyeButton_MouseEnter);
            this.eyeButton.MouseLeave += new System.EventHandler(this.eyeButton_MouseLeave);
            // 
            // profileButton
            // 
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(13, 160);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(64, 64);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 5;
            this.profileButton.TabStop = false;
            this.profileButton.MouseEnter += new System.EventHandler(this.profileButton_MouseEnter);
            this.profileButton.MouseLeave += new System.EventHandler(this.profileButton_MouseLeave);
            // 
            // passwordButton
            // 
            this.passwordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordButton.Image = ((System.Drawing.Image)(resources.GetObject("passwordButton.Image")));
            this.passwordButton.Location = new System.Drawing.Point(13, 263);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(64, 64);
            this.passwordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordButton.TabIndex = 7;
            this.passwordButton.TabStop = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            this.passwordButton.DoubleClick += new System.EventHandler(this.passwordButton_DoubleClick);
            this.passwordButton.MouseEnter += new System.EventHandler(this.passwordButton_MouseEnter);
            this.passwordButton.MouseLeave += new System.EventHandler(this.passwordButton_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(541, 515);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.eyeButton);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox eyeButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.PictureBox rollupButton;
        private System.Windows.Forms.PictureBox passwordButton;
    }
}