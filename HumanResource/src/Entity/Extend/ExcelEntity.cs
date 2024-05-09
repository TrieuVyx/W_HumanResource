using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace HumanResource.src.Entity.Extend
{
    internal class ExcelEntity
    {
        private readonly Excel.Workbook _workbook;
        private readonly Excel.Worksheet _worksheet;
        private readonly Excel.Application _application;
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

            // Lưu workbook vào tệp Excel
            _workbook.SaveAs(filePath);

            // Đóng workbook và ứng dụng Excel
            _workbook.Close();
            _application.Quit();
        }
    }
}
