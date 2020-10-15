using DatastructuresLinearArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DatastructuresPolynomials.Polynomials S = new DatastructuresPolynomials.Polynomials();

        Start:
            int key = 0;

            do
            {

                Console.WriteLine("Choose the corresponding number to select the option");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("1. Create a Polynomial and insert it into S");
                Console.WriteLine("2. Add two polynomials from S and insert the resultant polynomial into S");
                Console.WriteLine("3. Multiply two polynomials from S at a given index");
                Console.WriteLine("4. Delete the polynomial from S at a given index");
                Console.WriteLine("5. Evaluate the polynomial from S at a given index");
                Console.WriteLine("6. Exit");

                Console.Write("\nEnter option(1-6): \t");
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        PolynomialInsert(S);
                        break;
                    case 2:
                        AddPolynomial(S);
                        break;
                    case 3:
                        MultiplyPolynomial(S);
                        break;
                    case 4:
                        DeletePolynomial(S);
                        break;
                    case 5:
                        EvaluatePolynomial(S);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid key!\n\n");
                        goto Start;

                }
            } while (key != 6);
        }

        public static void PolynomialInsert(DatastructuresPolynomials.Polynomials S)
        {
            DatastructuresLinkedList.Polynomial polynomial = new DatastructuresLinkedList.Polynomial();
            double coefficient = 0;
            int exponent = 0;
            char choice;

            Console.Clear(); 
            Console.WriteLine("Create a Polynomial and Insert it into S");
            Console.WriteLine("----------------------------------------------");

            AddingTerm:

            Term term;

            try
            {
                Console.Write("Enter term - coefficient: ");
                coefficient = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter term - exponent: ");
                exponent = Convert.ToInt32(Console.ReadLine());
                term = new Term(coefficient, exponent);
                polynomial.AddTerm(term);
                Console.WriteLine($"{term} added!");
                Console.Write("Polynomial:");
                polynomial.Print();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------");
                goto AddingTerm;
            }
            
            ConfirmAddMoreTerms:

            try
            {
                Console.Write("\n\nDo you want to add more terms?(Y/N)\t");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------");
                goto ConfirmAddMoreTerms;
            }

            if (choice == 'Y' || choice == 'y')
            {
                goto AddingTerm;
            }
            else if (choice != 'N' && choice != 'n')
            {
                Console.WriteLine("Invalid entry!");
                goto ConfirmAddMoreTerms;
            }
            else
            {
                Console.WriteLine("Adding polynomial to S");
                Console.Write("Polynomial:");
                polynomial.Print();
                Console.WriteLine("\n");
                S.Insert(polynomial);
                Console.WriteLine("S:");
                S.Print();
                Console.WriteLine("\nPress any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }

        }

        public static void AddPolynomial(DatastructuresPolynomials.Polynomials S)
        {
            
        }

        public static void MultiplyPolynomial(DatastructuresPolynomials.Polynomials S)
        {

        }
        public static void DeletePolynomial(DatastructuresPolynomials.Polynomials S)
        {

        }
        public static void EvaluatePolynomial(DatastructuresPolynomials.Polynomials S)
        {

        }
    }
}


//DatastructuresLinkedList.PolynomialLinkedListTest.TestAddTerm();
//DatastructuresLinkedList.PolynomialLinkedListTest.TestEvaluate();
//DatastructuresLinkedList.PolynomialLinkedListTest.TestPrint();
//DatastructuresLinkedList.PolynomialLinkedListTest.TestPlusOperator();
//DatastructuresLinkedList.PolynomialLinkedListTest.TestMultiplyOperator();

//PolynomialLinearArrayTest.TestAddTerm();
//PolynomialLinearArrayTest.TestEvaluate();
//PolynomialLinearArrayTest.TestPrint();
//PolynomialLinearArrayTest.TestPlusOperator();
//PolynomialLinearArrayTest.TestMultiplyOperator();

//DatastructuresPolynomials.PolynomialsTest.TestInsert();
//DatastructuresPolynomials.PolynomialsTest.TestRetrieve();
//DatastructuresPolynomials.PolynomialsTest.TestDelete();
//DatastructuresPolynomials.PolynomialsTest.TestSize();
//DatastructuresPolynomials.PolynomialsTest.TestPrint();

