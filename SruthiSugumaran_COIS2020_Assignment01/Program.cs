using DatastructuresLinearArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DatastructuresPolynomials;


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


            //Farhad's Tests
            Console.WriteLine("Test of Polynomials below:");
            //create an empty polynomials
            Polynomials S = new Polynomials();

            Console.WriteLine("Insert Polyomials p1, p2 and p3 in polynomials list");
            S.Insert(p1);
            S.Insert(p2);
            S.Insert(p3);
            //List of polynomials in S are
            S.Print();
            Console.WriteLine(S.Size());
            Console.WriteLine("Retrieve the polynomial from index 1 from polynomials");
            //Retrieve and print polynomial by index
            S.Retrieve(1).Print();
            Console.WriteLine("\nRemove the polynomial from index 0 from polynomials");
            //remove from the list by position
            S.Delete(0);
            S.Print();

            //The size of polynomials
            Console.WriteLine(S.Size());


            //check array implemention of polynomial
            //Console.WriteLine("-----------Array implementation of Polynomial------------");

            //DatastructuresLinearArray.Polynomial arrP = new DatastructuresLinearArray.Polynomial();
            //arrP.AddTerm(term1);
            //arrP.AddTerm(term2);
            //arrP.AddTerm(term3);
            //arrP.AddTerm(term4);
            //arrP.AddTerm(term4);
            //Console.WriteLine(term4.ToString());
            //arrP.Print();

            //Checking polynomial array
            //------------------------------------------------------------------------------
            //Checking adding term and printing
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("\n\nChecking polynomial array");
            DatastructuresLinearArray.Polynomial arrayPolynomial1 = new DatastructuresLinearArray.Polynomial();

            Console.WriteLine($"\nAdding term1: {term1}");
            arrayPolynomial1.AddTerm(term1);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term2: {term2}");
            arrayPolynomial1.AddTerm(term2);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term3: {term3.ToString()}");
            arrayPolynomial1.AddTerm(term3);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term4: {term4.ToString()}");
            arrayPolynomial1.AddTerm(term4);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term4 again: {term4.ToString()}");
            arrayPolynomial1.AddTerm(term4);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term2 again: {term2.ToString()}");
            arrayPolynomial1.AddTerm(term2);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine($"\n\nAdding term2 again: {term2}");
            arrayPolynomial1.AddTerm(term3);
            Console.Write("Result:");
            arrayPolynomial1.Print();

            Console.WriteLine("");

            //Checking adding two polynomials


            Console.WriteLine("\n\nChecking 2 polynomial addition");
            DatastructuresLinearArray.Polynomial arrayPolynomial2 = new DatastructuresLinearArray.Polynomial();

            Console.WriteLine($"\nAdding term1: {term5}");
            arrayPolynomial2.AddTerm(term5);
            Console.Write("Result:");
            arrayPolynomial2.Print();

            Console.WriteLine($"\n\nAdding term2: {term6}");
            arrayPolynomial2.AddTerm(term6);
            Console.Write("Result:");
            arrayPolynomial2.Print();

            Console.WriteLine($"\n\nAdding term2: {term6}");
            arrayPolynomial2.AddTerm(term6);
            Console.Write("Result:");
            arrayPolynomial2.Print();

            Console.Write($"\narrayPolynomial1 + arrayPolynomial2 = ");
            Console.WriteLine("\n---------------------\n\n");

            Console.WriteLine("\narrayPolynomial1: ");
            arrayPolynomial1.Print();
            Console.WriteLine("\narrayPolynomial2: ");
            arrayPolynomial2.Print();
            Console.WriteLine("\nAddition Result: ");
            DatastructuresLinearArray.Polynomial arrayPolynomialSum = (arrayPolynomial1 + arrayPolynomial2);
            arrayPolynomialSum.Print();
            Console.WriteLine();

            //Checking multiplying two polynomials

            Console.WriteLine("\n\nChecking 2 polynomial multiplication");

            Console.Write($"\narrayPolynomial1 * arrayPolynomial2 = ");
            Console.WriteLine("\n---------------------\n\n");

            Console.WriteLine("\narrayPolynomial1: ");
            arrayPolynomial1.Print();
            Console.WriteLine("\narrayPolynomial2: ");
            arrayPolynomial2.Print();
            Console.WriteLine("\nMultiplication Result: ");
            DatastructuresLinearArray.Polynomial arrayPolynomialProduct = (arrayPolynomial1 * arrayPolynomial2);
            arrayPolynomialProduct.Print();
            Console.WriteLine();

            //Evaluate polynomials

            Console.WriteLine("\n\nChecking evaluate polynomial");
            Console.WriteLine("\n---------------------\n\n");

            Console.Write("\nx = 0, arrayPolynomial1 = ");
            arrayPolynomial1.Print();
            Console.WriteLine($"\n{arrayPolynomial1.Evaluate(0)}\n");

            Console.Write("\nx = 0, arrayPolynomial2 = ");
            arrayPolynomial2.Print();
            Console.WriteLine($"\n{arrayPolynomial2.Evaluate(0)}\n");

            Console.Write("\nx = 1, arrayPolynomial1 = ");
            arrayPolynomial1.Print();
            Console.WriteLine($"\n{arrayPolynomial1.Evaluate(1)}\n");

            Console.Write("\nx = 1, arrayPolynomial2 = ");
            arrayPolynomial2.Print();
            Console.WriteLine($"\n{arrayPolynomial2.Evaluate(1)}\n");

            Console.Write("\nx = 2, arrayPolynomial1 = ");
            arrayPolynomial1.Print();
            Console.WriteLine($"\n{arrayPolynomial1.Evaluate(2)}\n");

            Console.Write("\nx = 2, arrayPolynomial2 = ");
            arrayPolynomial2.Print();
            Console.WriteLine($"\n{arrayPolynomial2.Evaluate(2)}\n");

            
        }
    }
}
