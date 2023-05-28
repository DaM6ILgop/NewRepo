using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsovaya_Ivan
{
    public class Files : IFiles
    {
        internal Convertor con = new Convertor();
        public void ReadFromFile(string filename)
        {
            List<string[]> TempList = new List<string[]>();
            string FilePath = Directory.GetCurrentDirectory() +"\\"+filename;
            Form1.list.Clear();
            using (StreamReader streamreader = new StreamReader(File.Open(FilePath, FileMode.Open)))
            {
                while (streamreader.Peek() > -1)
                {
                    TempList.Add(streamreader.ReadLine().Split(" , "));
                }
            }
            con.convert(TempList);
        }

        public void WriteToFile(string filename, List<Books> list)
        {
            string FilePath = Directory.GetCurrentDirectory() + "\\" + filename;
            using (StreamWriter streamwriter = new StreamWriter(FilePath, false))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string writeStr = list[i].BookName + " , " + list[i].Genre + " , " + list[i].Author + " , " + list[i].YearOfPublish+ " , " + list[i].Price + " , " + list[i].Presence;
                    streamwriter.WriteLine(writeStr);
                }
            }
        }
    }
}
