using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Tablespoon : Unit
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] 
        {
            new ConvertToUnit("Tablespoon",100000000000d, "CubicCentimeter",1478676478125d),
            new ConvertToUnit("Tablespoon",10000000000000000000d, "CubicFoot",5221896699913612d),
            new ConvertToUnit("Tablespoon",10000000000000000d, "CubicInch",9023437497450722d),
            new ConvertToUnit("Tablespoon",100000000000000000d, "CubicMeter",1478676478125d),
            new ConvertToUnit("Tablespoon",10000d, "Cup",625d),
            new ConvertToUnit("Tablespoon",10d, "FluidOunce",5d),
            new ConvertToUnit("Tablespoon",100000000d, "Gallon",390625d),
            new ConvertToUnit("Tablespoon",100000000000d, "Gram",1478676478125d),
            new ConvertToUnit("Tablespoon",1000000000d, "HalfGallon",1953125d),
            new ConvertToUnit("Tablespoon",100000000000000d, "KiloGram",1478676478125d),
            new ConvertToUnit("Tablespoon",100000000000000d, "Liter",1478676478125d),
            new ConvertToUnit("Tablespoon",100000000d, "MilliGram",1478676478125d),
            new ConvertToUnit("Tablespoon",100000000000d, "MilliLiter",1478676478125d),
            new ConvertToUnit("Tablespoon",10000000000000000d, "Ounce",5215877782512082d),
            new ConvertToUnit("Tablespoon",100000d, "Pint",3125d),
            new ConvertToUnit("Tablespoon",100000000000000000d, "Pound",3259923614070051d),
            new ConvertToUnit("Tablespoon",1000000d, "Quart",15625d),
            new ConvertToUnit("Tablespoon",1d, "Tablespoon",1d),
            new ConvertToUnit("Tablespoon",1d, "Teaspoon",3d)
        };
        public Tablespoon()
        {
            this.BaseVolume = new Fraction(1,2);
            this.Index = 1;
        }
        public Tablespoon(double quantity)
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
