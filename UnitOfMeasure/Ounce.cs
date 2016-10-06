using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Ounce : Unit //based off teaspoon, remove this comment once updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("Ounce",1000000000d, "CubicCentimeter",28349523125d),
            new ConvertToUnit("Ounce",10000000000000000000d, "CubicFoot",10011539605896654d),
            new ConvertToUnit("Ounce",10000000000000000d, "CubicInch",17299940438989418d),
            new ConvertToUnit("Ounce",1000000000000000d, "CubicMeter",28349523125d),
            new ConvertToUnit("Ounce",100000000000000000d, "Cup",11982642731689664d),
            new ConvertToUnit("Ounce",1000000000000000d, "FluidOunce",958611418535173d),
            new ConvertToUnit("Ounce",1000000000000000000d, "Gallon",7489151707306039d),
            new ConvertToUnit("Ounce",1000000000d, "Gram",28349523125d),
            new ConvertToUnit("Ounce",10000000000000000000d, "HalfGallon",37445758536530195d),
            new ConvertToUnit("Ounce",1000000000000d, "KiloGram",28349523125d),
            new ConvertToUnit("Ounce",1000000000000d, "Liter",28349523125d),
            new ConvertToUnit("Ounce",1000000d, "MilliGram",28349523125d),
            new ConvertToUnit("Ounce",1000000000d, "MilliLiter",28349523125d),
            new ConvertToUnit("Ounce",1d, "Ounce",1d),
            new ConvertToUnit("Ounce",100000000000000000d, "Pint",5991321365844832d),
            new ConvertToUnit("Ounce",10000d, "Pound",625d),
            new ConvertToUnit("Ounce",1000000000000000000d, "Quart",29956606829224156d),
            new ConvertToUnit("Ounce",1000000000000000d, "Tablespoon",1917222837070346d),
            new ConvertToUnit("Ounce",1000000000000000d, "Teaspoon",5751668511211038d)
        };
        public Ounce()
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
        }
        public Ounce(double quantity) 
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
