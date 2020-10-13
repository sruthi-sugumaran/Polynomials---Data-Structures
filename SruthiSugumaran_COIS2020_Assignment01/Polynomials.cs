﻿using System;
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
            L.Add(p);
        }

        // Retrieves the polynomial stored at position i in L
        public Polynomial Retrieve(int i)
        {
            for (int j=0; j< L.Count;j++)
            {
                if (j == i)
                {
                    return L[j];
                }
                

            }
            return default(Polynomial);

        }

        public void Delete(int i)
        {
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
            foreach (Polynomial p in L)
            {
                p.Print();
                Console.WriteLine();
            }

        }
    }
}
