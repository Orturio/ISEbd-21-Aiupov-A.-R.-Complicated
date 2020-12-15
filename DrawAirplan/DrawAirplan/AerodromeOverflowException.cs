using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    class AerodromeOverflowException : Exception
    {
        public AerodromeOverflowException() : base("На аэродроме нет свободных мест")
        { }
    }
}
