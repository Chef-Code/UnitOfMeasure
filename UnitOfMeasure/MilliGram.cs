using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class MilliGram : Unit //based off teaspoon, remove this comment once updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("MilliGram",1000d, "CubicCentimeter",1d),
            new ConvertToUnit("MilliGram",1000000000000000000000000d, "CubicFoot",35314666711511584d),
            new ConvertToUnit("MilliGram",100000000000000000000d, "CubicInch",6102374407749202d),  //Unit Test this CTU
            new ConvertToUnit("MilliGram",1000000000d, "CubicMeter",1d),
            new ConvertToUnit("MilliGram",1000000000000000000000d, "Cup",4226752837730375d),
            new ConvertToUnit("MilliGram",1000000000000000000d, "FluidOunce",33814022701843d),
            new ConvertToUnit("MilliGram",100000000000000000000000d, "Gallon",26417205235814844d),
            new ConvertToUnit("MilliGram",1000d, "Gram",1d),
            new ConvertToUnit("MilliGram",100000000000000000000000d, "HalfGallon",52834410471629688d),
            new ConvertToUnit("MilliGram",1000000d, "KiloGram",1d),
            new ConvertToUnit("MilliGram",1000000d, "Liter",1d),
            new ConvertToUnit("MilliGram",1d, "MilliGram",1d),
            new ConvertToUnit("MilliGram",1000d, "MilliLiter",1d),
            new ConvertToUnit("MilliGram",100000000000000000000d, "Ounce",3527396194958041d),
            new ConvertToUnit("MilliGram",10000000000000000000000d, "Pint",21133764188651870d),
            new ConvertToUnit("MilliGram",10000000000000000000000d, "Pound",22046226218487756d),
            new ConvertToUnit("MilliGram",10000000000000000000000d, "Quart",10566882094325936d),
            new ConvertToUnit("MilliGram",1000000000000000000d, "Tablespoon",67628045403686d),
            new ConvertToUnit("MilliGram",100000000000000000000d, "Teaspoon",20288413621105796d)
        };
        public MilliGram()
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
        }
        public MilliGram(double quantity) 
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
