using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurca4
{
    public partial class EnglandForm : Form
    {
        public EnglandForm()
        {
            InitializeComponent();
            SoundPlayer animatsiyaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\animatsiya.wav");
            animatsiyaSound.Play();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(186, 186, 186);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(218, 218, 218);
        }

        private void rollupButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rollupButton_MouseEnter(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(186, 186, 186);
        }

        private void rollupButton_MouseLeave(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(218, 218, 218);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(186, 186, 186);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(218, 218, 218);
        }

        private void text1_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(221, 222, 224);
            text2.BackColor = Color.FromArgb(221, 222, 224);
            text3.BackColor = Color.FromArgb(221, 222, 224);
            text4.BackColor = Color.FromArgb(221, 222, 224);
            text5.BackColor = Color.FromArgb(221, 222, 224);
            text6.BackColor = Color.FromArgb(221, 222, 224);
            helper.BackColor = Color.FromArgb(221, 222, 224);
            back.Image = Properties.Resources.england2;
            SoundPlayer bigbangSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\bigbang.wav");
            bigbangSound.Play();
        }

        private void text2_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(60, 118, 189);
            text2.BackColor = Color.FromArgb(60, 118, 189);
            text3.BackColor = Color.FromArgb(60, 118, 189);
            text4.BackColor = Color.FromArgb(60, 118, 189);
            text5.BackColor = Color.FromArgb(60, 118, 189);
            text6.BackColor = Color.FromArgb(60, 118, 189);
            helper.BackColor = Color.FromArgb(60, 118, 189);
            back.Image = Properties.Resources.england3;
            SoundPlayer BritishMuseumSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\BritishMuseum.wav");
            BritishMuseumSound.Play();
        }

        private void text3_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(216, 215, 220);
            text2.BackColor = Color.FromArgb(216, 215, 220);
            text3.BackColor = Color.FromArgb(216, 215, 220);
            text4.BackColor = Color.FromArgb(216, 215, 220);
            text5.BackColor = Color.FromArgb(216, 215, 220);
            text6.BackColor = Color.FromArgb(216, 215, 220);
            helper.BackColor = Color.FromArgb(216, 215, 220);
            back.Image = Properties.Resources.england7;
            SoundPlayer SherlockHolmesSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\SherlockHolmes.wav");
            SherlockHolmesSound.Play();
        }

        private void text4_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(240, 231, 214);
            text2.BackColor = Color.FromArgb(240, 231, 214);
            text3.BackColor = Color.FromArgb(240, 231, 214);
            text4.BackColor = Color.FromArgb(240, 231, 214);
            text5.BackColor = Color.FromArgb(240, 231, 214);
            text6.BackColor = Color.FromArgb(240, 231, 214);
            helper.BackColor = Color.FromArgb(240, 231, 214);
            back.Image = Properties.Resources.england5;
            SoundPlayer bigrekaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\bigreka.wav");
            bigrekaSound.Play();
        }

        private void text5_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(169, 199, 15);
            text2.BackColor = Color.FromArgb(169, 199, 15);
            text3.BackColor = Color.FromArgb(169, 199, 15);
            text4.BackColor = Color.FromArgb(169, 199, 15);
            text5.BackColor = Color.FromArgb(169, 199, 15);
            text6.BackColor = Color.FromArgb(169, 199, 15);
            helper.BackColor = Color.FromArgb(169, 199, 15);
            back.Image = Properties.Resources.england6;
            SoundPlayer королеваанглииSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\королеваанглии.wav");
            королеваанглииSound.Play();
        }

        Point lastPoint;
        private void englandlabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void englandlabel_MouseMove(object sender, MouseEventArgs e)
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

        private void englandlabel_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(218, 218, 218);
            text2.BackColor = Color.FromArgb(218, 218, 218);
            text3.BackColor = Color.FromArgb(218, 218, 218);
            text4.BackColor = Color.FromArgb(218, 218, 218);
            text5.BackColor = Color.FromArgb(218, 218, 218);
            text6.BackColor = Color.FromArgb(218, 218, 218);
            helper.BackColor = Color.FromArgb(218, 218, 218);
            back.Image = Properties.Resources.england1;
            SoundPlayer animatsiyaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\animatsiya.wav");
            animatsiyaSound.Play();
        }

        private void text6_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(218, 218, 218);
            text2.BackColor = Color.FromArgb(218, 218, 218);
            text3.BackColor = Color.FromArgb(218, 218, 218);
            text4.BackColor = Color.FromArgb(218, 218, 218);
            text5.BackColor = Color.FromArgb(218, 218, 218);
            text6.BackColor = Color.FromArgb(218, 218, 218);
            helper.BackColor = Color.FromArgb(218, 218, 218);
            back.Image = Properties.Resources.england1;
            SoundPlayer animatsiyaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\animatsiya.wav");
            animatsiyaSound.Play();
        }

        private void text1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тот Вестминстерский дворец, который мы видим сейчас, построили в 1860 году на «костях» его предшественников. Королевские дворцы стояли здесь ещё с начала прошлого тысячелетия, а первый английский парламент собрался в 1265 году. Современный Вестминстерский дворец появился после того, как предыдущий уничтожил пожар в 1834 году. Сейчас, как и 700 лет назад, внутри заседает парламент Великобритании.\r\n\r\nОднако популярность Вестминстерского дворца меркнет на фоне одной из его башен — Башни Елизаветы, которую в народе принято называть Биг-Беном. Своё имя башня получила в честь Большого Бена — внутреннего колокола весом 13,7 тонны, что некогда было рекордом для всей Англии. В 2017 году, впервые за 157 лет, Биг-Бен замолчал: его отправили на реконструкцию, которую обещают завершить в первой половине 2022. По завершении работ знаменитый звон вновь разнесется по Лондону.", "Биг-Бен и британский парламент (г. Лондон)", MessageBoxButtons.OK);
        }

        private void text2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В 1753 году не стало английского врача и коллекционера сэра Ганса Слоана, который завещал личную коллекцию английскому парламенту за 20 000 фунтов стерлингов, а если они откажутся, то направить предложение в Россию, Германию, Францию и Испанию. Парламент охотно согласился на это, ведь коллекция сэра Слоана стоила в разы большей предложенной цены. Именно это событие в 1753 году положило начало истории Британского музея в Лондоне.\r\n\r\nСейчас музей является одним из крупнейших в мире, и уступает лишь Лувру в ежегодном количестве посетителей — около 6–7 миллионов. Коллекция особенно богата книгами и рукописями, а возраст некоторых из них больше 1,5 тыс. лет. Немало в музее и экспозиций, посвященных древним цивилизациям, странам Африки, Востока и Азии. Именно здесь хранятся мумии египетских фараонов, исполин с острова Пасхи, рисунки и рукописи Леонардо да Винчи, а также многое другое.", "Британский музей (г. Лондон)", MessageBoxButtons.OK);
        }

        private void text3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На табличке с номером дома можно увидеть дату «1881 – 1904». Она обозначает годы жизни Шерлока Холмса в своей квартире на Бейкер стрит. Исходя из рассказов Дойля, на момент заезда Шерлоку было 27 лет и он находился в пансионате под управлением миссис Хадсон. Здание музея с 1860 по 1936 года на самом деле было пансионатом, только номер был не 221b, а 239.\r\n\r\nЧуть позднее дома под номерами с 215 по 229 были присвоены Abbey National (строительное общество). В Abbey National Bank стали поступать письма на имя сыщика, и сотрудники были вынуждены нанять секретаря для написания ответов. Специально для этих целей зарегистрировали независимую фирму \"221b Baker Street\", и туда переправлялась вся почта, адресованная вымышленному Шерлоку Холмсу. Наконец-то на легальных основаниях появился дом 221b!\r\n\r\nВ 1990 году музей был открыт силами некоммерческого сообщества им. Шерлока Холмса.", "Музей Шерлока Холмса (г. Лондон)", MessageBoxButtons.OK);
        }

        private void text4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В группе галерей Тейт есть одна, посвященная современному искусству. Эту галерею называют Тейт Модерн, и расположена она на берегу Темзы в здании бывшей электростанции. Внутри представлено несколько экспозиций, среди которых произведения искусства начиная с 1900 года и заканчивая современностью. Здесь можно найти работы художников со всего мира, в том числе и России: в коллекции музея присутствуют работы Казимира Малевича, Марка Шагала, Ильи Кабакова и многих других. Особенно рекомендуем посетить Турбинный зал, где размещают самые масштабные инсталляции, некоторые из которых достигают 5 этажей в высоту.", "Галерея Тейт Модерн (г. Лондон)", MessageBoxButtons.OK);
        }

        private void text5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Букингемский дворец — это главная резиденция королевы Елизаветы II. Изначально дворец принадлежал герцогу Джону Шеффилду, но в 1762 году король Георг III выкупил его, дабы устроить здесь свою резиденцию. Тогда дворец был намного меньше, но расширился благодаря усилиям архитекторов Джона Нэша и Эдварда Блора. Они взяли за основу уже имеющуюся архитектурную модель Букингем-хауса (так раньше называлась резиденция) и пристроили ещё 3 подобных здания, в результате чего образовался квадрат с большим внутренним двором.\r\n\r\nПосетителей дворца интересуют не столько экстерьер и интерьер, сколько почетный караул, ежедневно сменяющийся на посту в 11:30 на протяжении многих лет. Трудно вспомнить более знаменитую церемонию в Англии и в мире в целом, а на это зрелище ежедневно приходят посмотреть тысячи туристов. Кстати, если королевский штандарт над крышей поднят, значит королева сейчас во дворце.", "Букингемский дворец (г. Лондон)", MessageBoxButtons.OK);
        }

        private void text6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }
    }
}
