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
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("Quart",1000000d, "CubicCentimeter",946352946d),
            new ConvertToUnit("Quart",100000000000000000d, "CubicFoot",3342013887944712d),
            new ConvertToUnit("Quart",100000000000000d, "CubicInch",5774999998368463d),
            new ConvertToUnit("Quart",1000000000000d, "CubicMeter",946352946d),
            new ConvertToUnit("Quart",1d, "Cup",4d),
            new ConvertToUnit("Quart",1d, "FluidOunce",32d),
            new ConvertToUnit("Quart",100d, "Gallon",25d),
            new ConvertToUnit("Quart",1000000d, "Gram",946352946d),
            new ConvertToUnit("Quart",10d, "HalfGallon",5d),
            new ConvertToUnit("Quart",1000000000d, "KiloGram",946352946d),
            new ConvertToUnit("Quart",1000000000d, "Liter",946352946d),
            new ConvertToUnit("Quart",1000d, "MilliGram",946352946d),
            new ConvertToUnit("Quart",1000000d, "MilliLiter",946352946d),
            new ConvertToUnit("Quart",1000000000000000d, "Ounce",33381617808077324d),
            new ConvertToUnit("Quart",1d, "Pint",2d),
            new ConvertToUnit("Quart",10000000000000000d, "Pound",20863511130048330d),
            new ConvertToUnit("Quart",1d, "Quart",1d),
            new ConvertToUnit("Quart",1d, "Tablespoon",64d),
            new ConvertToUnit("Quart",1d, "Teaspoon",192d)
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
