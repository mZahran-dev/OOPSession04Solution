﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.IShape
{
    internal interface IShape
    {
        public double Area {  get; }
        public void DisplayShapeInfo();
    }
}
