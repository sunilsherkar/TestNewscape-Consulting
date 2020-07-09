using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            ReadData data = new ReadData();
            data.ReadCsv();
            Console.WriteLine();
            Reports rpt = new Reports();
            DateTime date = DateTime.Now;
            rpt.getDailyReportByDate(date);
            rpt.getWeekyReport(date);
            //here we call all bank and account methods by rpt object
            Console.WriteLine("Press enter to close...");
            Console.ReadLine(); 
        } 
    }
    
    class ReadData
    {   
        public void ReadCsv()
        {    
            using (CsvReader csv =
                   new CsvReader(new StreamReader("Data.csv"), true))
            {
                int fieldCount = csv.FieldCount;

                string[] headers = csv.GetFieldHeaders();
                 
                for (int i = 0; i < fieldCount; i++)
                {
                    Console.Write(string.Format("{0};", headers[i]));
                    Console.Write("    |     ");
                }
                Console.WriteLine();
                while (csv.ReadNextRecord())
                {
                    for (int i = 0; i < fieldCount; i++)
                    { 
                        Console.Write(string.Format("{0};", csv[i]));
                        Console.Write("    |     ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    class Bank 
    { 
        public void GetbankDetails()
        {
            Console.WriteLine("return bank details");
        }
    }
    class UserAccount : Bank  
    {   
        public  AccountDetails getAccountDetailsbyID(int i)
        {
            AccountDetails obj = new AccountDetails();
            return obj;
        }
    }
    class Reports : AccountDetails
    {
        public void getDailyReportByDate(DateTime date)
        {
            Console.WriteLine("Daily report calling");
            // create daily reports with date filter 
        }
        public void getWeekyReport(DateTime date)
        {
            Console.WriteLine("Weekly report calling");
            // create daily reports with date filter 
        }
        public void getMonthlyReport(DateTime date)
        {
            Console.WriteLine("Monthly report calling");
            // create daily reports with date filter 
        }
    } 
}
