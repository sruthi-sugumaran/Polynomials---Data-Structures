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
                for(int i=0; i < P.Length; i++)
                {
                    if (P[i].Exponent == t.Exponent)
                    {
                        P[i].Coefficient += t.Coefficient;
                        break;
                    }
                    if (t.Exponent > P[i].Exponent)
                    {
                        for (int j = this.count; j > i; j--)
                            P[j] = P[j - 1];
                        P[i] = t;
                        count++;
                        break;
                    }
                    else
                    {
                        int k = i;
                        while (P[k].Exponent > t.Exponent)
                        {
                            if (k >= count - 1)
                                break;
                            k++;


                        }    

                            
                        if (P[k].Exponent == t.Exponent)
                        {
                            P[k].Coefficient += t.Coefficient;
                            break;
                        }
                        else
                        {
                            //do the shifting
                            P[k+1] = t;
                            count++;
                            break;
                        }

                    }
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
