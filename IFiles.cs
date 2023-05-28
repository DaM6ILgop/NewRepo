using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsovaya_Ivan
{
    public interface IFiles
    {
        void WriteToFile(string filename, List<Books> list);
        void ReadFromFile(string filename);
    }
}
