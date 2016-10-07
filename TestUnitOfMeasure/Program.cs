using System;
using System.Collections;
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
            //Test_ConvertTo();
            //Test_Cups_ConvertToUnits();
            //Test_StringIndexer_Cups();
            _Cup_This_ConverToUnit_Indexer();
        }
        static void TestConvert()
        {
            var cup = new Cup();

            var from = new UnitOfMeasure.UnitOfMeasure(cup);
            var to = new Teaspoon();

            var tos = from.ConvertTo(new UnitOfMeasure.UnitOfMeasure(to));

            Console.WriteLine("Unit: " + tos.Unit.Name.ToString() + " Quantity: " + tos.Quantity.ToString() + " fluid ounces: " + tos.Volume.ToString());
            Console.ReadLine();
        }
        static void TestUnit_CF()
        {
            var cup = new Cup();

            var cf = cup.ConvertToUnits; 

            var d = cf[0].BecomeQuantity;
            var n = cf[0].FromQuantity;

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

        static void Test_ConvertTo()
        {
            var from = new Cup();

            var becomes = from.ConvertTo(new CubicCentimeter());

            Console.WriteLine(becomes.Quantity.ToString() + " : " + becomes.Volume.ToString());
            Console.ReadLine();
        }

        static void Test_Cups_ConvertToUnits()
        {
            var cups = new Cup(100);

            var ctus = cups.ConvertToUnits;

            var cc = ctus.FirstOrDefault(ctu => ctu.Become == "CubicCentimeter");  // breaking the Fraction Class
            var i = 0;
            var str = new string[3];
            foreach(var c in ctus)
            {
                var frac = c.EquivalentRatio;

                var num = frac.Numerator;
                var dem = frac.Denominator;

                str[i] += frac.ToString();
                i++;
            }

            Console.WriteLine(str[1] + " " + str[1] + " " + str[1] + " ");
        }
        static void Test_StringIndexer_Cups()
        {
            var cups = new Cup(2);

            var gram = cups["Gram"];

            Console.WriteLine(gram.EquivalentRatio.ToString());
            Console.ReadLine();
        }
        static void _Cup_This_ConverToUnit_Indexer()
        {
            var cup = new Cup(new FluidOunce());

            var index = cup[cup["Cup"]]; //worked

            //var index = cup.Index;
            var bv = cup.BaseVolume;
            Console.WriteLine(index.ToString() + " " + bv.ToString());
            Console.ReadLine();
        }
    }
}
