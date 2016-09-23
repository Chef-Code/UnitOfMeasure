using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class HalfGallon : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(384,1), new Fraction(128,1), new Fraction(64,1), new Fraction(8,1), new Fraction(4,1), new Fraction(2,1), new Fraction(1,1), new Fraction(1,2)
        };
        public HalfGallon()
        {
            this.BaseVolume = new Fraction(64,1);
            this.Index = 6;
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
