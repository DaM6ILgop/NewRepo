using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kyrsovaya_Ivan
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AdminRefrestList_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.BookName = BookName.Text;
            book.Genre = Genre.Text; //Жанры. Надо допилить класс
            book.Author = Author.Text;
            book.YearOfPublish = YearOfPublish.Text;
            book.Price = Price.Text;
            book.Presence = comboBox1.Text;//Наличие книги. Надо добавить
            Form1.list.Add(book);
            Form1.adminForm.RefreshList();
            Form1.adminForm.Show();
            this.Close();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            List<string> genres = GenresClass.GetGenres();
            Genre.Items.AddRange(genres.ToArray());
        }
    }
}
