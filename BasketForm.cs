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
            this.selectedBooks = selectedBooks;
            RefreshBasketList();
        }

        public void RefreshBasketList()
        {
            listViewBasket.Items.Clear();
            foreach (Books book in GuestForm.selectedBooks)
            {
                listViewBasket.Items.Add(book.ToListItem());
            }
        }
    }
}
