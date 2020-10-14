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

        public void Print()
        {
            for(int i=0;i<this.count;i++)
            {
                Console.Write(P[i]);

                if (P[i+1] != null)
                    Console.Write(" + ");

            }
        }

        //Adding two polynomial
        //Multipliying two polynomial
        //Evaluating two polynomial
        //Print the polynomial

    }
}
