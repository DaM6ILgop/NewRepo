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
    public partial class EditForm : Form
    {
        internal Files file = new Files();
        public EditForm()
        {
            InitializeComponent();
        }

        private void ReturnBttn_Click(object sender, EventArgs e)
        {
            Form1.adminForm.Show();
            this.Close();
        }

        private void AdminRefrestList_Click(object sender, EventArgs e)
        {
            try {
                foreach (Books row in Form1.list)
                {
                    if (row.BookName == AdminForm.Item)
                    {
                        int index = Form1.list.IndexOf(row);
                        Books book = new Books();
                        book.BookName = BookName.Text;
                        book.Genre = Genre.Text; //Жанры. Надо допилить класс
                        book.Author = Author.Text;
                        book.YearOfPublish = Convert.ToInt32(YearOfPublish.Text);
                        book.Price = Convert.ToInt32(Price.Text);
                        book.Presence = comboBox1.Text;//Наличие книги. Надо добавить 
                        Form1.list[index] = book;
                        break;
                    }
                }
                file.WriteToFile("Books.txt");
                file.ReadFromFile("Books.txt");
                Form1.adminForm.RefreshList();
                Form1.adminForm.Show();
                this.Close();
            } catch
            {

            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            List<string> genres = GenresClass.GetGenres();
            Genre.Items.AddRange(genres.ToArray());
        }
    }
}
