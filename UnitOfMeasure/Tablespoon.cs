using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Tablespoon : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(3,1), new Fraction(1,1), new Fraction(1,2), new Fraction(1,16), new Fraction(1,32), new Fraction(1,64), new Fraction(1,128), new Fraction(1,256)
        };
        public Tablespoon()
        {
            this.BaseVolume = new Fraction(1,2);
            this.Index = 1;
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
