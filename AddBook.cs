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
            book.Genre = comboBox2.Text; //Жанры. Надо допилить класс
            book.Author = Author.Text;
            book.YearOfPublish = YearOfPublish.Text;
            book.Price = Price.Text;
            book.Presence = comboBox1.Text;//Наличие книги. Надо добавить
            Form1.list.Add(book);
            this.Close();

            AdminForm add = new AdminForm();
            add.Show();
            
        }
    }
}
