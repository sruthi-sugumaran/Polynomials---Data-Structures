using Datastructures;
using DatastructuresLinearArray;
using DatastructuresLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresPolynomials
{
    class PolynomialsTest
    {
        public static void TestInsert()
        {
            Console.Clear();
            Polynomials S = new Polynomials();

            DatastructuresLinkedList.Polynomial emptyPolynomial = new DatastructuresLinkedList.Polynomial();

            DatastructuresLinkedList.Polynomial polynomial1 = new DatastructuresLinkedList.Polynomial();
            Term term1 = new Term(8, 5);
            Term term2 = new Term(12, 4);
            Term term3 = new Term(2, 3);
            Term term4 = new Term(6, 2);
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);
            polynomial1.AddTerm(term4);

            DatastructuresLinkedList.Polynomial polynomial2 = new DatastructuresLinkedList.Polynomial();
            Term term5 = new Term(6, 4);
            Term term6 = new Term(-16, 2);
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            DatastructuresLinkedList.Polynomial polynomial3 = new DatastructuresLinkedList.Polynomial();
            polynomial3.AddTerm(term2);
            polynomial3.AddTerm(term6);
            polynomial3.AddTerm(term3);

            Console.WriteLine("Testing Polynomials Class - List<Polynomial>");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 1: Insert()");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 3.1.1:");
            Console.Write("Polynomial1:\t");
            polynomial1.Print();
            Console.Write("\nPolynomials S before adding new polynomial1:\n");
            S.Print();
            S.Insert(polynomial1);
            Console.Write("\nPolynomial S after adding new polynomial1:\n");
            S.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 3.1.2:");
            Console.Write("Polynomial2:\t");
            polynomial2.Print();
            Console.Write("\nPolynomials S before adding new polynomial2:\n");
            S.Print();
            S.Insert(polynomial2);
            Console.Write("Polynomial S after adding new polynomial2:\n");
            S.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 3.1.3:");
            Console.Write("Polynomial3:\t");
            polynomial3.Print();
            Console.Write("\nPolynomials S before adding new polynomial3:\n");
            S.Print();
            S.Insert(polynomial3);
            Console.Write("Polynomial S after adding new polynomial3:\n");
            S.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 3.1.4:");
            Console.Write("Polynomial2:\t");
            emptyPolynomial.Print();
            Console.Write("\nPolynomials S before adding new empty polynomial:\n");
            S.Print();
            S.Insert(emptyPolynomial);
            Console.Write("Polynomial S after adding new empty polynomial:\n");
            S.Print();
            Console.WriteLine("\n");

            Console.WriteLine("End of Insert() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestRetrieve()
        {
            Console.Clear();

            Polynomials S = new Polynomials();

            DatastructuresLinkedList.Polynomial polynomial1 = new DatastructuresLinkedList.Polynomial();
            Term term1 = new Term(8, 5);
            Term term2 = new Term(12, 4);
            Term term3 = new Term(2, 3);
            Term term4 = new Term(6, 2);
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);
            polynomial1.AddTerm(term4);

            DatastructuresLinkedList.Polynomial polynomial2 = new DatastructuresLinkedList.Polynomial();
            Term term5 = new Term(6, 4);
            Term term6 = new Term(-16, 2);
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            DatastructuresLinkedList.Polynomial polynomial3 = new DatastructuresLinkedList.Polynomial();
            polynomial3.AddTerm(term2);
            polynomial3.AddTerm(term6);
            polynomial3.AddTerm(term3);


            Console.WriteLine("Testing Polynomials Class - List<Polynomial>");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 2: Retrieve()");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("Scenario 3.2.1:");
            Console.Write("S:\n");
            S.Print();
            Console.Write($"\nindex1 = {0}\n");
            Console.Write($"Polynomial at index{0}:\t");
            S.Retrieve(0).Print();
            Console.WriteLine("\n");

            S.Insert(polynomial1);
            S.Insert(polynomial2);
            S.Insert(polynomial3);

            Console.WriteLine("Scenario 3.2.2:");
            Console.Write("S:\n");
            S.Print();
            Console.Write($"\nindex1 = {0}\n");
            Console.Write($"Polynomial at index{0}:\t");
            S.Retrieve(0).Print();
            Console.WriteLine("\n\n");

            Console.WriteLine("Scenario 3.2.3:");
            Console.Write("S:\n");
            S.Print();
            Console.Write($"\nindex2 = {1} [<count]\n");
            Console.Write($"Polynomial at index{1}:\t");
            S.Retrieve(1).Print();
            Console.WriteLine("\n\n");

            Console.WriteLine("Scenario 3.2.4:");
            Console.Write("S:\n");
            S.Print();
            Console.Write($"\nindex3 = {2} [count - 1]\n");
            Console.Write($"Polynomial at index{2}:\t");
            S.Retrieve(2).Print();
            Console.WriteLine("\n\n");

            Console.WriteLine("Scenario 3.2.5:");
            Console.Write("S:\n");
            S.Print();
            Console.Write($"\nindex4 = {5} [>= count]\n");
            Console.Write($"Polynomial at index{5}:\t");
            S.Retrieve(5).Print();
            Console.WriteLine("\n\n");


            Console.WriteLine("End of Retrieve() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestDelete()
        {
            Console.Clear();

            Polynomials S = new Polynomials();

            DatastructuresLinkedList.Polynomial polynomial1 = new DatastructuresLinkedList.Polynomial();
            Term term1 = new Term(8, 5);
            Term term2 = new Term(12, 4);
            Term term3 = new Term(2, 3);
            Term term4 = new Term(6, 2);
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);
            polynomial1.AddTerm(term4);

            DatastructuresLinkedList.Polynomial polynomial2 = new DatastructuresLinkedList.Polynomial();
            Term term5 = new Term(6, 4);
            Term term6 = new Term(-16, 2);
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            DatastructuresLinkedList.Polynomial polynomial3 = new DatastructuresLinkedList.Polynomial();
            polynomial3.AddTerm(term2);
            polynomial3.AddTerm(term6);
            polynomial3.AddTerm(term3);

            Console.WriteLine("Testing Polynomials Class - List<Polynomial>");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 3: Delete()");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 3.3.1:");
            Console.Write($"\nindex 1 = {0}");
            Console.Write($"\nPolynomials S before deleting polynomial at {0}:\n");
            S.Print();
            //S.Delete(0);
            Console.Write($"\nPolynomial S after deleting polynomial at {0}:\n");
            S.Print();
            Console.WriteLine("\n");


            S.Insert(polynomial1);
            S.Insert(polynomial2);
            S.Insert(polynomial3);

            Console.WriteLine("Scenario 3.3.2:");
            Console.Write($"\nindex 2 = {0}");
            Console.Write($"\nPolynomials S before deleting polynomial at {0}:\n");
            S.Print();
            S.Delete(0);
            Console.Write($"\nPolynomial S after deleting polynomial at {0}:\n");
            S.Print();
            Console.WriteLine("\n\n");

            S.Insert(polynomial1);

            Console.WriteLine("Scenario 3.3.3:");
            Console.Write($"\nindex 3 = {1}");
            Console.Write($"\nPolynomials S before deleting polynomial at {1}:\n");
            S.Print();
            S.Delete(1);
            Console.Write($"\nPolynomial S after deleting polynomial at {1}:\n");
            S.Print();
            Console.WriteLine("\n\n");

            S.Insert(polynomial3);

            Console.WriteLine("Scenario 3.3.4:");
            Console.Write($"\nindex 4 = {2}");
            Console.Write($"\nPolynomials S before deleting polynomial at {2}:\n");
            S.Print();
            S.Delete(2);
            Console.Write($"\nPolynomial S after deleting polynomial at {2}:\n");
            S.Print();
            Console.WriteLine("\n\n");

            S.Insert(polynomial3);

            Console.WriteLine("Scenario 3.3.5:");
            Console.Write($"\nindex 5 = {5}");
            Console.Write($"\nPolynomials S before deleting polynomial at {5}:\n");
            S.Print();
            S.Delete(5);
            Console.Write($"\nPolynomial S after deleting polynomial at {5}:\n");
            S.Print();
            Console.WriteLine("\n\n");


            Console.WriteLine("End of Delete() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestSize()
        {
            Console.Clear();

            Polynomials S = new Polynomials();

            DatastructuresLinkedList.Polynomial polynomial1 = new DatastructuresLinkedList.Polynomial();
            Term term1 = new Term(8, 5);
            Term term2 = new Term(12, 4);
            Term term3 = new Term(2, 3);
            Term term4 = new Term(6, 2);
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);
            polynomial1.AddTerm(term4);

            DatastructuresLinkedList.Polynomial polynomial2 = new DatastructuresLinkedList.Polynomial();
            Term term5 = new Term(6, 4);
            Term term6 = new Term(-16, 2);
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            DatastructuresLinkedList.Polynomial polynomial3 = new DatastructuresLinkedList.Polynomial();
            polynomial3.AddTerm(term2);
            polynomial3.AddTerm(term6);
            polynomial3.AddTerm(term3);


            Console.WriteLine("Testing Polynomials Class - List<Polynomial>");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 4: Size()");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 3.4.1:");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.Write($"\nSize of polynomials S: {S.Size()}\n");
            Console.WriteLine("\n");

            S.Insert(polynomial1);
            Console.WriteLine("Scenario 3.4.2:");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.Write($"Size of polynomials S: {S.Size()}\n");
            Console.WriteLine("\n");

            S.Insert(polynomial2);
            S.Insert(polynomial3);
            Console.WriteLine("Scenario 3.4.3:");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.Write($"Size of polynomials S: {S.Size()}\n");
            Console.WriteLine("\n");

            Console.WriteLine("End of Size() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestPrint()
        {
            Console.Clear();

            Polynomials S = new Polynomials();

            DatastructuresLinkedList.Polynomial polynomial1 = new DatastructuresLinkedList.Polynomial();
            Term term1 = new Term(8, 5);
            Term term2 = new Term(12, 4);
            Term term3 = new Term(2, 3);
            Term term4 = new Term(6, 2);
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);
            polynomial1.AddTerm(term4);

            DatastructuresLinkedList.Polynomial polynomial2 = new DatastructuresLinkedList.Polynomial();
            Term term5 = new Term(6, 4);
            Term term6 = new Term(-16, 2);
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            DatastructuresLinkedList.Polynomial polynomial3 = new DatastructuresLinkedList.Polynomial();
            polynomial3.AddTerm(term2);
            polynomial3.AddTerm(term6);
            polynomial3.AddTerm(term3);

            Console.WriteLine("Testing Polynomials Class - List<Polynomial>");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Method 5: Print()");
            Console.WriteLine("-----------------------------------------------------------------");


            Console.WriteLine("Scenario 3.5.1:");
            Console.WriteLine("When S is empty");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.WriteLine("\n");

            S.Insert(polynomial1);
            Console.WriteLine("Scenario 3.5.2:");
            Console.WriteLine("When S has only one entry");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.WriteLine("\n");

            S.Insert(polynomial2);
            S.Insert(polynomial3);
            Console.WriteLine("Scenario 3.5.3:");
            Console.WriteLine("When S has more than one entry");
            Console.Write($"Polynomials S :\n");
            S.Print();
            Console.WriteLine("\n");


            Console.WriteLine("End of Print() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
