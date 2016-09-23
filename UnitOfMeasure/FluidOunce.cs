using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class FluidOunce : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(6,1), new Fraction(2,1), new Fraction(1,1), new Fraction(1,8), new Fraction(1,16), new Fraction(1,32), new Fraction(1,64), new Fraction(1,128)
        };
        public FluidOunce()
        {
            this.BaseVolume = new Fraction(1,1);
            this.Index = 2;
        }
        public override Fraction[] ConversionFactors  
        {
            get { return _CF; }
        }
        public override Fraction this[int index]
        {
            get
            {
                return _CF[index];
            }
        }
    }
}
