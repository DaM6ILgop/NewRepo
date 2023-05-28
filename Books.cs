using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya_Ivan
{
    class Books
    {
        internal string BookName = "";
        internal string Genre = "";
        internal string Author = "";
        internal string YearOfPublish = " ";
        internal int Price = 0;
        internal string Presence = "";
        

        internal ListViewItem ToListItem()
        {
            return new ListViewItem(new string[] { BookName, Genre, Author, YearOfPublish, Convert.ToString(Price), Presence});
        }

        

    }
}
