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
    public partial class GuestForm : Form
    {
        

        public GuestForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        }

        private void GuestForm_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();
            basketForm.Show();
        }
    }
}
