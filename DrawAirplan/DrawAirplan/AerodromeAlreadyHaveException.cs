﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    class AerodromeAlreadyHaveException : Exception
    {
        public AerodromeAlreadyHaveException() : base("На аэродроме уже есть такой самолёт")
        { }
    }
}
