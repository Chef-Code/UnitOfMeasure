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

        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("Cup",10000000d, "CubicCentimeter",2365882365d),
            new ConvertToUnit("Cup",10000000000000d, "CubicMeter",2365882365d),
            new ConvertToUnit("Cup",10000000000000d, "CubicFoot",835503471986178d),
            new ConvertToUnit("Cup",1000000000000000d, "CubicInch",14437499995921156d),
            new ConvertToUnit("Cup",1d, "Cup",1d),
            new ConvertToUnit("Cup",1d, "FluidOunce",8d),
            new ConvertToUnit("Cup",10000d, "Gallon",625d),
            new ConvertToUnit("Cup",10000000d, "Gram",2365882365d),
            new ConvertToUnit("Cup",10000d, "HalfGallon",1250d),
            new ConvertToUnit("Cup",10000000000d, "KiloGram",2365882365d),
            new ConvertToUnit("Cup",10000000000d, "Liter",2365882365d),
            new ConvertToUnit("Cup",10000d, "MilliGram",2365882365d),
            new ConvertToUnit("Cup",10000000d, "MilliLiter",2365882365d),
            new ConvertToUnit("Cup",10000000d, "Ounce",2365882365d),
            new ConvertToUnit("Cup",10d, "Pint",5d),
            new ConvertToUnit("Cup",10000000000000000d, "Pound",5215877782512082d),
            new ConvertToUnit("Cup",100d, "Quart",25d),
            new ConvertToUnit("Cup",1d, "Tablespoon",16d),
            new ConvertToUnit("Cup",1d, "Teaspoon",48d),
        };

        public Cup()
        {
            this.BaseVolume = new Fraction(8,1);
            this.Index = 3;
            this.Quantity = 1;
        }

        public Cup(double quantity)  //add this same constructor to all Units
        {
            this.BaseVolume = new Fraction(8, 1);
            this.Index = 3;
            this.Quantity = quantity;
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
