using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsovaya_Ivan
{
    public class Convertor : IConvertor
    {
        public void convert(List<string[]> TempList)
        {
            foreach (string[] s in TempList)
            {
                Books book = new Books();
                book.BookName = s[0];
                book.Genre = s[1]; //Жанры. Надо допилить класс
                book.Author = s[2];
                book.YearOfPublish = s[3];
                book.Price = Convert.ToInt32(s[4]);
                book.Presence = s[5];//Наличие книги. Надо добавить
                Form1.list.Add(book);
            }
        }
    }
}
