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


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.DarkGray;
        }

        /*ты лох*/

/**/



        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) => Application.Exit();//принудительное закрытие всех форм после нажатия на крестик
        }


        //КНОПКА ВЫЗОВА ФОРМЫ АДМИНА
        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            if (textBox1.Text == login && textBox2.Text == password)
            {
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введенный логин или пароль неверны.\nПопробуйте еще раз!");
            }
        }

        // ОБРАБОТЧИК НАЖАТИЯ НА LABEL_3
        private void label3_Click(object sender, EventArgs e)
        {
            GuestForm guest = new GuestForm();
            guest.Show();
            this.Hide();
        }

        //2 МЕТОДА СОСТОЯНИЯ LABEL_3
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            // Изменение стиля при наведении курсора
            label3.BackColor = Color.FromArgb(75, 95, 95);
            label3.BorderStyle = BorderStyle.FixedSingle;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            // Изменение стиля при покидании курсора
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.None;
        }


        // ЧЕКБОКС ДЛЯ ОТОБРАЖЕНИЯ ПАРОЛЯ В СТРОКЕ ПАРОЛЯ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Показать пароль
            }
            else
            {
                textBox2.PasswordChar = '*'; // Скрыть пароль звездочками
            }
        }

        // СКРЫТИЕ ТЕКСТА ПОЛЯ ПО УМОЛЧАНИЮ
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)// проверка на активность чек бокса
            {
                textBox2.PasswordChar = '*'; // Скрыть пароль звездочками
            }
        }
    }
}
