using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Teaspoon : Unit
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("Teaspoon",100000000000d, "CubicCentimeter",492892159375d),
            new ConvertToUnit("Teaspoon",100000000000000000000d, "CubicFoot",17406322333045376d),
            new ConvertToUnit("Teaspoon",10000000000000000d, "CubicInch",3007812499150241d),
            new ConvertToUnit("Teaspoon",100000000000000000d, "CubicMeter",492892159375d),
            new ConvertToUnit("Teaspoon",1000000000000000000d, "Cup",20833333333333336d),
            new ConvertToUnit("Teaspoon",100000000000000000d, "FluidOunce",16666666666666668d),
            new ConvertToUnit("Teaspoon",10000000000000000000d, "Gallon",13020833333333334d),
            new ConvertToUnit("Teaspoon",100000000000d, "Gram",492892159375d),
            new ConvertToUnit("Teaspoon",10000000000000000000d, "HalfGallon",6510416666666667d),
            new ConvertToUnit("Teaspoon",100000000000000d, "KiloGram",492892159375d),
            new ConvertToUnit("Teaspoon",100000000000000d, "Liter",492892159375d),
            new ConvertToUnit("Teaspoon",100000000d, "MilliGram",492892159375d),
            new ConvertToUnit("Teaspoon",100000000000d, "MilliLiter",492892159375d),
            new ConvertToUnit("Teaspoon",100000000000000000d, "Ounce",17386259275040274d),
            new ConvertToUnit("Teaspoon",1000000000000000000d, "Pint",10416666666666668d),
            new ConvertToUnit("Teaspoon",1000000000000000000d, "Pound",10866412046900172d),
            new ConvertToUnit("Teaspoon",1000000000000000000d, "Quart",5208333333333334d),
            new ConvertToUnit("Teaspoon",3d, "Tablespoon",1d),
            new ConvertToUnit("Teaspoon",1d, "Teaspoon",1d)
        };
        public Teaspoon()
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
        }
        public Teaspoon(double quantity)  
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
            this.Quantity = quantity;
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
