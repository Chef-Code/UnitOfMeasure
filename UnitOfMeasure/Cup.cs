using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Cup : Unit
    {
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[]
        {
            new ConvertToUnit("Cup",10000000d, "CubicCentimeter",2365882365d),           
            new ConvertToUnit("Cup",10000000000000d, "CubicFoot",835503471986178d),
            new ConvertToUnit("Cup",1000000000000000d, "CubicInch",14437499995921156d),
            new ConvertToUnit("Cup",10000000000000d, "CubicMeter",2365882365d),
            new ConvertToUnit("Cup",1d, "Cup",1d),
            new ConvertToUnit("Cup",1d, "FluidOunce",8d),
            new ConvertToUnit("Cup",10000d, "Gallon",625d),
            new ConvertToUnit("Cup",10000000d, "Gram",2365882365d),
            new ConvertToUnit("Cup",10000d, "HalfGallon",1250d),
            new ConvertToUnit("Cup",10000000000d, "KiloGram",2365882365d),
            new ConvertToUnit("Cup",10000000000d, "Liter",2365882365d),
            new ConvertToUnit("Cup",10000d, "MilliGram",2365882365d),
            new ConvertToUnit("Cup",10000000d, "MilliLiter",2365882365d),
            new ConvertToUnit("Cup",1000000000000000d, "Ounce",8345404452019331d),
            new ConvertToUnit("Cup",10d, "Pint",5d),
            new ConvertToUnit("Cup",10000000000000000d, "Pound",5215877782512082d),
            new ConvertToUnit("Cup",100d, "Quart",25d),
            new ConvertToUnit("Cup",1d, "Tablespoon",16d),
            new ConvertToUnit("Cup",1d, "Teaspoon",48d)
        };
        public Cup()
        {
            this.BaseVolume = this["FluidOunce"].EquivalentRatio;
            this.Index = this[this[Name]];
            this.Quantity = 1;
        }

        public Cup(double quantity)  
        {
            this.BaseVolume = this["FluidOunce"].EquivalentRatio;
            this.Index = this[this[Name]];
            this.Quantity = quantity;
        }
        public Cup(Unit baseVolume)
        {
            BaseVolume = this[baseVolume.Name].EquivalentRatio;
            this.Index = this[this[Name]];
            this.Quantity = baseVolume.Quantity;
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
        public int this[ConvertToUnit convertToUnit]
        {
            get
            {
               int[] ints = Enumerable.Range(0, ConvertToUnits.Length)
                          .Where(index => ConvertToUnits[index].Become.Contains(convertToUnit.Become)).ToArray();
                return ints[0];
                          
            }
        }
    }
}
