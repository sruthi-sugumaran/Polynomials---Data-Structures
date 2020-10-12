using DatastructuresLinearArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checking term class
            Console.WriteLine("Checking term class\n");
            Term term1 = new Term(2, 3);
            Term term2 = new Term(4, 5);
            Term term3 = new Term(3, 2);
            Term term4 = new Term(6, 4);

            Console.WriteLine($"Term1:\t {term1.ToString()}");
            Console.WriteLine($"Term2:\t {term2.ToString()}");

            double x = 4;
            Console.WriteLine($"Evaluate: x=4\t {term1.Evaluate(x)}");

            Console.WriteLine($"Compare: {term2.ToString()}\t {term1.CompareTo(term2)}");
            //------------------------------------------------------------------------------
            


            //Checking polynomial list
            //------------------------------------------------------------------------------
            //Checking adding term and printing
            Console.WriteLine("\n\nChecking polynomial list");
            DatastructuresLinkedList.Polynomial p1 = new DatastructuresLinkedList.Polynomial();

            Console.WriteLine("\nAdding term1: 2(x^3)");
            p1.AddTerm(term1);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine("\n\nAdding term2: 4(x^5)");
            p1.AddTerm(term2);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine($"\n\nAdding term3: {term3.ToString()}");
            p1.AddTerm(term3);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine($"\n\nAdding term4: {term4.ToString()}");
            p1.AddTerm(term4);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine($"\n\nAdding term4 again: {term4.ToString()}");
            p1.AddTerm(term4);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine($"\n\nAdding term2 again: {term2.ToString()}");
            p1.AddTerm(term2);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine($"\n\nAdding term2 again: 3(x^2)");
            p1.AddTerm(term3);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine("");

            //Checking adding two polynomials

            
            Console.WriteLine("\n\nChecking 2 polynomial addition");
            DatastructuresLinkedList.Polynomial p2 = new DatastructuresLinkedList.Polynomial();

            Term term5 = new Term(6, 4);
            Term term6 = new Term(8, 2);

            Console.WriteLine($"\nAdding term1: {term5}");
            p2.AddTerm(term5);
            Console.Write("Result:");
            p2.Print();

            Console.WriteLine($"\n\nAdding term2: {term6}");
            p2.AddTerm(term6);
            Console.Write("Result:");
            p2.Print();

            Console.WriteLine($"\n\nAdding term2: {term6}");
            p2.AddTerm(term6);
            Console.Write("Result:");
            p2.Print();

            Console.Write($"\np1 + p2 = ");
            Console.WriteLine("\n---------------------\n\n");

            Console.WriteLine("\np1: ");
            p1.Print();
            Console.WriteLine("\np2: ");
            p2.Print();
            Console.WriteLine("\nAddition Result: ");
            DatastructuresLinkedList.Polynomial p3 = (p1 + p2);
            p3.Print();
            Console.WriteLine();

            //Checking multiplying two polynomials

            Console.WriteLine("\n\nChecking 2 polynomial addition");

            Console.Write($"\np1 * p2 = ");
            Console.WriteLine("\n---------------------\n\n");

            Console.WriteLine("\np1: ");
            p1.Print();
            Console.WriteLine("\np2: ");
            p2.Print();
            Console.WriteLine("\nMultiplication Result: ");
            DatastructuresLinkedList.Polynomial p1p2 = (p1 * p2);
            p1p2.Print();
            Console.WriteLine();

            //Evaluate polynomials

            Console.WriteLine("\n\nChecking evaluate polynomial");
            Console.WriteLine("\n---------------------\n\n");

            Console.Write("\nx = 0, p1 = ");
            p1.Print();
            Console.WriteLine($"\n{p1.Evaluate(0)}\n");

            Console.Write("\nx = 0, p2 = ");
            p2.Print();
            Console.WriteLine($"\n{p2.Evaluate(0)}\n");

            Console.Write("\nx = 1, p1 = ");
            p1.Print();
            Console.WriteLine($"\n{p1.Evaluate(1)}\n");

            Console.Write("\nx = 1, p2 = ");
            p2.Print();
            Console.WriteLine($"\n{p2.Evaluate(1)}\n");

            Console.Write("\nx = 2, p1 = ");
            p1.Print();
            Console.WriteLine($"\n{p1.Evaluate(2)}\n");

            Console.Write("\nx = 2, p2 = ");
            p2.Print();
            Console.WriteLine($"\n{p2.Evaluate(2)}\n");

            Console.WriteLine();
            Console.Clear();

            //END OF WORK BY SRUTHI

            Console.WriteLine("Work by Shushmita below:");

            Polynomial p5;
        }
    }
}
