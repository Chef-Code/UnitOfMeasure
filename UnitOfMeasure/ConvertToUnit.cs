using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class ConvertToUnit
    {
        public ConvertToUnit()
        {

        }
        public ConvertToUnit(Unit from, Unit become)  //currently DOES NOT WORK, in an Init() private variable of a class
        {
            From = from.Name;
            FromQuantity = from.Quantity;
            Become = become.Name;
            BecomeQuantity = become.Quantity;
            EquivalentRatio = new Fraction(FromQuantity, BecomeQuantity);
        }
        public ConvertToUnit(string from,double fromQuantity, string become, double becomeQuantity)  //this works!!
        {
            From = from;
            FromQuantity = fromQuantity;
            Become = become;
            BecomeQuantity = becomeQuantity;
            EquivalentRatio = new Fraction(BecomeQuantity, FromQuantity);
        }

        public string From { get; set; }
        public double FromQuantity { get; set; }
        public string Become { get; set; }
        public double BecomeQuantity { get; set; }
        public Fraction EquivalentRatio { get; set; }
    }
}
