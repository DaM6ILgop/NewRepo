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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //Метод обновления списка
        public void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Books s in Form1.list)
            {

                listView1.Items.Add(s.ToListItem());
            }
        }

        //Метод загрузки формы. Обновление списка срабатывает после запуска формы.
        //Тут же можно добавить вытягивание инфы в лист из текстового

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            this.FormClosed += (sender, e) => Application.Exit();
        }

        //Форма добавления книги
        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
            this.Hide();
        }

       
        //Кнопка открытия формы для удаления книги
        private void OpenDelForm_Click(object sender, EventArgs e)
        {

            

        }
    }
}
