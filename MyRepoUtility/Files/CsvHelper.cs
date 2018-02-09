using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyRepoUtility
{

    public class CsvHelper
    {
        //The library can also write

        /// <summary>
        /// Converts raw csv to List<typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rawString"></param>
        /// <returns></returns>
        public List<T> ReadCsv<T>(string rawString)
        {
            using (TextReader tr = new StringReader(rawString))
            {
                var csv = new CsvReader(tr);
                var someList = csv.GetRecords<T>().ToList();
                return someList;
            }            
        }
    }
}
