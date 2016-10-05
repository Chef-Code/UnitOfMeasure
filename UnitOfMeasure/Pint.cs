using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Pint : Unit
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(96,1), new Fraction(32,1), new Fraction(16,1), new Fraction(2,1), new Fraction(1,1), new Fraction(1,2), new Fraction(1,4), new Fraction(1,8)
        };
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("Pint",1000000d, "CubicCentimeter",473176473d),
            new ConvertToUnit("Pint",100000000000000000d, "CubicFoot",1671006943972356d),
            new ConvertToUnit("Pint",1000000000000000d, "CubicInch",28874999991842310d),
            new ConvertToUnit("Pint",1000000000000d, "CubicMeter",473176473d),
            new ConvertToUnit("Pint",1d, "Cup",2d),
            new ConvertToUnit("Pint",1d, "FluidOunce",16d),
            new ConvertToUnit("Pint",1000d, "Gallon",125d),
            new ConvertToUnit("Pint",1000000d, "Gram",473176473d),
            new ConvertToUnit("Pint",1000d, "HalfGallon",250d),
            new ConvertToUnit("Pint",1000000000d, "KiloGram",473176473d),
            new ConvertToUnit("Pint",1000000000d, "Liter",473176473d),
            new ConvertToUnit("Pint",1000d, "MilliGram",473176473d),
            new ConvertToUnit("Pint",1000000d, "MilliLiter",473176473d),
            new ConvertToUnit("Pint",1000000000000000d, "Ounce",16690808904038662d),
            new ConvertToUnit("Pint",1d, "Pint",1d),
            new ConvertToUnit("Pint",10000000000000000d, "Pound",10431755565024164d),
            new ConvertToUnit("Pint",10d, "Quart",5d),
            new ConvertToUnit("Pint",1d, "Tablespoon",32d),
            new ConvertToUnit("Pint",1d, "Teaspoon",96d)
        };
        public Pint()
        {
            this.BaseVolume = new Fraction(16,1);
            this.Index = 4;
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
