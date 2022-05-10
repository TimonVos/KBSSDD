using System;
using docx = Microsoft.Office.Interop.Word;
using System.Data;


namespace WordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new System.Data.DataTable("Analyseren");

            DataColumn nietVoldaan, voldoende, goed, excellent;
            #region Colums
            nietVoldaan = new DataColumn("Niet Voldaan");
            nietVoldaan.AutoIncrement = false;
            nietVoldaan.DataType = typeof(bool);
            nietVoldaan.ReadOnly = false;
            nietVoldaan.Unique = false;
            table.Columns.Add(nietVoldaan);

            voldoende = new DataColumn("Voldoende");
            voldoende.AutoIncrement = false;
            voldoende.DataType = typeof(bool);
            voldoende.ReadOnly = false;
            voldoende.Unique = false;
            table.Columns.Add(voldoende);

            goed = new DataColumn("Goed");
            goed.AutoIncrement = false;
            goed.DataType = typeof(bool);
            goed.ReadOnly = false;
            goed.Unique = false;
            table.Columns.Add(goed);

            excellent = new DataColumn("Excellent");
            excellent.AutoIncrement = false;
            excellent.DataType = typeof(bool);
            excellent.ReadOnly = false;
            excellent.Unique = false;
            table.Columns.Add(excellent);
            #endregion
            DataRow aanpak, initiatief, keuzesMaken, effectiviteit, zelfkritisch;
            #region Rows
            aanpak = table.NewRow();
            initiatief = table.NewRow();
            keuzesMaken = table.NewRow();
            effectiviteit = table.NewRow();
            zelfkritisch = table.NewRow();
            #endregion
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);


            docx.Application wordapp = new docx.Application();
            wordapp.Visible = true;
            docx.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref wordobj);
            wordapp.Selection.TypeText("dit is een test tekst om te kijken of interop werkt");
            wordapp = null;
        }
    }
}
