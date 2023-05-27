using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya_Ivan
{
    public partial class GuestForm : Form
    {
        static internal Files file = new Files();

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
            List<string> genres = GenresClass.GetGenres();
            comboBox1.Items.AddRange(genres.ToArray());

            //RefreshList();
            if (File.Exists("Books.txt"))
            {
                file.ReadFromFile("Books.txt");
                RefreshList();
            }
            this.FormClosed += (sender, e) => Application.Exit();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //for(int i = 0; i > genres.ToArray().Length; i++) 
            //{
            //    comboBox1.Items.Add(((string)genres[i]));
            //}
        }
    }
}
