using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Pound : Unit        //TODO:  FIX THIS
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(16,1), new Fraction(1,1) 
        };
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] { };
        public Pound()
        {
            this.BaseVolume = new Fraction(16, 1);  // <------Implement BaseWeight  this will need to be where I start... BaseVolume will need to be "abstracted out" along with BaseWeight
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
        public override ConvertToUnit[] ConvertToUnits
        {
            get
            {
                return _convertToUnits;
            }
        }
        public override ConvertToUnit this[string become]
        {
            get
            {
                return _convertToUnits.SingleOrDefault(ctu => ctu.Become == become);
            }
        }
    }
}
