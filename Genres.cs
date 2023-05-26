using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsovaya_Ivan
{
    internal class GenresClass
    {
        public static List<string> GetGenres()
        {
            List<string> genres = new List<string>()
            {
                "Фантастика",
                "Роман",
                "Детектив",
                "Фэнтези",
                "Ужасы"
            };

            return genres;
        }
    }
}
