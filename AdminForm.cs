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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) => Application.Exit();//полезно для закрытия exe файла из диспетчера задач. Работает при закрытии формы на крестик
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            
            Form1.list.Add(student);
        }
    }
}
