using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kurca4
{
    public partial class TicketsForm : Form
    {
        private int clickCount = 0;
        public TicketsForm()
        {
            InitializeComponent();
            SoundPlayer roundstartSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\roundstart.wav");
            roundstartSound.Play();
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

        private void volume_MouseEnter(object sender, EventArgs e)
        {
            volume.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void volume_MouseLeave(object sender, EventArgs e)
        {
            volume.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(198, 230, 245);
        }
        

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
             BackButton.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void JapanButton_Click(object sender, EventArgs e)
        {
            SoundPlayer tokyothankyouSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\tokyothankyou.wav");
            tokyothankyouSound.Play();
            if (codeField.Text == "MAX")
            {
                MessageBox.Show("Вы получили билет в Японию бесплатно, спасибо за покупку!)");
            }
            else
            {
                MessageBox.Show("Вы купили билет в Японию, спасибо за покупку!)");
            }
        }

        private void JapanButton_MouseEnter(object sender, EventArgs e)
        {
            JapanButton.BackColor = Color.FromArgb(198, 230, 245);
            helperlabel.Text = "В туре в Японию вы увидете одни из самых красивых улиц\r\nи станций метро мира, который все обрисовоны в\r\nпотрясающих графити, поедите необычайно вкусный\r\nрамен, познакомитесь с интересными людьми, увидите\r\nневероятные завараживающие виды и  невероятную\r\nприроду.\r\nВсего за 9500 BUN вы сможете познать во всей красе\r\nкреативную и интересную культуру Востока.\r\n";
            SoundPlayer priyatnayaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\priyatnaya.wav");
            priyatnayaSound.Play();
        }

        private void JapanButton_MouseLeave(object sender, EventArgs e)
        {
            JapanButton.BackColor = Color.FromArgb(218, 239, 248);
            helperlabel.Text = "Спасибо, что захотели купить билет в один из наших туров!\r\nКаждый тур длится 7 дней: 5 дней на отведённый по плану\r\nместа, 2 дня на развлечение, отдых и сувенирчики))).\r\nЦена дороги входит в стоимость тура, однако наш тур\r\nначинается с аэропорта в Минске, поэтому вам необходимо\r\nдобраться до туда самостоятельно. Там вас встретит наш\r\nадминистратор, с которым вы подпишете все необходимые\r\nдокументы и соответсвенно оплатите поездку. \r\nСпасибо за понимание и хорошего вам отдыха!\r\n";
        }

        private void EnglandButton_Click(object sender, EventArgs e)
        {
            SoundPlayer tnxSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\tnx.wav");
            tnxSound.Play();
            if (codeField.Text == "MAX")
            {
                MessageBox.Show("Вы получили билет в Великобританию бесплатно, спасибо за покупку!)");
            }
            else
            {
                MessageBox.Show("Вы купили билет в Великобританию, спасибо за покупку!)");
            }
        }

        private void EnglandButton_MouseEnter(object sender, EventArgs e)
        {
            EnglandButton.BackColor = Color.FromArgb(198, 230, 245);
            helperlabel.Text = "В туре в Великобританию вы увидете одни из \r\nвдохновляющих видов, побываете в невероятно\r\nкрасивых местах, который навивают стариной,\r\nтак же вы увидите наикрасивейшие виды площай\r\nи архитектуры.\r\nВсего за 2500 BUN вы сможете почустовать\r\nпотрясающую атмосферу Великобритании!\r\n";
            SoundPlayer fonlyuditolpashumnayaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fonlyuditolpashumnaya.wav");
            fonlyuditolpashumnayaSound.Play();
        }

        private void EnglandButton_MouseLeave(object sender, EventArgs e)
        {
            EnglandButton.BackColor = Color.FromArgb(218, 239, 248);
            helperlabel.Text = "Спасибо, что захотели купить билет в один из наших туров!\r\nКаждый тур длится 7 дней: 5 дней на отведённый по плану\r\nместа, 2 дня на развлечение, отдых и сувенирчики))).\r\nЦена дороги входит в стоимость тура, однако наш тур\r\nначинается с аэропорта в Минске, поэтому вам необходимо\r\nдобраться до туда самостоятельно. Там вас встретит наш\r\nадминистратор, с которым вы подпишете все необходимые\r\nдокументы и соответсвенно оплатите поездку. \r\nСпасибо за понимание и хорошего вам отдыха!\r\n";
        }

        private void FranceButton_Click(object sender, EventArgs e)
        {
            SoundPlayer thankyoufrenchSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\thankyoufrench.wav");
            thankyoufrenchSound.Play();
            if (codeField.Text == "MAX")
            {
                MessageBox.Show("Вы получили билет во Францию бесплатно, спасибо за покупку!)");
            }
            else
            {
                MessageBox.Show("Вы купили билет во Францию, спасибо за покупку!)");
            }
        }

        private void FranceButton_MouseEnter(object sender, EventArgs e)
        {
            FranceButton.BackColor = Color.FromArgb(198, 230, 245);
            helperlabel.Text = "В туре во Францию вы увидете одни из самых культурных\r\nмест Европы, одни из самых завараживающих улиц\r\nПарижа и самые известные места Франции.\r\nВсего за 2000 BUN вы сможете познать высокую\r\nкультуру Европы.\r\n";
            SoundPlayer metroinparisSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\metroinparis.wav");
            metroinparisSound.Play();
        }

        private void FranceButton_MouseLeave(object sender, EventArgs e)
        {
            FranceButton.BackColor = Color.FromArgb(218, 239, 248);
            helperlabel.Text = "Спасибо, что захотели купить билет в один из наших туров!\r\nКаждый тур длится 7 дней: 5 дней на отведённый по плану\r\nместа, 2 дня на развлечение, отдых и сувенирчики))).\r\nЦена дороги входит в стоимость тура, однако наш тур\r\nначинается с аэропорта в Минске, поэтому вам необходимо\r\nдобраться до туда самостоятельно. Там вас встретит наш\r\nадминистратор, с которым вы подпишете все необходимые\r\nдокументы и соответсвенно оплатите поездку. \r\nСпасибо за понимание и хорошего вам отдыха!\r\n";
        }

        Point lastPoint;
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

        private void TicketsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TicketsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void helperlabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void helperlabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void helper_Click(object sender, EventArgs e)
        {
            clickCount++;
            SoundPlayer fnafbeatboxSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fnafbeatbox.wav");
            fnafbeatboxSound.Play();
            if (clickCount >= 2 && clickCount < 25)
            {
                SoundPlayer honkSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\honk.wav");
                honkSound.Play();
            }
            if (clickCount == 25)
            {
                SoundPlayer yaySound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\yay.wav");
                yaySound.Play();
                helperlabel.Text = "Ты нашёл пасхалку, поздравляю!. Введите код MAX\r\nи тогда вы получите 1 тур бесплатно)))";
            }
            if (clickCount > 25)
            {
                SoundPlayer honkSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\honk.wav");
                honkSound.Play();
                helperlabel.Text = "Ты нашёл пасхалку, поздравляю!. Введите код MAX\r\nи тогда вы получите 1 тур бесплатно)))";
            }

        }

        private void helper_MouseEnter(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void helper_MouseLeave(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void codeField_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer stavliudushumateriSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\stavliudushumateri.wav");
            stavliudushumateriSound.Play();
            codeField.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void codeField_MouseLeave(object sender, EventArgs e)
        {
            codeField.BackColor = Color.FromArgb(218, 239, 248);
        }
    }
}
