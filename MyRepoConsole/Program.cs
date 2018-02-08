using MyRepoDomain;
using System;

namespace MyRepoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestCsv();
            }
            catch (global::System.Exception e)
            {
                Console.WriteLine(e.ToString());              
            }
            finally
            {
                Console.ReadLine();
            }
        } 
        
        public static void TestCsv()
        {
            //physic route of the file in disc
            var pathFile = @"C:\Users\Ruben\Desktop\CUEcsv.csv";
            var rawString = System.IO.File.ReadAllText(pathFile);
            var csvHelper = new MyRepoUtility.CsvHelper();
            var result = csvHelper.ReadCsv<CsvTestE>(rawString);
            foreach (var item in result)
            {
                Console.WriteLine(string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}",
                    item.MyProperty,
                    item.MyProperty1,
                    item.MyProperty2,
                    item.MyProperty3,
                    item.MyProperty4,
                    item.MyProperty5,
                    item.MyProperty6));
            }
        }
    }
}
