using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
