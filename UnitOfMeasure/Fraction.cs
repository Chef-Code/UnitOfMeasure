using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfMeasure
{
    public class Fraction
    {
        public double Numerator, Denominator;

        // Initialize the fraction from a string A/B.
        public Fraction(string txt)
        {
            string[] pieces = txt.Split('/');
            Numerator = double.Parse(pieces[0]);
            Denominator = double.Parse(pieces[1]);
            Simplify();
        }

        // Initialize the fraction from numerator and denominator.
        public Fraction(double numer, double denom)
        {
            Numerator = numer;
            Denominator = denom;
            Simplify();
        }

        // Return a * b.
        public static Fraction operator *(Fraction a, Fraction b)
        {
            // Swap numerators and denominators to simplify.
            Fraction result1 = new Fraction(a.Numerator, b.Denominator);
            Fraction result2 = new Fraction(b.Numerator, a.Denominator);

            return new Fraction(
                result1.Numerator * result2.Numerator,
                result1.Denominator * result2.Denominator);
        }

        // Return -a.
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }

        // Return a + b.
        public static Fraction operator +( Fraction a, Fraction b)
        {
            Fraction fraction = new Fraction(a,b);
            // Get the denominators' greatest common divisor.
            double gcd_ab = fraction.GCD(a.Denominator,b.Denominator);  //Needs Tested -LONNIE

            double numer =
                a.Numerator * (b.Denominator / gcd_ab) +
                b.Numerator * (a.Denominator / gcd_ab);
            double denom =
                a.Denominator * (b.Denominator / gcd_ab);
            return new Fraction(numer, denom);
        }

        // Return a - b.
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + -b;
        }

        // Return a / b.
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * new Fraction(b.Denominator, b.Numerator);
        }

        // Simplify the fraction.
        private void Simplify()
        {
            // Simplify the sign.
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }

            // Factor out the greatest common divisor of the
            // numerator and the denominator.
            double gcd_ab = GCD(Numerator, Denominator);
            Numerator = Numerator / gcd_ab;
            Denominator = Denominator / gcd_ab;
        }

        // Convert a to a double.
        public static implicit operator double(Fraction a)
        {
            return ((double)a.Numerator / a.Denominator);
        }

        // Return the fraction's value as a string.
        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }

        // Use Euclid's algorithm to calculate the
        // greatest common divisor (GCD) of two numbers.
        private double GCD(double a, double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Pull out remainders.
            for (;;)
            {
                double remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }

        // Return the least common multiple
        // (LCM) of two numbers.
        private double LCM(double a, double b)
        {
            return a * b / GCD(a, b);
        }

        //TODO: Equality Check between 2 Fractions; Fraction a Equal Fraction b && a == b && GetHashCode() && a != b
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            Fraction fraction = (Fraction)obj;

            if (Numerator != fraction.Numerator && Denominator != fraction.Denominator)
                return false;

            return Numerator == fraction.Numerator && Denominator == fraction.Denominator;
        }

        public override int GetHashCode()
        {
            return (int)Numerator ^ (int)Denominator;
        }
        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Equals(fraction2);
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return !fraction1.Equals(fraction2);
        }
    }
}
