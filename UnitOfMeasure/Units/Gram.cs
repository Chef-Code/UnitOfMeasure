﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Gram : Unit //based off teaspoon, remove this comment once updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("Gram",1d, "CubicCentimeter",1d),
            new ConvertToUnit("Gram",1000000000000000000000d, "CubicFoot",35314666711511584d),
            new ConvertToUnit("Gram",100000000000000000, "CubicInch",6102374407749202d),
            new ConvertToUnit("Gram",1000000d, "CubicMeter",1d),
            new ConvertToUnit("Gram",1000000000000000000d, "Cup",4226752837730375d),
            new ConvertToUnit("Gram",1000000000000000d, "FluidOunce",33814022701843d),
            new ConvertToUnit("Gram",100000000000000000000d, "Gallon",26417205235814844d),
            new ConvertToUnit("Gram",1d, "Gram",1d),
            new ConvertToUnit("Gram",100000000000000000000d, "HalfGallon",52834410471629688d),
            new ConvertToUnit("Gram",1000d, "KiloGram",1d),
            new ConvertToUnit("Gram",1000d, "Liter",1d),
            new ConvertToUnit("Gram",1d, "MilliGram",1000d),
            new ConvertToUnit("Gram",1d, "MilliLiter",1d),
            new ConvertToUnit("Gram",100000000000000000d, "Ounce",3527396194958041d),
            new ConvertToUnit("Gram",10000000000000000000d, "Pint",21133764188651870d),
            new ConvertToUnit("Gram",10000000000000000000d, "Pound",22046226218487756d),
            new ConvertToUnit("Gram",10000000000000000000d, "Quart",10566882094325936d),
            new ConvertToUnit("Gram",1000000000000000d, "Tablespoon",67628045403686d),
            new ConvertToUnit("Gram",100000000000000000d, "Teaspoon",20288413621105796d)
        };
        public Gram() { }
        public Gram(double quantity) : base(quantity) { }
        public Gram(Unit baseVolume) : base(baseVolume) { }
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
