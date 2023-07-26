using System.Data;
using OfficeOpenXml;

namespace FirstWebMVC.Models.Process
{
    public class ExcelProcess
    {
        private object workSheet;

        public DataTable ExcelToDataTable (string strPath)
       {
        FileInfo f1 = new FileInfo (strPath);
        ExcelPackage excelPackage = new ExcelPackage(f1);
        DataTable dt= new DataTable();
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
        //check if the worksheet is comletely empty
        if(worksheet.Dimension == null)
        {
            return dt;
        }
        //Create a list to hold the columns name
        List<string> ColumnNames = new List<string>();
        //needed to keep track of empty columns headers
        int currentCollumn = 1 ;
        //loop all columns in the sheet and add them to the datatable
        foreach ( var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column] )
        {
            string columnName = cell.Text.Trim();
            //check if the previous header was empty and add it if it was 
            if (cell.Start.Column != currentCollumn)
            {
                ColumnNames.Add("Header_"+currentCollumn);
                dt.Columns.Add("Header_"+currentCollumn);
                currentCollumn++;
            }
            // add the column name to the list to count the duplicate
            ColumnNames.Add(columnName);
            int occurrences = ColumnNames.Count(x => x.Equals(columnName));
                if (occurrences > 1)
                {
                    columnName = columnName + "_" + occurrences;
                }
                
                dt.Columns.Add(columnName);
                currentCollumn++;
        }
        //start adding the contents of the excel file to the datatable
            for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
            {
            var row = worksheet.Cells[i, 1, i, worksheet.Dimension.End.Column];
            DataRow newRow = dt.NewRow();

            //loop all cells in the row
            foreach (var cell in row)
            {
                newRow[cell.Start.Column - 1] = cell.Text;
            }

            dt.Rows.Add(newRow);
            }
                return dt;
       }
    }
}