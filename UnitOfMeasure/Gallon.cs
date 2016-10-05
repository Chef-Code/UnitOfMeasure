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
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("Gallon",1000000d, "CubicCentimeter",3785411784d),
            new ConvertToUnit("Gallon",100000000000000000d, "CubicFoot",13368055551778848d),
            new ConvertToUnit("Gallon",10000000000000d, "CubicInch",2309999999347385d),
            new ConvertToUnit("Gallon",1000000000000d, "CubicMeter",3785411784d),
            new ConvertToUnit("Gallon",1000d, "Cup",16d),
            new ConvertToUnit("Gallon",1d, "FluidOunce",128d),
            new ConvertToUnit("Gallon",1d, "Gallon",1d),
            new ConvertToUnit("Gallon",1000000d, "Gram",3785411784d),
            new ConvertToUnit("Gallon",1d, "HalfGallon",2d),
            new ConvertToUnit("Gallon",1000000000d, "KiloGram",3785411784d),
            new ConvertToUnit("Gallon",1000000000d, "Liter",3785411784d),
            new ConvertToUnit("Gallon",1000d, "MilliGram",3785411784d),
            new ConvertToUnit("Gallon",1000000d, "MilliLiter",3785411784d),
            new ConvertToUnit("Gallon",10000000000000d, "Ounce",1335264712323093d),
            new ConvertToUnit("Gallon",1d, "Pint",8d),
            new ConvertToUnit("Gallon",1000000000000000d, "Pound",8345404452019331d),
            new ConvertToUnit("Gallon",1d, "Quart",4d),
            new ConvertToUnit("Gallon",1d, "Tablespoon",256d),
            new ConvertToUnit("Gallon",1d, "Teaspoon",768d)
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
