using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya_Ivan
{
    public partial class Form1 : Form
    {
        //ПОЛЯ ЛОГИНА И ПАРОЛЯ
        public string login = "ivan123";
        public string password = "1234";

        static internal GuestForm guest = new GuestForm();

        static internal List<Books> list = new List<Books>();


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.DarkGray;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) => Application.Exit();//принудительное закрытие всех форм после нажатия на крестик
        }


        //КНОПКА ВЫЗОВА ФОРМЫ АДМИНА
        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            if (login_textBox.Text == login && password_textBox.Text == password)
            {
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправельный Логин или Пароль!");
            }
        }

        // ОБРАБОТЧИК НАЖАТИЯ НА LABEL_3
        private void label3_Click(object sender, EventArgs e)
        {
            guest.Show();
            this.Hide();
        }

        //2 МЕТОДА СОСТОЯНИЯ LABEL_3
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            // Изменение стиля при наведении курсора
            guestLogin.BackColor = Color.FromArgb(75, 95, 95);
            guestLogin.BorderStyle = BorderStyle.FixedSingle;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            // Изменение стиля при покидании курсора
            guestLogin.BackColor = Color.Transparent;
            guestLogin.BorderStyle = BorderStyle.None;
        }


        // ЧЕКБОКС ДЛЯ ОТОБРАЖЕНИЯ ПАРОЛЯ В СТРОКЕ ПАРОЛЯ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_textBox.PasswordChar = '\0'; // Показать пароль
            }
            else
            {
                password_textBox.PasswordChar = '*'; // Скрыть пароль звездочками
            }
        }

        // СКРЫТИЕ ТЕКСТА ПОЛЯ ПО УМОЛЧАНИЮ
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)// проверка на активность чек бокса
            {
                password_textBox.PasswordChar = '*'; // Скрыть пароль звездочками
            }
        }
    }
}
