using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfMeasure;

namespace TestUnitOfMeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestConvert();
            //TestUnit_CF();
            //TestFraction_ToDouble();
            //Test_Indexer();
            //Test_ConvertTo();
            Test_GetIndexByFractionComparison();
        }
        static void TestConvert()
        {
            var from = new UnitOfMeasure.UnitOfMeasure(new Cup(),2.3);
            var to = new Teaspoon();

            var tos = from.ConvertTo(new UnitOfMeasure.UnitOfMeasure(to));

            Console.WriteLine("Unit: " + tos.Unit.Name.ToString() + " Quantity: " + tos.Quantity.ToString() + " fluid ounces: " + tos.Volume.ToString());
            Console.ReadLine();
        }
        static void TestUnit_CF()
        {
            var cup = new Cup();

            var cf = cup.ConversionFactors; 

            var d = cup[0].Denominator;
            var n = cup[0].Numerator;

            double volume = cup.BaseVolume;
           /* var cfd = cf[0].Denominator;
            var cfn = cf[0].Numerator;*/

            Console.WriteLine(n.ToString() + " " + d.ToString() + " " + volume.ToString()/*+ " : " + cfn.ToString() + " " + cfd.ToString()*/);
            Console.ReadLine();
        }

        static void TestFraction_ToDouble()
        {
            var cup = new Cup();
            double volume = cup.BaseVolume;
            Console.WriteLine( volume.ToString());
            Console.ReadLine();
        }

        static void Test_Indexer()
        {
            var cup = new Cup();
            var i = cup.BaseVolume;
            var index = cup[i];

            Console.WriteLine(index.ToString());
            Console.ReadLine();
        }

        static void Test_ConvertTo()
        {
            var gallon = new Gallon();

            var cups = gallon.ConvertTo(new Cup());

            Console.WriteLine(cups.Quantity.ToString() + " : " + cups.Volume.ToString());
            Console.ReadLine();
        }

        static void Test_GetIndexByFractionComparison()
        {
            //Use Case #1
            var from = new HalfGallon();
            var to = new Gallon(); 

            var useCase1 = from[to.BaseVolume];
            var type1 = from[useCase1];


            //Use Case #2
            var half = new Fraction(1, 2);

            var useCase2 = from[half];

            var type2 = from[useCase2];

            Console.WriteLine("Use Case #1; index: " + useCase1.ToString() + " is a: " + type1.ToString() + "\n\n" +
                "Use Case #2; index: " + useCase2.ToString() + " is a: " + type2.ToString());
            Console.ReadLine();
        }
    }
}
