using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public abstract class Unit
    {
        public Unit() { }
        public int UnitID { get; set; }
        public string Name
        {
            get { return GetType().Name; }
        }
        public int Index { get; set; }
        public Fraction BaseVolume { get; set; }
        public abstract Fraction[] ConversionFactors { get;}
        public abstract Fraction this[int index] {get;}

        public UnitOfMeasure ConvertTo(Unit u)
        {
            var from_cf = ConversionFactors;

            var volume = (Fraction)from_cf[u.Index];

            return new UnitOfMeasure(u, volume);
        }

        private int GetIndexByFractionComparison(Fraction fraction)
        {
            for (int i = 0; i < ConversionFactors.Length; i++)
            {
                if (ConversionFactors[i] == fraction)
                    return i;
            }
            throw new System.ArgumentOutOfRangeException(fraction.ToString(), fraction.ToString() + " not associated with " + this.GetType().Name + " ConversionFactor List");
        }
        public int this[Fraction fraction]
        {
            get
            {
                return (GetIndexByFractionComparison(fraction));
            }
        }
    }
}
