using Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Shushmita
namespace DatastructuresLinearArray
{
    public class Polynomial
    {
        //size of polynomial array
        private Term[] P;
        //keep track of number of terms present in Polynomial
        private int count;

        //constructor to create an empty polynomial 
        public Polynomial()
        {
            P = new Term[100];
            this.count = 0;
        }

        //Adding a new term to the polynomial
        public void AddTerm(Term t)
        {
            if (count == 0)
            {
                P[0] = t;
                count++;
            }

            else
            {
                int indx=count-1;
                Boolean bigger = false;
                Boolean equal=false;
                Boolean addedLast=false;
                for (int i = 0; i <count; i++)
                {
                    if ( t.Exponent> P[i].Exponent)
                    {
                        bigger = true;
                        indx = i;
                        break;
                    }
                    if(t.Exponent == P[i].Exponent)
                    {
                        equal = true;
                        indx = i;
                        break;
                    }
                    if(!equal &&!bigger && i==count-1)
                    {
                        addedLast = true;
                        indx = i;
                        break;
                    }
                }
                if (equal)
                {
                    P[indx].Coefficient += t.Coefficient;
                }
                else if (bigger)
                {
                    int j;
                    for (j = this.count; j >indx; j--)
                        P[j] = P[j - 1];
                    P[j] = t;
                    count++;
                }
                else if(addedLast)
                {
                    P[count] = t;
                    count++;
                }

            }
        }

        //Adds polynomials p and q to yield a new polynomial
        public static Polynomial operator + (Polynomial p, Polynomial q)
        {
            Polynomial result = new Polynomial();

            if(p.count == 0 || q.count == 0)
            {
                throw new ArgumentException("Please enter non-null polynomials");
            }

            else
            {
                for (int i = 0; i < p.count; i++)
                    result.AddTerm(new Datastructures.Term(p.P[i].Coefficient, p.P[i].Exponent));
                for (int i = 0; i < q.count; i++)
                    result.AddTerm(new Datastructures.Term(q.P[i].Coefficient, q.P[i].Exponent));

                return result;
            }
        }


        //Multiplies polynomial p and q to yield a new polynomial
        public static Polynomial operator * (Polynomial p, Polynomial q)
        {
            Polynomial result = new Polynomial();

            if (p.count == 0 || q.count == 0)
            {
                throw new ArgumentException("Please enter non-null polynomials");
            }
            else
            {
                for (int i = 0; i < p.count; i++)
                {
                    for (int j = 0; j < q.count; j++)
                    {
                        result.AddTerm(new Term(p.P[i].Coefficient * q.P[j].Coefficient,
                            p.P[i].Exponent + q.P[j].Exponent));
                    }
                }
                return result;
            }
            
        }

        //Evaluates the current polynomial at x
        public double Evaluate(double x)
        {
            double value = 0;

            if(this.count == 0)
            {
                throw new InvalidOperationException("The polynomial is empty");
            }
            for(int i = 0; i < this.count; i++)
            {
                value += this.P[i].Evaluate(x);
            }

            return value;
        }

        //Prints the current polynomial
        public void Print()
        {
            if(count == 0)
            {
                Console.Write("null");
            }
            else
            {
                for (int i = 0; i < this.count; i++)
                {
                    Console.Write(P[i]);

                    if (P[i + 1] != null)
                        Console.Write(" + ");

                }
            }
        }

    }
}
