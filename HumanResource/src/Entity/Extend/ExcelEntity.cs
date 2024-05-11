using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace HumanResource.src.Entity.Extend
{
    internal class ExcelEntity
    {
        private  Excel.Workbook _workbook;
        private  Excel.Worksheet _worksheet;
        private  Excel.Application _application;
        public ExcelEntity()
        {
            _application = new Excel.Application();
            _workbook = _application.Workbooks.Add();
            _worksheet = (Excel.Worksheet)_workbook.ActiveSheet;
        }

        internal void ExportDataTableToExcel(DataTable dataTable, string filePath, List<string> visibleColumns)
        {
            // Ghi tiêu đề cột
            int columnIndex = 1;
            foreach (var columnName in visibleColumns)
            {
                _worksheet.Cells[1, columnIndex] = columnName;
                columnIndex++;
            }

            // Ghi dữ liệu từ DataTable vào các ô
            int rowIndex = 2;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    columnIndex = 1;
                    foreach (var columnName in visibleColumns)
                    {
                        _worksheet.Cells[rowIndex, columnIndex] = row[columnName];
                        columnIndex++;
                    }
                    rowIndex++;
                }
            }

            _workbook.SaveAs(filePath);
            _workbook.Close(false);
            _application.Quit();

            Marshal.ReleaseComObject(_worksheet);
            Marshal.ReleaseComObject(_workbook);
            Marshal.ReleaseComObject(_application);
            _worksheet = null;
            _workbook = null;
            _application = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}
