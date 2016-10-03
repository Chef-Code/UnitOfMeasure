using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public abstract class Unit
    {
        public Unit(){ }
        public int UnitID { get; set; }
        public string Name
        {
            get { return GetType().Name; }
        }
        public int Index { get; set; }
        public double Quantity { get; set; }
        public Fraction BaseVolume { get; set; }  //This is Equivalent to How many FluidOunces the Unit Contains
        public abstract Fraction[] ConversionFactors { get;}
        public abstract Fraction this[int index] {get;}
        public abstract ConvertToUnit this[string become]
        {                
                get;   //return _convertToUnits.SingleOrDefault(ctu => ctu.Become == become);         
        }
        public abstract ConvertToUnit[] ConvertToUnits { get; }  
        public UnitOfMeasure ConvertTo(Unit u)
        {
            var become = u.Name.ToString();

            var ctu = this[become];

            var eq = ctu.EquivalentRatio;
            var newQuantity = this.Quantity * eq;

            u.Quantity = newQuantity;

            return new UnitOfMeasure(u);
        }
    }
}
