using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Projekt
{
    internal class WriteToFile
    {
        internal string Result {  get; private set; }
        internal WriteToFile (string result)
        {
            Result = result;

            string path = "../../../logFile.txt";
            using StreamWriter sw = File.AppendText (path);
            sw.WriteLine (DateTime.Now +"\n" + result + "\n");
        }
    }
}
