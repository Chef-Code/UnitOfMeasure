using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Gallon : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(778,1), new Fraction(256,1), new Fraction(128,1), new Fraction(16,1), new Fraction(8,1), new Fraction(4,1), new Fraction(2,1), new Fraction(1,1)
        };
        public Gallon()
        {
            this.BaseVolume = new Fraction(128,1);
            this.Index = 7;
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
