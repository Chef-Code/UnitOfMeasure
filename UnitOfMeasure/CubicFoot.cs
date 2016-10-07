using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class CubicFoot : Unit //based off Teaspoon, Remove this comment once updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("CubicFoot",10000d, "CubicCentimeter",283168466d),
            new ConvertToUnit("CubicFoot",1d, "CubicFoot",1d),
            new ConvertToUnit("CubicFoot",1d, "CubicInch",1728d),
            new ConvertToUnit("CubicFoot",10000000000d, "CubicMeter",283168466d),
            new ConvertToUnit("CubicFoot",100000000000000d, "Cup",11968831172212572d),
            new ConvertToUnit("CubicFoot",10000000000000d, "FluidOunce",9575064937770058d),
            new ConvertToUnit("CubicFoot",1000000000000000d, "Gallon",7480519482632857d),
            new ConvertToUnit("CubicFoot",1d, "Gram",1d),
            new ConvertToUnit("CubicFoot",1000000000000000d, "HalfGallon",14961038965265714d),
            new ConvertToUnit("CubicFoot",10000000d, "KiloGram",283168466d),
            new ConvertToUnit("CubicFoot",10000000d, "Liter",283168466d),
            new ConvertToUnit("CubicFoot",10d, "MilliGram",283168466d),
            new ConvertToUnit("CubicFoot",10000d, "MilliLiter",283168466d),
            new ConvertToUnit("CubicFoot",10000000000000d, "Ounce",9988473695005054d),
            new ConvertToUnit("CubicFoot",100000000000000d, "Pint",5984415586106286d),
            new ConvertToUnit("CubicFoot",100000000000000d, "Pound",6242796059378159d),
            new ConvertToUnit("CubicFoot",1000000000000000d, "Quart",29922077930531428d),
            new ConvertToUnit("CubicFoot",10000000000000d, "Tablespoon",19150129875540116d),
            new ConvertToUnit("CubicFoot",1000000000000d, "Teaspoon",5745038962662034d)
        };
        public CubicFoot() { }
        public CubicFoot(double quantity) : base(quantity) { }
        public CubicFoot(Unit baseVolume) : base(baseVolume) { }
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
