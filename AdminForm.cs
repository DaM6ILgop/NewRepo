using System;
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
        private void DelItemList_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0) {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }

        }
    }
}
