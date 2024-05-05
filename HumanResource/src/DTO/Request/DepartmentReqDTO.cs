﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.src.DTO.Request
{
    internal class DepartmentReqDTO
    {
        private int depId;
        private string depDesc;
        private string depType;
        private string depPlace;
        public DepartmentReqDTO() { }
   
        public int DepId
        {
            get { return depId; }
            set { depId = value; }
        }

        public string DepDesc
        {
            get { return depDesc; }
            set { depDesc = value; }
        }

        public string DepType
        {
            get { return depType; }
            set { depType = value; }
        }

        public string DepPlace
        {
            get { return depPlace; }
            set { depPlace = value; }
        }
    }
}