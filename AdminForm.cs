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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Books s in Form1.list)
            {
                listView1.Items.Add(s.ToListItem());
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }
    }
}
