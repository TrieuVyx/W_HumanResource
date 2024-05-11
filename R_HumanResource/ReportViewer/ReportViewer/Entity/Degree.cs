using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewer.Entity
{
    internal class Degree
    {
        private int degreeId;
        private string degreeName;

        public int DegreeId
        {
            get { return degreeId; }
            set { degreeId = value; }
        }

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
    }
}
