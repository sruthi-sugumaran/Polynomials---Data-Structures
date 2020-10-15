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

        public Polynomials()
        {
            L = new List<Polynomial>();
        }

        public void Insert(Polynomial p)
        {
            if (p.Front == null)
                throw new ArgumentException("Please insert a non empty polynomial...");
            else
                L.Add(p);
        }

        // Retrieves the polynomial stored at position i in L
        public Polynomial Retrieve(int i)
        {
            for (int j=0; j< L.Count;j++)
            {
                if (j == i)
                {
                    return L[i];
                }
                

            }
            return default(Polynomial);

        }

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

        public void Print()
        {
            if(L.Count == 0)
            {
                Console.Write("null");
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
