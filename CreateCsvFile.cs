using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToCSV
{
    class CreateCsvFile
    {
        string path = $"C:\\Users\\SF185122\\databases\\DataToCsv\\";

        public CreateCsvFile(List<List<string>> Data,string TableName)
        {
            using (StreamWriter SW = new StreamWriter(path + $"{TableName}-data.csv"))
            {
                foreach(List<string> EachRow in Data)
                {
                    for(int i=0;i<EachRow.Count - 1; i++)
                    {
                        SW.Write($"{EachRow[i]},");
                    }
                    SW.Write($"{EachRow[EachRow.Count - 1]}\n");
                }
            }
        }
    }
}
