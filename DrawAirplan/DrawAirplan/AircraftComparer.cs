using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    public class AircraftComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Airbus && y is Airbus)
            {
                return ComparerAirbus((Airbus)x, (Airbus)y);
            }
            if (x is Airbus && y is Aircraft)
            {
                return -1;
            }
            if (x is Aircraft && y is Airbus)
            {
                return 1;
            }
            if (x is Aircraft && y is Aircraft)
            {
                return ComparerAircraft((Aircraft)x, (Aircraft)y);
            }
            return 0;
        }

        private int ComparerAircraft(Aircraft x, Aircraft y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerAirbus(Airbus x, Airbus y)
        {
            var res = ComparerAircraft(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.PortholeCount != y.PortholeCount)
            {
                return x.PortholeCount.CompareTo(y.PortholeCount);
            }
            if (x.PortholeForm != y.PortholeForm)
            {
                return x.PortholeForm.CompareTo(y.PortholeForm);
            }
            return 0;
        }

    }
}