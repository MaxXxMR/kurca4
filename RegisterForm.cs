using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace kurca4
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            SoundPlayer fnaf2Sound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fnaf2.wav");
            fnaf2Sound.Play();
            /*SoundPlayer reportSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\report.wav");
            reportSound.Play();*/
            nameField.Text = "Введите логин";
            nameField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
            nicknameField.Text = "Введите никнейм";
            nicknameField.ForeColor = Color.Gray;
            mailField.Text = "Введите почту";
            mailField.ForeColor = Color.Gray;

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

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(157, 214, 238);
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void passwordButton_MouseEnter(object sender, EventArgs e)
        {
            passwordButton.BackColor = Color.FromArgb(198, 230, 245);
            passwordButton.Image = Properties.Resources.handpeaceicon; // Change to your second image
            SoundPlayer ballboyhiSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\ballboyhi.wav");
            ballboyhiSound.Play();
        }

        private void passwordButton_MouseLeave(object sender, EventArgs e)
        {
            passwordButton.BackColor = Color.FromArgb(218, 239, 248);
            passwordButton.Image = Properties.Resources.handgesture; // Change to your second image
        }

        private void eyeButton_MouseEnter(object sender, EventArgs e)
        {
            eyeButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void eyeButton_MouseLeave(object sender, EventArgs e)
        {
            eyeButton.BackColor = Color.FromArgb(218, 239, 248);
        }


        Point lastPoint;

        private void RegisterForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void nameField_MouseEnter(object sender, EventArgs e)
        {
            nameField.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void nameField_MouseLeave(object sender, EventArgs e)
        {
            nameField.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void passField_MouseEnter(object sender, EventArgs e)
        {
            passField.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void passField_MouseLeave(object sender, EventArgs e)
        {
            passField.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void mailField_MouseEnter(object sender, EventArgs e)
        {
            mailField.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void mailField_MouseLeave(object sender, EventArgs e)
        {
            mailField.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void nicknameButton_MouseEnter(object sender, EventArgs e)
        {
            nicknameButton.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void nicknameButton_MouseLeave(object sender, EventArgs e)
        {
            nicknameButton.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void mailButton_MouseEnter(object sender, EventArgs e)
        {
            mailButton.BackColor = Color.FromArgb(198, 230, 245);
            mailButton.Image = Properties.Resources.envelopeopenicon; // Change to your second image
            SoundPlayer cutelevelupSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\cutelevelup.wav");
            cutelevelupSound.Play();
        }

        private void mailButton_MouseLeave(object sender, EventArgs e)
        {
            mailButton.BackColor = Color.FromArgb(218, 239, 248);
            mailButton.Image = Properties.Resources.mail; // Change to your second image
        }

        private void nicknameField_MouseEnter(object sender, EventArgs e)
        {
            nicknameField.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void nicknameField_MouseLeave(object sender, EventArgs e)
        {
            nicknameField.BackColor = Color.FromArgb(218, 239, 248);
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите логин")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Введите логин";
                nameField.ForeColor = Color.Gray;
            }
        }

        private bool passwordVisible = false; // Флаг для отслеживания видимости пароля
        private void eyeButton_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                passField.PasswordChar = '*'; // Скрываем символы
                eyeButton.Image = Properties.Resources.eyeviewicon; // Change to your second image
                passwordVisible = false; // Устанавливаем флаг в исходное состояние
            }
            else
            {
                passField.PasswordChar = '\0'; // Отображаем символы
                eyeButton.Image = Properties.Resources.eyeslashicon; // Change to your second image
                passwordVisible = true; // Устанавливаем флаг в состояние видимости
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void nicknameField_Enter(object sender, EventArgs e)
        {
            if (nicknameField.Text == "Введите никнейм")
            {
                nicknameField.Text = "";
                nicknameField.ForeColor = Color.Black;
            }
        }

        private void nicknameField_Leave(object sender, EventArgs e)
        {
            if (nicknameField.Text == "")
            {
                nicknameField.Text = "Введите никнейм";
                nicknameField.ForeColor = Color.Gray;
            }
        }

        private void mailField_Enter(object sender, EventArgs e)
        {
            if (mailField.Text == "Введите почту")
            {
                mailField.Text = "";
                mailField.ForeColor = Color.Black;
            }
        }

        private void mailField_Leave(object sender, EventArgs e)
        {
            if (mailField.Text == "")
            {
                mailField.Text = "Введите почту";
                mailField.ForeColor = Color.Gray;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите логин")
            {
                MessageBox.Show("Ведите логин");
                return;
            }

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (nicknameField.Text == "Введите никнейм")
            {
                MessageBox.Show("Введите никнейм");
                return;
            }

            if (mailField.Text == "Введите почту")
            {
                MessageBox.Show("Введите почту");
                return;
            }
            string[] arr_email = {
                "@gmail.com",
                "@mail.com",
                "@yahoo.com",
                "@outlook.com",
                "@aol.com",
                "@hotmail.com",
                "@icloud.com",
                "@protonmail.com",
                "@zoho.com",
                "@yandex.ru"
            };
            bool containsEmail = false;
            foreach (string email in arr_email)
            {
                if (mailField.Text.Contains(email))
                {
                    containsEmail = true;
                    break;
                }
            }

            if (!containsEmail)
            {
                MessageBox.Show("Введите почту, к примеру @gmail.com или @mail.com ");
                return; 
            }
           
            if (isLoginExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `nickname`, `mail`) VALUES (@login, @pass, @nickname, @mail)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = nicknameField.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mailField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }


        public Boolean isLoginExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = nameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой логин");
                return true;
            }
            else

                return false;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void loginLabel_MouseEnter(object sender, EventArgs e)
        {
            loginLabel.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void loginLabel_MouseLeave(object sender, EventArgs e)
        {
            loginLabel.BackColor = Color.FromArgb(218, 239, 248);
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

       
        private void passwordButton_Click(object sender, EventArgs e)
        {
            passwordButton.Image = Properties.Resources.handpointright; // Change to your second image
        }

        private void passwordButton_DoubleClick(object sender, EventArgs e)
        {
            passwordButton.Image = Properties.Resources.handgesture; // Change to your second image
        }

        private void nicknameButton_Click(object sender, EventArgs e)
        {
            nicknameButton.Image = Properties.Resources.facekisswinkhearticon; // Change to your image
            SoundPlayer nyaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\nya.wav");
            nyaSound.Play();
        }

        private void nicknameButton_DoubleClick(object sender, EventArgs e)
        {
            nicknameButton.Image = Properties.Resources.facekissicon;
            SoundPlayer nyaSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\nya.wav");
            nyaSound.Play();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
