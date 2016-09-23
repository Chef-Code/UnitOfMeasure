using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Pint : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(96,1), new Fraction(32,1), new Fraction(16,1), new Fraction(2,1), new Fraction(1,1), new Fraction(1,2), new Fraction(1,4), new Fraction(1,8)
        };
        public Pint()
        {
            this.BaseVolume = new Fraction(16,1);
            this.Index = 4;
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
