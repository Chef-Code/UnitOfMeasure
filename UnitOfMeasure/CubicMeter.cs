﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class CubicMeter : Unit //based of Teaspoon, Remove once this is updated
    {
        private Fraction[] _CF = new Fraction[]
        {
            new Fraction(1,1), new Fraction(1,2), new Fraction(1,6), new Fraction(1,48), new Fraction(1,96), new Fraction(1,192), new Fraction(1,384), new Fraction(1,778)
        };
        private ConvertToUnit[] _convertToUnits = new ConvertToUnit[] { };
        public CubicMeter()
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
        }
        public CubicMeter(double quantity)
        {
            this.BaseVolume = new Fraction(1, 6);
            this.Index = 0;
        }
        public override Fraction[] ConversionFactors
        {
            get { return _CF; }
        }
        public override Fraction this[int index]
        {
            get
            {
                return _CF[index];
            }
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
