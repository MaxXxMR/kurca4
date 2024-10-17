using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Media;


namespace kurca4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SoundPlayer fnaf1Sound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\fnaf1.wav");
            fnaf1Sound.Play();
            nameField.Text = "Введите логин";
            nameField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passField.PasswordChar = '*';
            // Устанавливаем символ для скрытия пароля (например, '*')
            /*SoundPlayer startSound = new SoundPlayer(@"C:\Users\Hp\source\repos\kurca4\kurca4\sounds\roundstart.wav");
            startSound.Play();*/
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
        private void LoginForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private async void enterButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            String loginUser = nameField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Отправка сообщения через Telegram бот
                await TGBOT.SendMessageAsync("id", "Вы успешно вошли в систему");
            }
            else
            {
                MessageBox.Show("Нет такого аккаунта, зарегистрируйтесь");

                // Отправка сообщения через Telegram бот
                await TGBOT.SendMessageAsync("id", "Нет такого аккаунта, зарегистрируйтесь");
            }
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

  

        private void passwordButton_Click(object sender, EventArgs e)
        {
            passwordButton.Image = Properties.Resources.handpointright; // Change to your second image
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.BackColor = Color.FromArgb(198, 230, 245);
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.BackColor = Color.FromArgb(218, 239, 248);
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

        private void passwordButton_DoubleClick(object sender, EventArgs e)
        {
            passwordButton.Image = Properties.Resources.handgesture; // Change to your second image
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
