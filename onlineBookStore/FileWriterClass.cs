using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class FileWriterClass
    {
        public static void WriteFile(string fileName,string text)
        {

            using (StreamWriter writeText = new StreamWriter(fileName,true))
            {
                    writeText.WriteLine(text);
            }
        }
    }
}
