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
        internal int YearOfPublish = 0;
        internal int Price = 0;
        internal string Presence = "";
        internal List<string[]> BookList = new List<string[]>();
        internal List<string[]> PresenceList = new List<string[]>();
        

        internal ListViewItem ToListItem()
        {
            return new ListViewItem(new string[] { BookName, Genre, Author, Convert.ToString(YearOfPublish), Convert.ToString(Price), Presence});
        }

    }
}
