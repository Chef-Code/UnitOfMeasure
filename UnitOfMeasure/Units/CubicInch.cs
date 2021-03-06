﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class CubicInch : Unit //based off Teaspoon, Remove this comment once updated
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("CubicInch",100000000000000d, "CubicCentimeter",1638706400462963d),
            new ConvertToUnit("CubicInch",10000000000000000000d, "CubicFoot",5787037037037037d),
            new ConvertToUnit("CubicInch",1d, "CubicInch",1d),
            new ConvertToUnit("CubicInch",100000000000000000000d, "CubicMeter",1638706400462963d),
            new ConvertToUnit("CubicInch",100000000000000000d, "Cup",6926406928363757d),
            new ConvertToUnit("CubicInch",100000000000000000d, "FluidOunce",55411255426910056d),
            new ConvertToUnit("CubicInch",10000000000000000000d, "Gallon",43290043302273480d),
            new ConvertToUnit("CubicInch",100000000000000d, "Gram",1638706400462963d),
            new ConvertToUnit("CubicInch",1000000000000000d, "HalfGallon",86580086604546960d),
            new ConvertToUnit("CubicInch",100000000000000000d, "KiloGram",1638706400462963d),
            new ConvertToUnit("CubicInch",100000000000000000d, "Liter",1638706400462963d),
            new ConvertToUnit("CubicInch",1000000000000d, "MilliGram",16387064004629628d),
            new ConvertToUnit("CubicInch",1000000000000000d, "MilliLiter",16387064004629628d),
            new ConvertToUnit("CubicInch",10000000000000000d, "Ounce",5780366721646443d),
            new ConvertToUnit("CubicInch",1000000000000000000d, "Pint",34632034641818780d),
            new ConvertToUnit("CubicInch",100000000000000000d, "Pound",3612729201029027d),
            new ConvertToUnit("CubicInch",1000000000000000000d, "Quart",17316017320909390d),
            new ConvertToUnit("CubicInch",1000000000000000d, "Tablespoon",1108225108538201d),
            new ConvertToUnit("CubicInch",10000000000000000d, "Teaspoon",33246753256146028d)
        };
        public CubicInch() { }
        public CubicInch(double quantity) : base(quantity) { }
        public CubicInch(Unit baseVolume) : base(baseVolume) { }
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
