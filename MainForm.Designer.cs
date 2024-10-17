namespace kurca4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.JapanButton = new System.Windows.Forms.Label();
            this.FranceButton = new System.Windows.Forms.Label();
            this.EnglandButton = new System.Windows.Forms.Label();
            this.helperlabel = new System.Windows.Forms.Label();
            this.helper = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.rollupButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.volume = new System.Windows.Forms.PictureBox();
            this.mainlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.helper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // JapanButton
            // 
            this.JapanButton.AutoSize = true;
            this.JapanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.JapanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JapanButton.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JapanButton.ForeColor = System.Drawing.Color.White;
            this.JapanButton.Location = new System.Drawing.Point(85, 411);
            this.JapanButton.Name = "JapanButton";
            this.JapanButton.Size = new System.Drawing.Size(231, 57);
            this.JapanButton.TabIndex = 28;
            this.JapanButton.Text = "Tickets to Japan";
            this.JapanButton.Click += new System.EventHandler(this.JapanButton_Click);
            this.JapanButton.MouseEnter += new System.EventHandler(this.JapanButton_MouseEnter);
            this.JapanButton.MouseLeave += new System.EventHandler(this.JapanButton_MouseLeave);
            // 
            // FranceButton
            // 
            this.FranceButton.AutoSize = true;
            this.FranceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.FranceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FranceButton.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranceButton.ForeColor = System.Drawing.Color.White;
            this.FranceButton.Location = new System.Drawing.Point(912, 411);
            this.FranceButton.Name = "FranceButton";
            this.FranceButton.Size = new System.Drawing.Size(245, 57);
            this.FranceButton.TabIndex = 29;
            this.FranceButton.Text = "Tickets to France";
            this.FranceButton.Click += new System.EventHandler(this.FranceButton_Click);
            this.FranceButton.MouseEnter += new System.EventHandler(this.FranceButton_MouseEnter);
            this.FranceButton.MouseLeave += new System.EventHandler(this.FranceButton_MouseLeave);
            // 
            // EnglandButton
            // 
            this.EnglandButton.AutoSize = true;
            this.EnglandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.EnglandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnglandButton.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglandButton.ForeColor = System.Drawing.Color.White;
            this.EnglandButton.Location = new System.Drawing.Point(478, 411);
            this.EnglandButton.Name = "EnglandButton";
            this.EnglandButton.Size = new System.Drawing.Size(250, 57);
            this.EnglandButton.TabIndex = 30;
            this.EnglandButton.Text = "Tickets to England";
            this.EnglandButton.Click += new System.EventHandler(this.EnglandButton_Click);
            this.EnglandButton.MouseEnter += new System.EventHandler(this.EnglandButton_MouseEnter);
            this.EnglandButton.MouseLeave += new System.EventHandler(this.EnglandButton_MouseLeave);
            // 
            // helperlabel
            // 
            this.helperlabel.AutoSize = true;
            this.helperlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.helperlabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helperlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helperlabel.Location = new System.Drawing.Point(103, 123);
            this.helperlabel.Name = "helperlabel";
            this.helperlabel.Size = new System.Drawing.Size(1019, 180);
            this.helperlabel.TabIndex = 33;
            this.helperlabel.Text = resources.GetString("helperlabel.Text");
            this.helperlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helperlabel_MouseDown);
            this.helperlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.helperlabel_MouseMove);
            // 
            // helper
            // 
            this.helper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helper.Image = global::kurca4.Properties.Resources._4691304_tapas_icon;
            this.helper.Location = new System.Drawing.Point(13, 123);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(64, 64);
            this.helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helper.TabIndex = 32;
            this.helper.TabStop = false;
            this.helper.Click += new System.EventHandler(this.helper_Click);
            this.helper.MouseEnter += new System.EventHandler(this.helper_MouseEnter);
            this.helper.MouseLeave += new System.EventHandler(this.helper_MouseLeave);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::kurca4.Properties.Resources._8664926_circle_left_direction_icon;
            this.BackButton.Location = new System.Drawing.Point(13, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 64);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 31;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.Image = global::kurca4.Properties.Resources.fon_dlia_bileta_50_foto_361;
            this.back.Location = new System.Drawing.Point(0, 116);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1200, 701);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 24;
            this.back.TabStop = false;
            this.back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_MouseDown);
            this.back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_MouseMove);
            // 
            // rollupButton
            // 
            this.rollupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.rollupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollupButton.Image = global::kurca4.Properties.Resources._8664917_window_minimize_icon1;
            this.rollupButton.Location = new System.Drawing.Point(1054, 12);
            this.rollupButton.Name = "rollupButton";
            this.rollupButton.Size = new System.Drawing.Size(64, 64);
            this.rollupButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollupButton.TabIndex = 23;
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
            this.closeButton.Location = new System.Drawing.Point(1124, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 64);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 22;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume.Image = global::kurca4.Properties.Resources.volumeon;
            this.volume.Location = new System.Drawing.Point(984, 12);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(64, 64);
            this.volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volume.TabIndex = 34;
            this.volume.TabStop = false;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            this.volume.MouseEnter += new System.EventHandler(this.volume_MouseEnter);
            this.volume.MouseLeave += new System.EventHandler(this.volume_MouseLeave);
            // 
            // mainlabel
            // 
            this.mainlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.mainlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainlabel.Font = new System.Drawing.Font("Freestyle Script", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainlabel.Location = new System.Drawing.Point(0, 0);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(1200, 120);
            this.mainlabel.TabIndex = 21;
            this.mainlabel.Text = "Main Menu";
            this.mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainlabel_MouseDown);
            this.mainlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainlabel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.helperlabel);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EnglandButton);
            this.Controls.Add(this.FranceButton);
            this.Controls.Add(this.JapanButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rollupButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.helper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox rollupButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label JapanButton;
        private System.Windows.Forms.Label FranceButton;
        private System.Windows.Forms.Label EnglandButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox helper;
        private System.Windows.Forms.Label helperlabel;
        private System.Windows.Forms.PictureBox volume;
        private System.Windows.Forms.Label mainlabel;
    }
}