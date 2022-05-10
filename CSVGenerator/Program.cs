using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("CITY", typeof(string));

            //data  
            table.Rows.Add(111, "Devesh", "Ghaziabad");
            table.Rows.Add(222, "ROLI", "KANPUR");
            table.Rows.Add(102, "ROLI", "MAINPURI");
            table.Rows.Add(212, "DEVESH", "KANPUR");
            table.Rows.Add(102, "NIKHIL", "GZB");
            table.Rows.Add(212, "HIMANSHU", "NOIDa");
            table.Rows.Add(102, "AVINASH", "NOIDa");
            table.Rows.Add(212, "BHUPPI", "GZB");

            CSVUtility.ToCSV(table, "C:\\temp\\testcsv.csv");
        }
    }
}
