using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Quart : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(192,1), new Fraction(64,1), new Fraction(32,1), new Fraction(4,1), new Fraction(2,1), new Fraction(1,1), new Fraction(1,2), new Fraction(1,4)
        };
        public Quart()
        {
            this.BaseVolume = new Fraction(32,1);
            this.Index = 5;
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
