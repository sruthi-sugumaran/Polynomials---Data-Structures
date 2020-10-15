using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    class TermTest
    {
        public static void TestTerm()
        {
            Console.Clear();

            Console.WriteLine("Testing Term Class");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 1: Term() - Constructor");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 4.1.1:");
            Console.WriteLine("When coefficient is positive");
            Term term1 = new Term(62, 4);
            Console.WriteLine($"Term: {term1}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.1.2:");
            Console.WriteLine("When coefficient is negative");
            Term term2 = new Term(-4, 8);
            Console.WriteLine($"Term: {term2}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.1.3:");
            Console.WriteLine("When coefficient is decimal");
            Term term3 = new Term(9.8, 2);
            Console.WriteLine($"Term: {term3}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.1.4:");
            Console.WriteLine("When coefficient is zero");
            Term term4 = new Term(0, 0);
            Console.WriteLine($"Term: {term4}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.1.5:");
            Console.WriteLine("When exponent is less than 0");
            Term term5 = new Term(2, -4);
            Console.WriteLine($"Term: {term5}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.1.6:");
            Console.WriteLine("When exponent is greater than 99");
            Term term6 = new Term(3.4, 101);
            Console.WriteLine($"Term: {term6}");
            Console.WriteLine("\n");

            Console.WriteLine("End of Term() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestEvaluate()
        {
            Console.Clear();

            Console.WriteLine("Testing Term Class");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 2: Evaluate()");
            Console.WriteLine("------------------------------------------------------------------");

            Term term = new Term(2, 3);
            double x1 = 2;
            double x2 = -1;
            double x3 = 0;
            double x4 = -0.5;

            Console.WriteLine("Scenario 4.2.1:");
            Console.WriteLine("When x is greater than 0");
            Console.WriteLine($"Term: {term}");
            Console.WriteLine($"x: {x1}");
            Console.WriteLine($"Evaluate Result: {term.Evaluate(x1)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.2.2:");
            Console.WriteLine("When x is less than 0");
            Console.WriteLine($"Term: {term}");
            Console.WriteLine($"x: {x2}");
            Console.WriteLine($"Evaluate Result: {term.Evaluate(x2)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.2.3:");
            Console.WriteLine("When x is equal to 0");
            Console.WriteLine($"Term: {term}");
            Console.WriteLine($"x: {x3}");
            Console.WriteLine($"Evaluate Result: {term.Evaluate(x3)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 4.2.4:");
            Console.WriteLine("When x is a decimal value");
            Console.WriteLine($"Term: {term}");
            Console.WriteLine($"x: {x4}");
            Console.WriteLine($"Evaluate Result: {term.Evaluate(x4)}");
            Console.WriteLine("\n");

            Console.WriteLine("End of Evaluate() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestCompareTo()
        {
            Console.Clear();

            Console.WriteLine("Testing Term Class");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 3: CompareTo()");
            Console.WriteLine("------------------------------------------------------------------");

            Term term1 = new Term(5, 3);
            Term term2 = new Term(-9.8, 2);

            Console.WriteLine("Scenario 4.3.1:");
            Console.WriteLine("When term1 > term2");
            Console.WriteLine($"Term1: {term1}");
            Console.WriteLine($"Term2: {term2}");
            Console.WriteLine($"CompareTo Result: {term1.CompareTo(term2)}");
            Console.WriteLine("\n");

            term1 = new Term(-9.8, 2); ;

            Console.WriteLine("Scenario 4.3.2:");
            Console.WriteLine("When term1 = term2");
            Console.WriteLine($"Term1: {term1}");
            Console.WriteLine($"Term2: {term2}");
            Console.WriteLine($"CompareTo Result: {term1.CompareTo(term2)}");
            Console.WriteLine("\n");

            term2 = new Term(5, 3);

            Console.WriteLine("Scenario 4.3.3:");
            Console.WriteLine("When term1 < term2");
            Console.WriteLine($"Term1: {term1}");
            Console.WriteLine($"Term2: {term2}");
            Console.WriteLine($"CompareTo Result: {term1.CompareTo(term2)}");
            Console.WriteLine("\n");

            Console.WriteLine("End of CompareTo() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
