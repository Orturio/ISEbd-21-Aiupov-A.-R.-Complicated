using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    class AerodromeNotFoundException : Exception
    {
        public AerodromeNotFoundException(int i) : base("Не найден самолёт по месту " + i)
        { }
    }
}
