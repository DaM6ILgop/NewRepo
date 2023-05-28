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
    public partial class BasketForm : Form
    {
        internal Files file = new Files();
        public BasketForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void RefreshBasketList()
        {
            listViewBasket.Items.Clear();
            foreach (Books book in GuestForm.selectedBooks)
            {
                listViewBasket.Items.Add(book.ToListItem());
            }
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshBasketList();
            }
            catch { }
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem selectedItem in listViewBasket.SelectedItems)
                {
                    Books selectedBook = new Books();
                    selectedBook.BookName = selectedItem.SubItems[0].Text;
                    selectedBook.Genre = selectedItem.SubItems[1].Text;
                    selectedBook.Author = selectedItem.SubItems[2].Text;
                    selectedBook.YearOfPublish = selectedItem.SubItems[3].Text;
                    selectedBook.Price = Convert.ToInt32(selectedItem.SubItems[4].Text);
                    selectedBook.Presence = selectedItem.SubItems[5].Text;
                    foreach (Books row in GuestForm.selectedBooks)
                    {
                        if (row.BookName == selectedBook.BookName && row.Author == selectedBook.Author && row.YearOfPublish == selectedBook.YearOfPublish)
                        {
                            int index = GuestForm.selectedBooks.IndexOf(row);
                            GuestForm.selectedBooks.RemoveAt(index);
                            break;
                        }
                    }
                }
                RefreshBasketList();
                MessageBox.Show("Книга удалена!");
            }
            catch { }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            file.WriteToFile("Cheque.txt", GuestForm.selectedBooks);
            MessageBox.Show("Транзакция прошла!");
        }
    }
}
