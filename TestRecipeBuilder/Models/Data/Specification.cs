using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfMeasure;

namespace TestRecipeBuilder.Models.Data
{
    public class Specification : Product
    {
        public string ProductName
        {
            get
            {
                return GeneralName + ", " + SpecificName;
            }
        }
        public ProcessedResults Preparation { get; set; }
        public Unit PricingUnit { get; set; }
        public string Standard { get; set; } //Standard/Grade of the product expected
        public string Container { get; set; } // Container will need to be a class
        public double  NetWeight { get; set; }
    }
}