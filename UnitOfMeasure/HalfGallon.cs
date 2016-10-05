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
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("HalfGallon",1000000d, "CubicCentimeter",1892705892d),
            new ConvertToUnit("HalfGallon",100000000000000000d, "CubicFoot",6684027775889424d),
            new ConvertToUnit("HalfGallon",100000000000000d, "CubicInch",11549999996736925d),
            new ConvertToUnit("HalfGallon",1000000000000d, "CubicMeter",1892705892d),
            new ConvertToUnit("HalfGallon",1000d, "Cup",8d),
            new ConvertToUnit("HalfGallon",1d, "FluidOunce",64d),
            new ConvertToUnit("HalfGallon",10d, "Gallon",5d),
            new ConvertToUnit("HalfGallon",1000000d, "Gram",1892705892d),
            new ConvertToUnit("HalfGallon",1d, "HalfGallon",1d),
            new ConvertToUnit("HalfGallon",1000000000d, "KiloGram",1892705892d),
            new ConvertToUnit("HalfGallon",1000000000d, "Liter",1892705892d),
            new ConvertToUnit("HalfGallon",1000d, "MilliGram",1892705892d),
            new ConvertToUnit("HalfGallon",1000000d, "MilliLiter",1892705892d),
            new ConvertToUnit("HalfGallon",100000000000000d, "Ounce",6676323561615465d),
            new ConvertToUnit("HalfGallon",1d, "Pint",4d),
            new ConvertToUnit("HalfGallon",10000000000000000d, "Pound",41727022260096655d),
            new ConvertToUnit("HalfGallon",1d, "Quart",2d),
            new ConvertToUnit("HalfGallon",1d, "Tablespoon",128d),
            new ConvertToUnit("HalfGallon",1d, "Teaspoon",384d)
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
