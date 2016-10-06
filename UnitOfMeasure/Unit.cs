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
        public Fraction BaseWeight { get; set; }
        public abstract ConvertToUnit[] ConvertToUnits { get; }
        public abstract ConvertToUnit this[string become] { get; }

        public int this[ConvertToUnit convertToUnit]
        {
            get
            {
                int[] ints = Enumerable.Range(0, ConvertToUnits.Length)
                           .Where(index => ConvertToUnits[index].Become.Contains(convertToUnit.Become)).ToArray();
                return ints[0];

            }
        }

        public UnitOfMeasure ConvertTo(Unit u)
        {
            var become = u.Name;

            var ctu = this[become];

            var equivalentRatio = ctu.EquivalentRatio;
            var newQuantity = this.Quantity * equivalentRatio;

            u.Quantity = newQuantity;

            return new UnitOfMeasure(u);
        }
    }
}
