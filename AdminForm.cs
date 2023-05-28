﻿using System;
using System.Windows.Forms;
using System.IO;

namespace Kyrsovaya_Ivan
{
    public partial class AdminForm : Form
    {
        static internal Files file = new Files();
        static internal string Item;

        public AdminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            //RefreshList();
            if (File.Exists("Books.txt"))
            {
                file.ReadFromFile("Books.txt");
                RefreshList();
            }
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
            try
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    Books selectedBook = new Books();
                    selectedBook.BookName = selectedItem.SubItems[0].Text;
                    selectedBook.Genre = selectedItem.SubItems[1].Text;
                    selectedBook.Author = selectedItem.SubItems[2].Text;
                    selectedBook.YearOfPublish = selectedItem.SubItems[3].Text;
                    selectedBook.Price = Convert.ToInt32(selectedItem.SubItems[4].Text);
                    selectedBook.Presence = selectedItem.SubItems[5].Text;
                    foreach (Books row in Form1.list)
                    {
                        if (row.BookName == selectedBook.BookName && row.Author == selectedBook.Author && row.YearOfPublish == selectedBook.YearOfPublish)
                        {
                            int index = Form1.list.IndexOf(row);
                            Form1.list.RemoveAt(index);
                            break;
                        }
                    }
                }
                file.WriteToFile("Books.txt", Form1.list);
                file.ReadFromFile("Books.txt");
                RefreshList();
                MessageBox.Show("Книга удалена!");
            }
            catch { }          
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item = listView1.FocusedItem.Text;
                EditForm edit = new EditForm();
                edit.Show();
                this.Hide();
            }
            catch { }
        }
    }
}
