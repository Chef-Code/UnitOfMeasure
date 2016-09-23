using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Cup : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(48,1), new Fraction(16,1), new Fraction(8,1), new Fraction(1,1), new Fraction(1,2), new Fraction(1,4), new Fraction(1,8), new Fraction(1,16)
        };
        public Cup()
        {
            this.BaseVolume = new Fraction(8,1);
            this.Index = 3;
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
