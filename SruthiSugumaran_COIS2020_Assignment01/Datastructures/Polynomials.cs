using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatastructuresLinkedList;

namespace DatastructuresPolynomials
{
    public class Polynomials
    {
        private List<Polynomial> L;

        //Creates an empty list L of polynomials
        public Polynomials()
        {
            L = new List<Polynomial>();
        }

        // Retrieves the polynomial stored at position i in L
        public Polynomial Retrieve(int i)
        {
            for (int j = 0; j < L.Count; j++)
            {
                if (j == i)
                {
                    return L[i];
                }
            }
            return default(Polynomial);
        }

        //Inserts polynomial p into L
        public void Insert(Polynomial p)
        {
            if (p.Front == null)
                throw new ArgumentException("Please insert a non empty polynomial...");
            else
                L.Add(p);
        }        

        //Deletes the polynomial at index i
        public void Delete(int i)
        {
            if(i >= L.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int j = 0; j < L.Count; j++)
            {
                if (j == i)
                {
                    L.RemoveAt(i);
                }
            }
        }

        // Returns the number of polynomials in L
        public int Size()
        {
            return L.Count;
        }

        //Prints out the list of polynomials
        public void Print()
        {
            if(L.Count == 0)
            {
                Console.Write("null");              //Prints null when list is empty
            }
            else
            {
                foreach (Polynomial p in L)
                {
                    p.Print();
                    Console.WriteLine();
                }
            }
            

        }
    }
}
