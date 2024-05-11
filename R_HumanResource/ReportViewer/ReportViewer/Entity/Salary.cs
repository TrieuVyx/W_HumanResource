﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewer.Entity
{
    internal class Salary
    {
        private int salaryId;
        private int salaryAmount;
        private string salaryDesc;

        public int SalaryId
        {
            get { return salaryId; }
            set { salaryId = value; }
        }

        public int SalaryAmount
        {
            get { return salaryAmount; }
            set { salaryAmount = value; }
        }

        public string SalaryDesc
        {
            get { return salaryDesc; }
            set { salaryDesc = value; }
        }
    }
}
