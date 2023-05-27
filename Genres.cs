using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsovaya_Ivan
{
    internal class GenresClass
    {
        static internal List<string> genres = new List<string>()
        {
          "Фантастика",
          "Роман",
          "Детектив",
          "Фэнтези",
          "Ужасы"
        };
        public static List<string> GetGenres()
        {
            return genres;
        }

        public static void SetGenres(string genre)
        {
            genres.Add(genre);
        }
    }
}
