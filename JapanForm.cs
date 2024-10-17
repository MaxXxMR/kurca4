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

namespace kurca4
{
    public partial class JapanForm : Form
    {
        public JapanForm()
        {
            InitializeComponent();
            SoundPlayer damedaneSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\damedane.wav");
            damedaneSound.Play();
        }

       

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(174, 132, 162);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(168, 110, 152);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(174, 132, 162);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(168, 110, 152);
        }

        private void rollupButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rollupButton_MouseEnter(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(174, 132, 162);
        }

        private void rollupButton_MouseLeave(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(168, 110, 152);
        }

        Point lastPoint;

        private void japanlabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void japanlabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void text1_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(195, 58, 3);
            text2.BackColor = Color.FromArgb(195, 58, 3);
            text3.BackColor = Color.FromArgb(195, 58, 3);
            text4.BackColor = Color.FromArgb(195, 58, 3);
            text5.BackColor = Color.FromArgb(195, 58, 3);
            text6.BackColor = Color.FromArgb(195, 58, 3);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);

            //text6.Text = "";
            helper.BackColor = Color.FromArgb(195, 58, 3);
            back.Image = Properties.Resources.japan2;
            SoundPlayer jojoayayayaySound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\jojoayayayay.wav");
            jojoayayayaySound.Play();
            /*SoundPlayer WinteratFushimiInariShrineSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fushimi.wav");
            WinteratFushimiInariShrineSound.Play();*/
        }

        /*private void text1_MouseLeave(object sender, EventArgs e)
        {
            //text1.BackColor = Color.FromArgb(194, 126, 159);
            //text2.BackColor = Color.FromArgb(194, 126, 159);
            //text3.BackColor = Color.FromArgb(194, 126, 159);
            //text4.BackColor = Color.FromArgb(194, 126, 159);
            //text5.BackColor = Color.FromArgb(194, 126, 159);
            //text6.BackColor = Color.FromArgb(194, 126, 159);
            text6.Text = "Buy Ticket";
            //helper.BackColor = Color.FromArgb(194, 126, 159);
           // back.Image = Properties.Resources.japan1;
        }*/

        private void text2_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(239, 192, 210);
            text2.BackColor = Color.FromArgb(239, 192, 210);
            text3.BackColor = Color.FromArgb(239, 192, 210);
            text4.BackColor = Color.FromArgb(239, 192, 210);
            text5.BackColor = Color.FromArgb(239, 192, 210);
            text6.BackColor = Color.FromArgb(239, 192, 210);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);
            //text6.Text = "";
            helper.BackColor = Color.FromArgb(239, 192, 210);
            back.Image = Properties.Resources.japan3;
            /* SoundPlayer tobecontinuedSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\tobecontinued.wav");
             tobecontinuedSound.Play()*/
            ;
            /* SoundPlayer shumgorodskogotransportaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\shumgorodskogotransporta.wav");
             shumgorodskogotransportaSound.Play();*/
            SoundPlayer SilverhandArasakaTowerSiegeSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\SilverhandArasakaTowerSiege.wav");
            SilverhandArasakaTowerSiegeSound.Play();
        }

       

        private void text3_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(0, 0, 0);
            text2.BackColor = Color.FromArgb(0, 0, 0);
            text3.BackColor = Color.FromArgb(0, 0, 0);
            text4.BackColor = Color.FromArgb(0, 0, 0);
            text5.BackColor = Color.FromArgb(0, 0, 0);
            text6.BackColor = Color.FromArgb(0, 0, 0);
            //text6.Text = "";
            helper.BackColor = Color.FromArgb(255, 222, 81);

            text1.ForeColor = Color.FromArgb(255, 255, 255);
            text2.ForeColor = Color.FromArgb(255, 255, 255);
            text3.ForeColor = Color.FromArgb(255, 255, 255);
            text4.ForeColor = Color.FromArgb(255, 255, 255);
            text5.ForeColor = Color.FromArgb(255, 255, 255);
            text6.ForeColor = Color.FromArgb(255, 255, 255);
            back.Image = Properties.Resources.omoideyokocho;
            /* SoundPlayer KapujeroSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\Kapujero.wav");
             KapujeroSound.Play();*/
            SoundPlayer DeathNoteSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\DeathNote.wav");
            DeathNoteSound.Play();
        }

       

        private void text4_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(170, 194, 18);
            text2.BackColor = Color.FromArgb(170, 194, 18);
            text3.BackColor = Color.FromArgb(170, 194, 18);
            text4.BackColor = Color.FromArgb(170, 194, 18);
            text5.BackColor = Color.FromArgb(170, 194, 18);
            text6.BackColor = Color.FromArgb(170, 194, 18);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);
            //text6.Text = "";
            helper.BackColor = Color.FromArgb(170, 194, 18);
            back.Image = Properties.Resources.japan5;
            /*SoundPlayer bambukforestSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\forest.wav");
            bambukforestSound.Play();*/
            SoundPlayer OSTNarutoSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\OSTNaruto.wav");
            OSTNarutoSound.Play();

        }

       

        private void text5_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(135, 142, 148);
            text2.BackColor = Color.FromArgb(135, 142, 148);
            text3.BackColor = Color.FromArgb(135, 142, 148);
            text4.BackColor = Color.FromArgb(135, 142, 148);
            text5.BackColor = Color.FromArgb(135, 142, 148);
            text6.BackColor = Color.FromArgb(135, 142, 148);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);
            //text6.Text = "";
            helper.BackColor = Color.FromArgb(135, 142, 148); //143, 108, 76
            back.Image = Properties.Resources.japan6;
            SoundPlayer VoicyTokyoGhoulSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\VoicyTokyoGhoul.wav");
            VoicyTokyoGhoulSound.Play();
            /*SoundPlayer yavdjakuziSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\yavdjakuzi.wav");
            yavdjakuziSound.Play();*/
        }



        private void text1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Одним из исторических символов Японии считается Храм Фусими-Инари или Святилище из тысячи алых ворот, посвященное богине рисового плодородия. Грандиозные тоннели с порталами, предназначенными для богов, создавались, согласно верованию синтоизма. Японцы считают, что посещение Храма Фусими-Инари приносит успех и процветание. Не сомневайтесь, что посмотреть в Японии.", "Храм Фусими-инари (г.Киото)", MessageBoxButtons.OK);
        }

        private void text2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Небесное дерево Токио – вторая по высоте телебашня в мире. Это изящное архитектурное строение из стекла, бетона и металла взметнулось ввысь, благодаря стараниям опытных конструкторов и инженеров. Высота сооружения составляет 634 метра.", "Небесное дерево (г.Токио)", MessageBoxButtons.OK);
        }

        private void text3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Омоидэ Йокочо в Синдзюку - одна из 2400 красивых знаменитых улиц Токио, где люди могут насладиться древней японской атмосферой Токио. Небольшая аллея напоминает людям о том, что нужно посетить Уэно Амейоко, Гинза Йокочо, торговую улицу Накамисе, Сумида Киракира Шотенгай или местные улицы Гинза Янака. \r\n\r\nПлюс от меня). Это место стоит посетить фанатам шедевра Тетрадь смерти, который играет прямо сейчас). В регионе Канто вы сможете найти и посетить много мест от куда срисовывали кадры для аниме, ведь регион Канто - это место где жил Ягами Лайт). Станцию Синдзюку, Национальная комиссия общественной безопасности, парк Хибия)))", "Омоидэ Йокочо в Синдзюку (г.Токио)", MessageBoxButtons.OK);
        }

        private void text4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Живописная бамбуковая роща из тысяч высоких вечнозеленых деревьев – визитная карточка префектуры Киото. Среди городской инфраструктуры удивительно видеть такое зеленое чудо. Ровные стволы деревьев леса Сагано занимают территорию в 16 квадратных километров. Заповедная зона туристического района Арасияма находится под защитой ЮНЕСКО. Бамбуковый лес – это то, что посетить в Японии стоит обязательно.", "Бамбуковый лес Сагано (г.Киото)", MessageBoxButtons.OK);
        }

        private void text5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В долине реки Ёкою на высоте 850 метров над уровнем море расположен уникальный парк снежных обезьян Джигокудани, известный среди путешественников. Японские макаки демонстрируют оригинальное поведение. Третью часть года эта местность покрыта снегами, но, благодаря наличию горячих источников, снежные обезьяны могут жить в Нагано. Они нежатся в бассейнах, как в горячих ваннах.", "Снежные обезьяны в горячих источниках (Нагано)", MessageBoxButtons.OK);
        }

        private void japanlabel_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(194, 126, 159);
            text2.BackColor = Color.FromArgb(194, 126, 159);
            text3.BackColor = Color.FromArgb(194, 126, 159);
            text4.BackColor = Color.FromArgb(194, 126, 159);
            text5.BackColor = Color.FromArgb(194, 126, 159);
            text6.BackColor = Color.FromArgb(194, 126, 159);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);

            text6.Text = "Buy Ticket";
            helper.BackColor = Color.FromArgb(194, 126, 159);
            back.Image = Properties.Resources.japan1;
            SoundPlayer damedaneSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\damedane.wav");
            damedaneSound.Play();
        }

        private void text6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }

        private void text6_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(194, 126, 159);
            text2.BackColor = Color.FromArgb(194, 126, 159);
            text3.BackColor = Color.FromArgb(194, 126, 159);
            text4.BackColor = Color.FromArgb(194, 126, 159);
            text5.BackColor = Color.FromArgb(194, 126, 159);
            text6.BackColor = Color.FromArgb(194, 126, 159);

            text1.ForeColor = Color.FromArgb(0, 0, 0);
            text2.ForeColor = Color.FromArgb(0, 0, 0);
            text3.ForeColor = Color.FromArgb(0, 0, 0);
            text4.ForeColor = Color.FromArgb(0, 0, 0);
            text5.ForeColor = Color.FromArgb(0, 0, 0);
            text6.ForeColor = Color.FromArgb(0, 0, 0);

            text6.Text = "Buy Ticket";
            helper.BackColor = Color.FromArgb(194, 126, 159);
            back.Image = Properties.Resources.japan1;
            SoundPlayer damedaneSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\damedane.wav");
            damedaneSound.Play();
        }

        private void helper_Click(object sender, EventArgs e)
        {
            SoundPlayer tuturuSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\tuturu.wav");
            tuturuSound.Play();
        }
    }
}
