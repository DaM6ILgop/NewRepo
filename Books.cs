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
        internal string YearOfPublish = "";
        internal string Price = "";
        internal string Presence = "";

        internal ListViewItem ToListItem()
        {
            return new ListViewItem(new string[] { BookName, Genre, Author, YearOfPublish, Price, Presence});
        }

    }
}
