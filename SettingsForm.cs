using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurca4
{
    public partial class SettingsForm : Form
    {
       /* [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);*/
        public SettingsForm()
        {
            InitializeComponent();
            SoundPlayer зомбиапокалипсисSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\зомбиапокалипсис.wav");
            зомбиапокалипсисSound.Play();
            /* waveOutSetVolume(IntPtr.Zero, 0x7FFF7FFF); // 0x7FFF7FFF половина // 0xFFFFFFFF - максимум */

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void rollupButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rollupButton_MouseEnter(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void rollupButton_MouseLeave(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void authorizationButton_MouseEnter(object sender, EventArgs e)
        {
            authorizationButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void authorizationButton_MouseLeave(object sender, EventArgs e)
        {
            authorizationButton.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.FromArgb(218, 239, 248);
        }

        Point lastPoint;
        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void settingslabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void settingslabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void helper_Click(object sender, EventArgs e)
        {
            HelperText.Text = "Буду рад помочь)";
            SoundPlayer fnafbeatboxSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fnafbeatbox.wav");
            fnafbeatboxSound.Play();
        }

        private void helper_MouseEnter(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void helper_MouseLeave(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void HelperText_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HelperText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void volume_MouseEnter(object sender, EventArgs e)
        {
            volume.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void volume_MouseLeave(object sender, EventArgs e)
        {
            volume.BackColor = Color.FromArgb(157, 214, 238);
        }

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private bool isMuted = false;
        private void volume_Click(object sender, EventArgs e)
        {
            uint currVol;
            waveOutGetVolume(IntPtr.Zero, out currVol);

            // При нажатии кнопки переключаем состояние звука
            if (!isMuted)
            {
                // Если звук включен, выключаем его
                waveOutSetVolume(IntPtr.Zero, 0);
                isMuted = true;
                volume.Image = Properties.Resources.volumeoff;
            }
            else
            {
                // Если звук выключен, возвращаем предыдущую громкость
                waveOutSetVolume(IntPtr.Zero, 0xFFFFFFFF); // 0x7FFF7FFF половина // 0xFFFFFFFF - максимум
                isMuted = false;
                volume.Image = Properties.Resources.volumeon;
            }
        }
    }
}
