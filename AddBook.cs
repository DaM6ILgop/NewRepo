using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kyrsovaya_Ivan
{
    public partial class AddBook : Form
    {
        internal Files file = new Files();

        public AddBook()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            Genre.KeyPress += (sender, e) => e.Handled = true;
        }

        private void AdminRefrestList_Click(object sender, EventArgs e)
        {
           
            Books book = new Books();
            book.BookName = BookName.Text;
            book.Genre = Genre.Text;
            book.Author = Author.Text;
            int yearOfPublish;
            if (int.TryParse(YearOfPublish.Text, out yearOfPublish))
            {
                book.YearOfPublish = yearOfPublish;
            }
            else
            {
                // Обработка некорректного ввода для года издания
                MessageBox.Show("Некорректный ввод года издания!");
                return;
            }
            int price;
            if (int.TryParse(Price.Text, out price))
            {
                book.Price = price;
            }
            else
            {
                // Обработка некорректного ввода для цены
                MessageBox.Show("Некорректный ввод цены!");
                return;
            }
            string presence = comboBox1.Text;
            if (comboBox1.Items.Contains(presence))
            {
                book.Presence = presence;
            }
            else
            {
                // Обработка некорректного ввода для наличия книги
                MessageBox.Show("Некорректный выбор наличия книги!");
                return;
            }
            Form1.list.Add(book);
            file.WriteToFile("Books.txt");
            file.ReadFromFile("Books.txt");
            Form1.adminForm.RefreshList();
            Form1.adminForm.Show();
            this.Close();

          

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            List<string> genres = GenresClass.GetGenres();
            Genre.Items.AddRange(genres.ToArray());
        }

        private void ReturnBttn_Click(object sender, EventArgs e)
        {
            Form1.adminForm.Show();
            this.Close();
        }
    }
}
