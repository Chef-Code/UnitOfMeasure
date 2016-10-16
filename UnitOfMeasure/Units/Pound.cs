using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Pound : Unit        //TODO:  FIX THIS
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("Pound",100000d, "CubicCentimeter",45359237d),
            new ConvertToUnit("Pound",1000000000000000000d, "CubicFoot",16018463369434646d),
            new ConvertToUnit("Pound",100000000000000d, "CubicInch",2767990470238307d),
            new ConvertToUnit("Pound",100000000000d, "CubicMeter",45359237d),
            new ConvertToUnit("Pound",1000000000000000d, "Cup",1917222837070346d),
            new ConvertToUnit("Pound",1000000000000000d, "FluidOunce",15337782696562768d),
            new ConvertToUnit("Pound",100000000000000000d, "Gallon",11982642731689664d),
            new ConvertToUnit("Pound",100000d, "Gram",45359237d),
            new ConvertToUnit("Pound",100000000000000000d, "HalfGallon",5991321365844832d),
            new ConvertToUnit("Pound",100000000d, "KiloGram",45359237d),
            new ConvertToUnit("Pound",100000000d, "Liter",45359237d),
            new ConvertToUnit("Pound",100d, "MilliGram",45359237d),
            new ConvertToUnit("Pound",100000d, "MilliLiter",45359237d),
            new ConvertToUnit("Pound",1d, "Ounce",16d),
            new ConvertToUnit("Pound",1000000000000000d, "Pint",958611418535173d),
            new ConvertToUnit("Pound",1d, "Pound",1d),
            new ConvertToUnit("Pound",10000000000000000d, "Quart",4793057092675865d),
            new ConvertToUnit("Pound",1000000000000000d, "Tablespoon",30675565393125536d),
            new ConvertToUnit("Pound",100000000000000d, "Teaspoon",9202669617937660d)
        };
        public Pound() { }
        public Pound(double quantity) : base(quantity) { }
        public Pound(Unit baseVolume) : base(baseVolume) { }
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
