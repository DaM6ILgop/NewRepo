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
        static internal List<Books> selectedBooks = new List<Books>();

        

        public BasketForm()
        {
            InitializeComponent();
        }

        public void RefreshBasketList()
        {
            listViewBasket.Items.Clear();
            foreach (Books book in selectedBooks)
            {
                listViewBasket.Items.Add(book.ToListItem());
            }
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            /*this.FormClosed += (sender, e) => Application.Exit();*/
        }

        private void Return_bttn_Click(object sender, EventArgs e)
        {
            Form1.guest.Show();
            this.Hide();
        }
    }
}
