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
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            Genre.KeyPress += (sender, e) => e.Handled = true;
        }

        private void ReturnBttn_Click(object sender, EventArgs e)
        {
            Form1.adminForm.Show();
            this.Close();
        }

        private void AdminRefrestList_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Books row in Form1.list)
                {
                    if (row.BookName == AdminForm.Item)
                    {
                        int index = Form1.list.IndexOf(row);
                        Books book = new Books();
                        book.BookName = BookName.Text;
                        book.Genre = Genre.Text;
                        book.Author = Author.Text;

                        if (int.TryParse(YearOfPublish.Text, out int yearOfPublish))
                        {
                            book.YearOfPublish = yearOfPublish;
                        }
                        else
                        {
                            // Обработка некорректного ввода года издания
                            MessageBox.Show("Некорректный ввод года издания!");
                            return;
                        }

                        if (int.TryParse(Price.Text, out int price))
                        {
                            book.Price = price;
                        }
                        else
                        {
                            // Обработка некорректного ввода цены
                            MessageBox.Show("Некорректный ввод цены!");
                            return;
                        }

                        book.Presence = comboBox1.Text;
                        Form1.list[index] = book;
                        break;
                    }
                }

                file.WriteToFile("Books.txt");
                file.ReadFromFile("Books.txt");
                Form1.adminForm.RefreshList();
                Form1.adminForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении книги: " + ex.Message);
            }

                        
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            List<string> genres = GenresClass.GetGenres();
            Genre.Items.AddRange(genres.ToArray());
        }
    }
}
