using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class FluidOunce : Unit
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("FluidOunce",10000000000d, "CubicCentimeter",295735295625d),
            new ConvertToUnit("FluidOunce",10000000000000000000d, "CubicFoot",10443793399827224d),
            new ConvertToUnit("FluidOunce",10000000000000000d, "CubicInch",18046874994901444d),
            new ConvertToUnit("FluidOunce",10000000000000000d, "CubicMeter",295735295625d),
            new ConvertToUnit("FluidOunce",1000d, "Cup",125d),
            new ConvertToUnit("FluidOunce",1d, "FluidOunce",1d),
            new ConvertToUnit("FluidOunce",10000000d, "Gallon",78125d),
            new ConvertToUnit("FluidOunce",10000000000d, "Gram",295735295625d),
            new ConvertToUnit("FluidOunce",10000000d, "HalfGallon",156250d),
            new ConvertToUnit("FluidOunce",10000000000000d, "KiloGram",295735295625d),
            new ConvertToUnit("FluidOunce",10000000000000d, "Liter",295735295625d),
            new ConvertToUnit("FluidOunce",10000000d, "MilliGram",295735295625d),
            new ConvertToUnit("FluidOunce",10000000000d, "MilliLiter",295735295625d),
            new ConvertToUnit("FluidOunce",10000000000000000d, "Ounce",10431755565024164d),
            new ConvertToUnit("FluidOunce",10000d, "Pint",625d),
            new ConvertToUnit("FluidOunce",100000000000000000d, "Pound",6519847228140102d),
            new ConvertToUnit("FluidOunce",100000d, "Quart",3125d),
            new ConvertToUnit("FluidOunce",1d, "Tablespoon",2d),
            new ConvertToUnit("FluidOunce",1d, "Teaspoon",6d)
        };
        public FluidOunce()
        {
            this.BaseVolume = new Fraction(1,1);
            this.Index = 2;
        }
        public FluidOunce(double quantity)
        {
            this.BaseVolume = new Fraction(8, 1);
            this.Index = 3;
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
