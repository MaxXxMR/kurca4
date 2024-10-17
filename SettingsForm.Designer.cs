namespace kurca4
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingslabel = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HelperText = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.PictureBox();
            this.helper = new System.Windows.Forms.PictureBox();
            this.rollupButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // settingslabel
            // 
            this.settingslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.settingslabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingslabel.Font = new System.Drawing.Font("Freestyle Script", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingslabel.Location = new System.Drawing.Point(0, 0);
            this.settingslabel.Name = "settingslabel";
            this.settingslabel.Size = new System.Drawing.Size(1000, 122);
            this.settingslabel.TabIndex = 24;
            this.settingslabel.Text = "Settings";
            this.settingslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingslabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settingslabel_MouseDown);
            this.settingslabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settingslabel_MouseMove);
            // 
            // authorizationButton
            // 
            this.authorizationButton.AutoSize = true;
            this.authorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationButton.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizationButton.ForeColor = System.Drawing.Color.Black;
            this.authorizationButton.Location = new System.Drawing.Point(12, 489);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(432, 57);
            this.authorizationButton.TabIndex = 27;
            this.authorizationButton.Text = "Return to the authorization window";
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            this.authorizationButton.MouseEnter += new System.EventHandler(this.authorizationButton_MouseEnter);
            this.authorizationButton.MouseLeave += new System.EventHandler(this.authorizationButton_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(529, 489);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(424, 57);
            this.registerButton.TabIndex = 28;
            this.registerButton.Text = "Return to the registration window";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(319, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 60);
            this.label1.TabIndex = 29;
            this.label1.Text = "Разработчик:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(837, 238);
            this.label2.TabIndex = 30;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // HelperText
            // 
            this.HelperText.AutoSize = true;
            this.HelperText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.HelperText.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelperText.Location = new System.Drawing.Point(95, 31);
            this.HelperText.Name = "HelperText";
            this.HelperText.Size = new System.Drawing.Size(45, 34);
            this.HelperText.TabIndex = 32;
            this.HelperText.Text = "   ";
            this.HelperText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelperText_MouseDown);
            this.HelperText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelperText_MouseMove);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume.Image = global::kurca4.Properties.Resources.volumeon;
            this.volume.Location = new System.Drawing.Point(784, 12);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(64, 64);
            this.volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volume.TabIndex = 33;
            this.volume.TabStop = false;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            this.volume.MouseEnter += new System.EventHandler(this.volume_MouseEnter);
            this.volume.MouseLeave += new System.EventHandler(this.volume_MouseLeave);
            // 
            // helper
            // 
            this.helper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helper.Image = global::kurca4.Properties.Resources._4691304_tapas_icon;
            this.helper.Location = new System.Drawing.Point(12, 12);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(64, 64);
            this.helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helper.TabIndex = 31;
            this.helper.TabStop = false;
            this.helper.Click += new System.EventHandler(this.helper_Click);
            this.helper.MouseEnter += new System.EventHandler(this.helper_MouseEnter);
            this.helper.MouseLeave += new System.EventHandler(this.helper_MouseLeave);
            // 
            // rollupButton
            // 
            this.rollupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.rollupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollupButton.Image = global::kurca4.Properties.Resources._8664917_window_minimize_icon1;
            this.rollupButton.Location = new System.Drawing.Point(854, 12);
            this.rollupButton.Name = "rollupButton";
            this.rollupButton.Size = new System.Drawing.Size(64, 64);
            this.rollupButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollupButton.TabIndex = 26;
            this.rollupButton.TabStop = false;
            this.rollupButton.Click += new System.EventHandler(this.rollupButton_Click);
            this.rollupButton.MouseEnter += new System.EventHandler(this.rollupButton_MouseEnter);
            this.rollupButton.MouseLeave += new System.EventHandler(this.rollupButton_MouseLeave);
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
            this.closeButton.TabIndex = 25;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.HelperText);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.rollupButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.settingslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rollupButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label settingslabel;
        private System.Windows.Forms.Label authorizationButton;
        private System.Windows.Forms.Label registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox helper;
        private System.Windows.Forms.Label HelperText;
        private System.Windows.Forms.PictureBox volume;
    }
}