using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class UnitOfMeasure
    {
        private ConvertToUnit[] cubicCentimeter_CF = new CubicCentimeter().ConvertToUnits;
        private ConvertToUnit[] cubicFoot_CF = new CubicFoot().ConvertToUnits;
        private ConvertToUnit[] cubicInch_CF = new CubicInch().ConvertToUnits;
        private ConvertToUnit[] cubicMeter_CF = new CubicMeter().ConvertToUnits;
        private ConvertToUnit[] cup_CF = new Cup().ConvertToUnits;
        private ConvertToUnit[] fluidOunce_CF = new FluidOunce().ConvertToUnits;
        private ConvertToUnit[] gallon_CF = new Gallon().ConvertToUnits;
        private ConvertToUnit[] gram_CF = new Gram().ConvertToUnits;
        private ConvertToUnit[] halfGallon_CF = new HalfGallon().ConvertToUnits;
        private ConvertToUnit[] kiloGram_CF = new KiloGram().ConvertToUnits;
        private ConvertToUnit[] liter_CF = new Liter().ConvertToUnits;
        private ConvertToUnit[] milliGram_CF = new MilliGram().ConvertToUnits;
        private ConvertToUnit[] milliLiter_CF = new MilliLiter().ConvertToUnits;
        private ConvertToUnit[] ounce_CF = new Ounce().ConvertToUnits;
        private ConvertToUnit[] pint_CF = new Pint().ConvertToUnits;
        private ConvertToUnit[] pound_CF = new Pound().ConvertToUnits;
        private ConvertToUnit[] quart_CF = new Quart().ConvertToUnits;
        private ConvertToUnit[] tablespoon_CF = new Tablespoon().ConvertToUnits;
        private ConvertToUnit[] teaspoon_CF = new Teaspoon().ConvertToUnits;

        private double _volume;
        private double _weight;

        #region Constructors
        public UnitOfMeasure() { }
        public UnitOfMeasure(Unit Unit)
        {
            this.Unit = Unit;
            this.Quantity = Unit.Quantity;
            this.Volume = Unit.BaseVolume;
            this.Weight = Unit.BaseWeight;
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
        public ConvertToUnit[] Teaspoon_CF
        {
            get
            {
                return this.teaspoon_CF;
            }
        }
        public ConvertToUnit[] Tablespoon_CF
        {
            get
            {
                return this.tablespoon_CF;
            }
        }
        public ConvertToUnit[] FluidOunce_CF
        {
            get
            {
                return this.fluidOunce_CF;
            }
        }
        public ConvertToUnit[] Cup_CF
        {
            get
            {
                return this.cup_CF;
            }
        }
        public ConvertToUnit[] Pint_CF
        {
            get
            {
                return this.pint_CF;
            }
        }
        public ConvertToUnit[] Quart_CF
        {
            get
            {
                return this.quart_CF;
            }
        }
        public ConvertToUnit[] HalfGallon_CF
        {
            get
            {
                return this.halfGallon_CF;
            }
        }
        public ConvertToUnit[] Gallon_CF
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
            var wantedUnits = Quantity / (Fraction)Get_CF(unitWant);

            UnitOfMeasure convertedUnit = new UnitOfMeasure(unitWant.Unit);

            convertedUnit.Quantity = wantedUnits;  //this is broke

            return convertedUnit;
        }

        private object Get_CF(UnitOfMeasure unitWant)
        {
            Type UofM = typeof(UnitOfMeasure);
            var prop = UofM.GetProperty(unitWant.Unit.Name + "_CF");

            var cF = (ConvertToUnit[])prop.GetValue(this);
            return cF[unitWant.Unit.Index];
        }
        #endregion
    }
}
