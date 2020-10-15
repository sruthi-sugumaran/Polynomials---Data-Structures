using DatastructuresLinearArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Group Members
//----------------------------
//Sruthi Sugumaran - 0690271
//Shushmitha Das - 0607436
//Farhad

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DatastructuresPolynomials.Polynomials S = new DatastructuresPolynomials.Polynomials();

        Start:
            int key = 0;

            //Display a menu for user to choose
            do
            {

                Console.WriteLine("Choose the corresponding number to select the option");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("1. Create a Polynomial and insert it into S");
                Console.WriteLine("2. Add two polynomials from S and insert the resultant polynomial into S");
                Console.WriteLine("3. Multiply two polynomials from S and insert the resultant polynomial into S");
                Console.WriteLine("4. Delete the polynomial from S at a given index");
                Console.WriteLine("5. Evaluate the polynomial from S at a given index");
                Console.WriteLine("6. Exit");

                Console.Write("\nEnter option(1-6): \t");
                key = Convert.ToInt32(Console.ReadLine());

                //Calls corresponding function for each menu option
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
            int keyP;
            int keyQ;

            Console.Clear();
            Console.WriteLine("Add two polynomials from S and insert the resultant polynomial into S");
            Console.WriteLine("-----------------------------------------------------------------------------");

            if(S.Size() == 0)
            {
                Console.WriteLine("Please populate the polynomials list S before adding!");
            }
            else
            {
                Console.WriteLine("Polynomials in List S:\n");
                Console.WriteLine("{0,8}{1,30}", "Key", "Polynomial");
                Console.WriteLine("-----------------------------------------------------------------------------");
                for (int i = 0; i < S.Size(); i++)
                {
                    Console.Write("{0,8}{1,20}", i, "");
                    S.Retrieve(i).Print();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.Write("Enter key corresponding to p:\t");
                keyP = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter key corresponding to q:\t");
                keyQ = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Console.WriteLine($"\nAdding terms p and q:");
                    Console.Write("p:\t");
                    S.Retrieve(keyP).Print();
                    Console.Write("\nq:\t");
                    S.Retrieve(keyQ).Print();

                    DatastructuresLinkedList.Polynomial sum = new DatastructuresLinkedList.Polynomial();
                    sum = S.Retrieve(keyP) + S.Retrieve(keyQ);
                    Console.Write("\np + q: \t");
                    sum.Print();

                    Console.WriteLine("\n\nInserting p + q into list S");
                    S.Insert(S.Retrieve(keyP) + S.Retrieve(keyQ));
                    Console.WriteLine("List S:");
                    S.Print();
                }
                catch(Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    Console.WriteLine("Key entered does not exist");
                    Console.WriteLine("----------------------------------------------");
                }
                
            }

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MultiplyPolynomial(DatastructuresPolynomials.Polynomials S)
        {
            int keyP;
            int keyQ;

            Console.Clear();
            Console.WriteLine("Multiply two polynomials from S and insert the resultant polynomial into S");
            Console.WriteLine("-----------------------------------------------------------------------------");

            if (S.Size() == 0)
            {
                Console.WriteLine("Please populate the polynomials list S before multiplying!");
            }
            else
            {
                Console.WriteLine("Polynomials in List S:\n");
                Console.WriteLine("{0,8}{1,30}", "Key", "Polynomial");
                Console.WriteLine("-----------------------------------------------------------------------------");
                for (int i = 0; i < S.Size(); i++)
                {
                    Console.Write("{0,8}{1,20}", i, "");
                    S.Retrieve(i).Print();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.Write("Enter key corresponding to p:\t");
                keyP = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter key corresponding to q:\t");
                keyQ = Convert.ToInt32(Console.ReadLine());
                
                try
                {
                    Console.WriteLine($"\nMultiplying terms p and q:");
                    Console.Write("p:\t");
                    S.Retrieve(keyP).Print();
                    Console.Write("\nq:\t");
                    S.Retrieve(keyQ).Print();

                    DatastructuresLinkedList.Polynomial product = new DatastructuresLinkedList.Polynomial();
                    product = S.Retrieve(keyP) * S.Retrieve(keyQ);
                    Console.Write("\np * q: \t");
                    product.Print();

                    Console.WriteLine("\n\nInserting p * q into list S");
                    S.Insert(S.Retrieve(keyP) * S.Retrieve(keyQ));
                    Console.WriteLine("List S:");
                    S.Print();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    Console.WriteLine("Key entered does not exist");
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DeletePolynomial(DatastructuresPolynomials.Polynomials S)
        {
            int key;

            Console.Clear();
            Console.WriteLine("Delete the polynomial from S at a given index");
            Console.WriteLine("-----------------------------------------------------------------------------");

            if (S.Size() == 0)
            {
                Console.WriteLine("Please populate the polynomials list S before deleting!");
            }
            else
            {
                Console.WriteLine("Polynomials in List S:\n");
                Console.WriteLine("{0,8}{1,30}", "Key", "Polynomial");
                Console.WriteLine("-----------------------------------------------------------------------------");
                for (int i = 0; i < S.Size(); i++)
                {
                    Console.Write("{0,8}{1,20}", i, "");
                    S.Retrieve(i).Print();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.Write("Enter key corresponding to the polynomial to be deleted:\t");
                key = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Console.WriteLine("\n\nDeleting polynomial from list S");
                    Console.Write("\nPolynomial to be deleted:\t");
                    S.Retrieve(key).Print();
                    S.Delete(key);
                    Console.WriteLine("\n\nList S:");
                    S.Print();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    Console.WriteLine("Key entered does not exist");
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void EvaluatePolynomial(DatastructuresPolynomials.Polynomials S)
        {
            int key;
            double x;
            double result;

            Console.Clear();
            Console.WriteLine("Delete the polynomial from S at a given index");
            Console.WriteLine("-----------------------------------------------------------------------------");

            if (S.Size() == 0)
            {
                Console.WriteLine("Please populate the polynomials list S before evaluating!");
            }
            else
            {
                Console.WriteLine("Polynomials in List S:\n");
                Console.WriteLine("{0,8}{1,30}", "Key", "Polynomial");
                Console.WriteLine("-----------------------------------------------------------------------------");
                for (int i = 0; i < S.Size(); i++)
                {
                    Console.Write("{0,8}{1,20}", i, "");
                    S.Retrieve(i).Print();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
             
                try
                {
                    Console.Write("Enter key corresponding to the polynomial to be evaluated:\t");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter the value of x:\t");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nEvaluating polynomial from list S:");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("\nPolynomial to be evaluated:\t");
                    S.Retrieve(key).Print();
                    Console.WriteLine($"\nx = {x}");
                    result = S.Retrieve(key).Evaluate(x);
                    Console.WriteLine($"Result: {result}");
                }
                catch(FormatException f)
                {
                    Console.WriteLine("\n" + f.Message);
                    Console.WriteLine("Invalid value of x");
                    Console.WriteLine("----------------------------------------------");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    Console.WriteLine("Key entered does not exist");
                    Console.WriteLine("----------------------------------------------");
                }
                
            }

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

//Tests

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

//Datastructures.TermTest.TestTerm();
//Datastructures.TermTest.TestEvaluate();
//Datastructures.TermTest.TestCompareTo();

