using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class UnitOfMeasure
    {
        //schema:         "unit" + "_CF" = { Teaspoon, Tablespoon, FluidOunce, Cup, Pint, Quart, HalfGallon, Gallon };
        private Fraction[] teaspoon_CF = new Teaspoon().ConversionFactors;
        private Fraction[] tablespoon_CF = new Tablespoon().ConversionFactors;
        private Fraction[] fluidOunce_CF = new FluidOunce().ConversionFactors;
        private Fraction[] cup_CF = new Cup().ConversionFactors;
        private Fraction[] pint_CF = new Pint().ConversionFactors;
        private Fraction[] quart_CF = new Quart().ConversionFactors;
        private Fraction[] halfGallon_CF = new HalfGallon().ConversionFactors;
        private Fraction[] gallon_CF = new Gallon().ConversionFactors;

        private double _volume;
        private double _weight;
        private int index;

        #region Constructors
        public UnitOfMeasure() { }
        public UnitOfMeasure(Unit Unit)
        {
            this.Unit = Unit;
            this.Quantity = 1;
            this.Volume = Unit.BaseVolume;
            this.Weight = Weight;
        }
        public UnitOfMeasure(Unit Unit, double Quantity)
        {
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.Volume = this.Quantity * Unit.BaseVolume;
            this.Weight = Weight;
        }
        #endregion

        #region Properties
        public Unit Unit { get; set; }
        //public string Name { get; set; }
        public double Volume 
       {
            get { return _volume; }

            set { _volume = value; }
                
        }
        public double Weight
        {
            get { return _weight; }

            set { _weight = value; }

        }
        public double Quantity { get; set; }
        public Fraction[] Teaspoon_CF
        {
            get
            {
                return this.teaspoon_CF;
            }
        }
        public Fraction[] Tablespoon_CF
        {
            get
            {
                return this.tablespoon_CF;
            }
        }
        public Fraction[] FluidOunce_CF
        {
            get
            {
                return this.fluidOunce_CF;
            }
        }
        public Fraction[] Cup_CF
        {
            get
            {
                return this.cup_CF;
            }
        }
        public Fraction[] Pint_CF
        {
            get
            {
                return this.pint_CF;
            }
        }
        public Fraction[] Quart_CF
        {
            get
            {
                return this.quart_CF;
            }
        }
        public Fraction[] HalfGallon_CF
        {
            get
            {
                return this.halfGallon_CF;
            }
        }
        public Fraction[] Gallon_CF
        {
            get
            {
                return this.gallon_CF;
            }
        }
        #endregion

        #region Methods
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            UnitOfMeasure uom = (UnitOfMeasure)obj;

            if (_volume != uom.Volume)
                return false;

            return _volume == uom.Volume;
        }

        public override int GetHashCode()
        {
            return this.Unit.UnitID;
        }
        public static bool operator ==(UnitOfMeasure uom1, UnitOfMeasure uom2)
        {
            return uom1.Equals(uom2);
        }

        public static bool operator !=(UnitOfMeasure uom1, UnitOfMeasure uom2)
        {
            return !uom1.Equals(uom2);
        }



        public UnitOfMeasure ConvertTo(UnitOfMeasure unitWant)
        {
            switch (this.Unit.Name)
            {
                case "Gallon":
                    index = 7;
                    break;
                case "HalfGallon":
                    index = 6;
                    break;
                case "Quart":
                    index = 5;
                    break;
                case "Pint":
                    index = 4;
                    break;
                case "Cup":
                    index = 3;
                    break;
                case "FluidOunce":
                    index = 2;
                    break;
                case "Tablespoon":
                    index = 1;
                    break;
                case "Teaspoon":
                    index = 0;
                    break;
            }

            var wantedUnits = Quantity / (Fraction)Get_CF(unitWant, index);

            UnitOfMeasure convertedUnit = new UnitOfMeasure(unitWant.Unit, wantedUnits);

            return convertedUnit;
        }

        public object Get_CF(UnitOfMeasure unitWant, int index)
        {
            Type UofM = typeof(UnitOfMeasure);
            var prop = UofM.GetProperty(unitWant.Unit.Name + "_CF");

            var cF = (Fraction[])prop.GetValue(this);
            return cF[index];
        }
        #endregion
    }
}
