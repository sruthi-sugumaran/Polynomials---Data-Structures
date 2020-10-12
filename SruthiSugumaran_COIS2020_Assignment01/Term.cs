using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class Term : IComparable
    {
        private double coefficient;
        private int exponent;

        public double Coefficient
        {
            get { return this.coefficient; }
            set { this.coefficient = value; }
        }

        public int Exponent
        {
            get { return this.exponent; }
            set
            {
                if (value < 0 || value > 99)
                    throw new ArgumentOutOfRangeException("Exponent must be between 0 and 99");
                else
                    this.exponent = value;
            }
        }

        //Creates a term with the given coefficient and exponent
        public Term(double coefficient, int exponent)
        {
            this.Coefficient = coefficient;
            this.Exponent = exponent;
        }

        //Evaluates the current term at x
        public double Evaluate(double x)
        {
            double value = 0;
            value = this.Coefficient * Math.Pow(x, this.Exponent);
            return value;
        }

        //Returns -1,0, or 1 if the exponent of the current term 
        //is less than, equal to, or greater than the exponent of obj
        public int CompareTo(object obj)
        {
            if (obj is Term)
            {
                Term newObj = (Term)obj;
                if (this.Exponent < newObj.Exponent)
                    return -1;
                else if (this.Exponent > newObj.Exponent)
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new ArgumentException("Enter a valid term");
            }
        }

        //Returns a string representation of the current term
        public override string ToString()
        {
            return this.Coefficient.ToString() + $"(x^{this.Exponent})";
        }
    }
}
