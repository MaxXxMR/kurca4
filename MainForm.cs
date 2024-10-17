using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace kurca4
{
    public partial class MainForm : Form
    {
        private int clickCount = 0;
        public MainForm()
        {
            InitializeComponent();
            SoundPlayer tututututuSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\tututututu.wav");
            tututututuSound.Play();

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

        Point lastPoint;
       

        private void mainlabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainlabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void back_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void JapanButton_MouseEnter(object sender, EventArgs e)
        {
            JapanButton.BackColor = Color.FromArgb(73, 196, 238);
            SoundPlayer yesyesSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\yesyes.wav");
            yesyesSound.Play();
           /* SoundPlayer tuturuSound = new SoundPlayer(@"C:\Users\Hp\Downloads\tuturu.wav");
            tuturuSound.Play();*/
            helperlabel.Text = "В этом туре в Японию вы сможете посетить Храм Фусими-инари\r\n(г.Киото), Небесное дерево (г.Токио), Омоидэ Йокочо\r\nв Синдзюку (г.Токио), Бамбуковый лес Сагано (г.Киото)\r\nи Снежные обезьяны в горячих источниках (Нагано).\r\n";
        }

        private void JapanButton_MouseLeave(object sender, EventArgs e)
        {
            JapanButton.BackColor = Color.FromArgb(20, 166, 216);
            /*SoundPlayer jotaronoSound = new SoundPlayer(@"C:\Users\Hp\Downloads\jotarono.wav");
            jotaronoSound.Play();*/
            /*SoundPlayer nyaSound = new SoundPlayer(@"C:\Users\Hp\Downloads\nya.wav");
            nyaSound.Play();*/
            helperlabel.Text = "Приветствую! Буду рад тебе помочь! У нас есть 3 тура в такие \r\nстраны как Япония, Великобринатния и Франция. Чтобы \r\nузнать информацию о туре, просто наведитесь на нужную \r\nкнопку или нажмите на неё. Если вы передумаете, то всегда \r\nсможете вернуться к этому окну!";
        }

        private void EnglandButton_MouseEnter(object sender, EventArgs e)
        {
            EnglandButton.BackColor = Color.FromArgb(73, 196, 238);
            SoundPlayer oenglandSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\oengland.wav");
            oenglandSound.Play();
            helperlabel.Text = "В этом туре в Англию вы сможете посетить Биг-Бен и британский\r\nпарламент (г. Лондон), Британский музей (г. Лондон),\r\nМузей Шерлока Холмса (г.Лондон), Галерея Тейт Модерн\r\n(г. Лондон) и Букингемский дворец (г. Лондон).\r\n";
        }

        private void EnglandButton_MouseLeave(object sender, EventArgs e)
        {
            EnglandButton.BackColor = Color.FromArgb(20, 166, 216);
            helperlabel.Text = "Приветствую! Буду рад тебе помочь! У нас есть 3 тура в такие \r\nстраны как Япония, Великобринатния и Франция. Чтобы \r\nузнать информацию о туре, просто наведитесь на нужную \r\nкнопку или нажмите на неё. Если вы передумаете, то всегда \r\nсможете вернуться к этому окну!";
        }

        private void FranceButton_MouseEnter(object sender, EventArgs e)
        {
            FranceButton.BackColor = Color.FromArgb(73, 196, 238);
            SoundPlayer FranceStereotypicalMusicSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\FranceStereotypicalMusic.wav");
            FranceStereotypicalMusicSound.Play();
            helperlabel.Text = "В этом туре во Францию вы сможете посетить Эйфелева башня\r\n(г. Париж), Лувр (г. Париж), Версальский дворец (г. Париж),\r\nШамони Монблан (Альпы, гора Монблан) и Парижский\r\nДиснейлэнд (35 км от г.Париж).\r\n ";
        }

        private void FranceButton_MouseLeave(object sender, EventArgs e)
        {
            FranceButton.BackColor = Color.FromArgb(20, 166, 216);
            helperlabel.Text = "Приветствую! Буду рад тебе помочь! У нас есть 3 тура в такие \r\nстраны как Япония, Великобринатния и Франция. Чтобы \r\nузнать информацию о туре, просто наведитесь на нужную \r\nкнопку или нажмите на неё. Если вы передумаете, то всегда \r\nсможете вернуться к этому окну!";
        }

        private void helper_MouseEnter(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(73, 196, 238);
        }

        private void helper_MouseLeave(object sender, EventArgs e)
        {
            helper.BackColor = Color.FromArgb(20, 166, 216);
        }

        private void helper_Click(object sender, EventArgs e)
        {
            clickCount++;
            SoundPlayer honkSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\honk.wav");
            honkSound.Play();
            if (clickCount == 3)
            {
                helperlabel.Text = "Привет), надеюсь ты хорошо проведёшь своё время)";
            }
            else if (clickCount == 6)
            {
                helperlabel.Text = "Я рад, что ты веселишься, но лучше подойди к делу серьёзно!)";
            }
            else if (clickCount == 9)
            {
                helperlabel.Text = "Ну хватит - хватит, лучше почитай информацию о билетиках) ";
            }
            else if (clickCount == 12)
            {
                helperlabel.Text = "Давай прекращай уже, лучше прочитай информацию о турах.";
            }
            else if (clickCount == 15)
            {
                helperlabel.Text = "Не надо больше нажимать, лучше купи билет пожалуйста.";
            }
            else if (clickCount == 18)
            {
                helperlabel.Text = "Хватит нажимать или пожалеешь >:(";
                SoundPlayer stopitSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\stopit.wav");
                stopitSound.Play();
            }
            else if (clickCount == 21)
            {
                MessageBox.Show("Тебе не стоило этого делать, надеюсь это будет для тебя уроком >:( ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Выключение компьютера
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
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

        private void JapanButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            JapanForm japanForm = new JapanForm();
            japanForm.Show();
        }

        private void EnglandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglandForm englandForm = new EnglandForm();
            englandForm.Show();
        }

        private void FranceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FranceForm franceForm = new FranceForm();
            franceForm.Show();
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
