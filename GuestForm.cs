using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Kyrsovaya_Ivan
{
    public partial class GuestForm : Form
    {
        static internal Files file = new Files();
        static internal List<Books> selectedBooks = new List<Books>();
        public GuestForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox1.KeyPress += (sender, e) => e.Handled = true;

        }

        private void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Books s in Form1.list)
            {
                listView1.Items.Add(s.ToListItem());
            }
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {


            this.FormClosed += (sender, e) => Application.Exit();//полезно для закрытия exe файла из диспетчера задач. Работает при закрытии формы на крестик

            List<string> genres = GenresClass.GetGenres();
            comboBox1.Items.AddRange(genres.ToArray());

            //RefreshList();
            if (File.Exists("Books.txt"))
            {
                file.ReadFromFile("Books.txt");
                RefreshList();
            }
            this.FormClosed += (sender, e) => Application.Exit();
        }


        private void GuestForm_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            BasketForm basket = new BasketForm();
            basket.Show();
            this.Hide();
        }

        //СОРТИРОВКА ПО ЖАНРУ
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = comboBox1.SelectedItem.ToString();
            listView1.Items.Clear();
            foreach (Books book in Form1.list)
            {
                if (selectedGenre == "Все" || book.Genre == selectedGenre)
                {
                    listView1.Items.Add(book.ToListItem());
                }
            }
        }
        //СОРТИРОВКА ПО НАЛИЧИЮ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            bool isAvailable = checkBox1.Checked;
            listView1.Items.Clear();
            foreach (Books book in Form1.list)
            {
                if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "Все" || book.Genre == comboBox1.SelectedItem.ToString())
                {
                    if (isAvailable && book.Presence == "Да")
                    {
                        listView1.Items.Add(book.ToListItem());
                    }
                    else if (!isAvailable)
                    {
                        listView1.Items.Add(book.ToListItem());
                    }
                }
            }
        }

        private void buttonChooseBasket_Click(object sender, EventArgs e)
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
                selectedBooks.Add(selectedBook);
            }
            MessageBox.Show("Книга добавлена в корзину!");
        }

        static internal Form1 form = new Form1();

        private void returnBttn_Click(object sender, EventArgs e)
        {          
            form.Show();
            this.Hide();
        }
    }
}
