﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class CubicMeter : Unit //based of Teaspoon, Remove once this is updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("CubicMeter",1d, "CubicCentimeter",1000000d),
            new ConvertToUnit("CubicMeter",1000000000000000d, "CubicFoot",35314666711511584d),
            new ConvertToUnit("CubicMeter",100000000000d, "CubicInch",6102374407749202d),
            new ConvertToUnit("CubicMeter",1d, "CubicMeter",1d),
            new ConvertToUnit("CubicMeter",1000000000000d, "Cup",4226752837730375d),
            new ConvertToUnit("CubicMeter",1000000000d, "FluidOunce",33814022701843d),
            new ConvertToUnit("CubicMeter",100000000000000d, "Gallon",26417205235814844d),
            new ConvertToUnit("CubicMeter",1d, "Gram",1000000d),
            new ConvertToUnit("CubicMeter",100000000000000d, "HalfGallon",52834410471629688d),
            new ConvertToUnit("CubicMeter",1d, "KiloGram",1000d),
            new ConvertToUnit("CubicMeter",1d, "Liter",1000d),
            new ConvertToUnit("CubicMeter",1d, "MilliGram",1000000000d),
            new ConvertToUnit("CubicMeter",1d, "MilliLiter",1000000d),
            new ConvertToUnit("CubicMeter",100000000000d, "Ounce",3527396194958041d),
            new ConvertToUnit("CubicMeter",10000000000000d, "Pint",21133764188651870d),
            new ConvertToUnit("CubicMeter",10000000000000d, "Pound",22046226218487756d),
            new ConvertToUnit("CubicMeter",10000000000000d, "Quart",10566882094325936d),
            new ConvertToUnit("CubicMeter",1000000000d, "Tablespoon",67628045403686d),
            new ConvertToUnit("CubicMeter",100000000000d, "Teaspoon",20288413621105796d)
        };
        public CubicMeter() { }
        public CubicMeter(double quantity) : base(quantity) { }
        public CubicMeter(Unit baseVolume) : base(baseVolume) { }
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
