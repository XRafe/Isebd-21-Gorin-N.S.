﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Var5
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На пристани нет свободных мест")
        { }
    }

}
