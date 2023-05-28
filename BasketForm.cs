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
        public List<Books> selectedBooks;

        public BasketForm(List<Books> selectedBooks)
        {
            InitializeComponent();
            this.selectedBooks = selectedBooks;
            RefreshBasketList();
        }

        public void RefreshBasketList()
        {
            listViewBasket.Items.Clear();
            foreach (Books book in selectedBooks)
            {
                listViewBasket.Items.Add(book.ToListItem());
            }
        }
    }
}
