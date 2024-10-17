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
    public partial class FranceForm : Form
    {
        public FranceForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(59, 158, 255); 
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(0, 128, 253);
        }

        private void rollupButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rollupButton_MouseEnter(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(59, 158, 255);
        }

        private void rollupButton_MouseLeave(object sender, EventArgs e)
        {
            rollupButton.BackColor = Color.FromArgb(0, 128, 253);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(59, 158, 255);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.FromArgb(0, 128, 253);
        }

        Point lastPoint;
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

        private void japanlabel_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(0, 128, 253);
            text2.BackColor = Color.FromArgb(0, 128, 253);
            text3.BackColor = Color.FromArgb(0, 128, 253);
            text4.BackColor = Color.FromArgb(0, 128, 253);
            text5.BackColor = Color.FromArgb(0, 128, 253);
            text6.BackColor = Color.FromArgb(0, 128, 253);
            helper.BackColor = Color.FromArgb(0, 128, 253);
            back.Image = Properties.Resources.france1;
            SoundPlayer FranceStereotypicalMusicSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\FranceStereotypicalMusic.wav");
            FranceStereotypicalMusicSound.Play();

        }

        private void text6_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(0, 128, 253);
            text2.BackColor = Color.FromArgb(0, 128, 253);
            text3.BackColor = Color.FromArgb(0, 128, 253);
            text4.BackColor = Color.FromArgb(0, 128, 253);
            text5.BackColor = Color.FromArgb(0, 128, 253);
            text6.BackColor = Color.FromArgb(0, 128, 253);
            helper.BackColor = Color.FromArgb(0, 128, 253);
            back.Image = Properties.Resources.france1;
            SoundPlayer FranceStereotypicalMusicSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\FranceStereotypicalMusic.wav");
            FranceStereotypicalMusicSound.Play();
        }

        private void text1_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(226, 215, 221);
            text2.BackColor = Color.FromArgb(226, 215, 221);
            text3.BackColor = Color.FromArgb(226, 215, 221);
            text4.BackColor = Color.FromArgb(226, 215, 221);
            text5.BackColor = Color.FromArgb(226, 215, 221);
            text6.BackColor = Color.FromArgb(226, 215, 221);
            helper.BackColor = Color.FromArgb(221, 222, 224);
            back.Image = Properties.Resources.france2;
            SoundPlayer cocacolaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\cocacola.wav");
            cocacolaSound.Play();
        }

        private void text2_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(53, 105, 204);
            text2.BackColor = Color.FromArgb(53, 105, 204);
            text3.BackColor = Color.FromArgb(53, 105, 204);
            text4.BackColor = Color.FromArgb(53, 105, 204);
            text5.BackColor = Color.FromArgb(53, 105, 204);
            text6.BackColor = Color.FromArgb(53, 105, 204);
            helper.BackColor = Color.FromArgb(53, 105, 204);
            back.Image = Properties.Resources.france3;
            SoundPlayer lebronjamesSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\lebronjames.wav");
            lebronjamesSound.Play();
        }

        private void text3_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(186, 201, 220);
            text2.BackColor = Color.FromArgb(186, 201, 220);
            text3.BackColor = Color.FromArgb(186, 201, 220);
            text4.BackColor = Color.FromArgb(186, 201, 220);
            text5.BackColor = Color.FromArgb(186, 201, 220);
            text6.BackColor = Color.FromArgb(186, 201, 220);
            helper.BackColor = Color.FromArgb(186, 201, 220);
            back.Image = Properties.Resources.france4;
            SoundPlayer NapoleonsongSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\Napoleonsong.wav");
            NapoleonsongSound.Play();
        }

        private void text4_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(149, 171, 191);
            text2.BackColor = Color.FromArgb(149, 171, 191);
            text3.BackColor = Color.FromArgb(149, 171, 191);
            text4.BackColor = Color.FromArgb(149, 171, 191);
            text5.BackColor = Color.FromArgb(149, 171, 191);
            text6.BackColor = Color.FromArgb(149, 171, 191);
            helper.BackColor = Color.FromArgb(149, 171, 191);
            back.Image = Properties.Resources.france5;
            /*SoundPlayer tishinatakayaSound = new SoundPlayer(@"C:\Users\Hp\Downloads\tishinatakaya.wav");
            tishinatakayaSound.Play();*/
            SoundPlayer vgorahSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\vgorah.wav");
            vgorahSound.Play();
        }

        private void text5_MouseEnter(object sender, EventArgs e)
        {
            text1.BackColor = Color.FromArgb(140, 174, 236);
            text2.BackColor = Color.FromArgb(140, 174, 236);
            text3.BackColor = Color.FromArgb(140, 174, 236);
            text4.BackColor = Color.FromArgb(140, 174, 236);
            text5.BackColor = Color.FromArgb(140, 174, 236);
            text6.BackColor = Color.FromArgb(140, 174, 236);
            helper.BackColor = Color.FromArgb(140, 174, 236);
            back.Image = Properties.Resources.france6;
            SoundPlayer disneyintroSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\disneyintro.wav");
            disneyintroSound.Play();

        }

        private void text1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если Вы ещё раздумываете, что посмотреть во Франции, незамедлительно отправляйтесь  в его столицу, ведь достопримечательностей Парижа так много, что даже частичное их изучение не уложится в одну поездку. Символом Парижа, как вы уже догадываетесь, стала главная достопримечательность Франции – Эйфелева башня — один из самых посещаемых и узнаваемых архитектурных объектов в мире.\r\n\r\nЭто сейчас башня Эйфеля снискала мировую известность, а когда-то она вызывала неоднозначную реакцию среди парижан. В то время, как гости города восхищались монументальностью этого сооружения, многие жители, потрясённые размерами башни, были против её присутствия в городе и не раз требовали от властей разобрать это сооружение.", "Эйфелева башня (г. Париж)", MessageBoxButtons.OK);
        }

        private void text2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бывшая крепость, некогда дворец, а теперь музей — все эти перевоплощения пережил на своём веку Лувр в Париже, ставший самым посещаемым музеем, куда ежегодно приезжают миллионы людей со всего мира. Самое далёкое прошлое и настоящее сплелись здесь в единое целое в сотнях тысяч экспонатов, из которых лишь 35 тысяч мы можем увидеть своими глазами. Всё дело в том, что для показа всех этих ценностей не хватит никаких экспозиционных площадей, при этом многим экспонатам требуются ещё и особые условия хранения.", "Лувр (г. Париж)", MessageBoxButtons.OK);
        }

        private void text3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задавшись вопросом, что посмотреть во Франции, без раздумий отправляйтесь в один из самых респектабельных городов, расположенный в 20 км от столицы. Ведь здесь находится роскошный и сравнительно молодой дворцово-парковый комплекс, некогда служивший резиденцией французских королей, а сегодня ещё и ставший знаменитой достопримечательностью Франции.  Это Версальский дворец — выдающийся шедевр в истории мирового зодчества. Планировка парка Версальского дворца также являет собой высшее достижение в парковом искусстве Франции.", "Версальский дворец (г. Париж)", MessageBoxButtons.OK);
        }

        private void text4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шамони Монблан — долина в Альпах, ставшая культовым местом для занятий горнолыжным спортом. Старейший лыжный курорт, история которого насчитывает уже более 200 лет, стал важнейшей достопримечательностью Франции для любителей горных лыж. Ведь здесь можно не только насладиться неповторимыми видами горной панорамы, но и отлично, в определённой степени даже экстремально, провести время.", "Шамони Монблан (Альпы, гора Монблан)", MessageBoxButtons.OK);
        }

        private void text5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Путешествующим с детьми не придётся думать, что посетить во Франции всей семьёй, ведь и дети, и их родители мечтают попасть в настоящую парижскую сказку под названием «Диснейлэнд». Этот гигантский комплекс развлечений, снискавший мировую известность, включает парки, отели, сказочные «страны» и целые жилые районы. По посещаемости Диснейлэнд превосходит все туристические объекты стран Старого Света.", "Парижский Диснейлэнд (35 км от г.Париж)", MessageBoxButtons.OK);
        }

        private void text6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }
    }
}
