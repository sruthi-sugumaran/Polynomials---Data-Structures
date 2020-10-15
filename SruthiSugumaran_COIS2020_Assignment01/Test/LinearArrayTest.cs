using Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLinearArray
{
    class PolynomialLinearArrayTest
    {
        public static void TestAddTerm()
        {
            Term term1 = new Term(2, 3);
            Term term2 = new Term(4, 5);
            Term term3 = new Term(-3, 7);
            Term term4 = new Term(6, 2);
            Term term5 = new Term(-5, 1);
            Term term6 = new Term(1, 3);
            Term term7 = new Term(-7, 2);
            Term term8 = new Term(2, 6);
            Term term9 = new Term(-4, 5);
            Term term10 = new Term(6, 5);

            Polynomial polynomial = new Polynomial();

            Console.WriteLine("Testing Polynomial Class - Linear Array Implementation");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 1: AddTerm()");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 2.1.1:");
            Console.WriteLine($"Term1:\t{term1}");
            Console.Write("Polynomial 'polynomial' before adding new term1: ");
            polynomial.Print();
            polynomial.AddTerm(term1);
            Console.Write("\nPolynomial 'polynomial' after adding new term1: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.2:");
            Console.WriteLine($"Term2:\t{term2}");
            Console.Write("Polynomial 'polynomial' before adding term2: ");
            polynomial.Print();
            polynomial.AddTerm(term2);
            Console.Write("\nPolynomial 'polynomial' after adding term2: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.3:");
            Console.WriteLine($"Term3:\t{term3}");
            Console.Write("Polynomial 'polynomial' before adding term3: ");
            polynomial.Print();
            polynomial.AddTerm(term3);
            Console.Write("\nPolynomial 'polynomial' after adding term3: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.4:");
            Console.WriteLine($"Term4:\t{term4}");
            Console.Write("Polynomial 'polynomial' before adding term4: ");
            polynomial.Print();
            polynomial.AddTerm(term4);
            Console.Write("\nPolynomial 'polynomial' after adding term4: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.5:");
            Console.WriteLine($"Term5:\t{term5}");
            Console.Write("Polynomial 'polynomial' before adding term5: ");
            polynomial.Print();
            polynomial.AddTerm(term5);
            Console.Write("\nPolynomial 'polynomial' after adding term5: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.6:");
            Console.WriteLine($"Term6:\t{term6}");
            Console.Write("Polynomial 'polynomial' before adding term6: ");
            polynomial.Print();
            polynomial.AddTerm(term6);
            Console.Write("\nPolynomial 'polynomial' after adding term6: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.7:");
            Console.WriteLine($"Term7:\t{term7}");
            Console.Write("Polynomial 'polynomial' before adding term7: ");
            polynomial.Print();
            polynomial.AddTerm(term7);
            Console.Write("\nPolynomial 'polynomial' after adding term7: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.8:");
            Console.WriteLine($"Term8:\t{term8}");
            Console.Write("Polynomial 'polynomial' before adding term8: ");
            polynomial.Print();
            polynomial.AddTerm(term8);
            Console.Write("\nPolynomial 'polynomial' after adding term8: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.9:");
            Console.WriteLine($"Term9:\t{term9}");
            Console.Write("Polynomial 'polynomial' before adding term9: ");
            polynomial.Print();
            polynomial.AddTerm(term9);
            Console.Write("\nPolynomial 'polynomial' after adding term9: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.1.10:");
            Console.WriteLine($"Term10:\t{term10}");
            Console.Write("Polynomial 'polynomial' before adding term10: ");
            polynomial.Print();
            polynomial.AddTerm(term10);
            Console.Write("\nPolynomial 'polynomial' after adding term10: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("End of AddTerm() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestEvaluate()
        {
            Term term1 = new Term(-3, 7);
            Term term2 = new Term(4, 5);
            Term term3 = new Term(0, 4);
            Term term4 = new Term(5, 1);
            Term term5 = new Term(2, 0);

            double x1 = 8;
            double x2 = 0;
            double x3 = -2;
            double x4 = 1.2;
            double x5 = -3.4;

            Polynomial polynomial = new Polynomial();

            Console.WriteLine("Testing Polynomial Class - Linear Array Implementation");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 2: Evaluate()");
            Console.WriteLine("------------------------------------------------------------------");

            polynomial.AddTerm(term1);
            polynomial.AddTerm(term2);
            polynomial.AddTerm(term3);
            polynomial.AddTerm(term4);
            polynomial.AddTerm(term5);

            Console.WriteLine("Scenario 2.2.1:");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine($"\nx1: {x1}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x1)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.2.2:");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine($"\nx2: {x2}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x2)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.2.3:");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine($"\nx3: {x3}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x3)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.2.4:");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine($"\nx4: {x4}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x4)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.2.5:");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine($"\nx5: {x5}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x5)}");
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.2.6:");
            Console.Write("Polynomial: ");
            polynomial = new Polynomial();
            Console.WriteLine($"\nx5: {x5}");
            Console.WriteLine($"Evaluate Result: {polynomial.Evaluate(x5)}");
            Console.WriteLine("\n");

            Console.WriteLine("End of Evaluate() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestPrint()
        {
            Term term1 = new Term(6.7, 4);
            Term term2 = new Term(-4, 3);
            Term term3 = new Term(0, 2);
            Term term4 = new Term(2.6, 0);

            Polynomial polynomial = new Polynomial();

            Console.WriteLine("Testing Polynomial Class - Linear Array Implementation");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 3: Print()");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 2.3.1:");
            Console.WriteLine("When polynomial is empty");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.3.2:");
            polynomial.AddTerm(term1);
            Console.WriteLine("When polynomial has only one term");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.3.3:");
            polynomial.AddTerm(term2);
            polynomial.AddTerm(term3);
            polynomial.AddTerm(term4);
            Console.WriteLine("When polynomial has more than one term");
            Console.Write("Polynomial: ");
            polynomial.Print();
            Console.WriteLine("\n");

            Console.WriteLine("End of Print() tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestPlusOperator()
        {
            Term term1 = new Term(6, 8);
            Term term2 = new Term(5.8, 4);
            Term term3 = new Term(-3, 2);
            Term term4 = new Term(2, 0);

            Polynomial polynomial1 = new Polynomial();
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);
            polynomial1.AddTerm(term3);

            Term term5 = new Term(9.8, 8);
            Term term6 = new Term(3, 2);
            Term term7 = new Term(-8.5, 1);

            Polynomial polynomial2 = new Polynomial();
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);
            polynomial2.AddTerm(term7);

            Polynomial polynomialSum = new Polynomial();

            Console.WriteLine("Testing Polynomial Class - Linear Array Implementation");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 4: + operator");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 2.4.1:");
            Console.WriteLine("When p and q has equal number of terms");
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Sum: ");
            polynomialSum = polynomial1 + polynomial2;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.4.2:");
            Console.WriteLine("When p has more terms than q");
            polynomial1.AddTerm(term4);
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Sum: ");
            polynomialSum = polynomial1 + polynomial2;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.4.3:");
            Console.WriteLine("When q has more terms than p");
            Console.Write("p: ");
            polynomial2.Print();
            Console.Write("\nq: ");
            polynomial1.Print();
            Console.Write("\nPolynomial Sum: ");
            polynomialSum = polynomial2 + polynomial1;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.4.4:");
            Console.WriteLine("When p is null/empty");
            Polynomial emptyPolynomial = new Polynomial();
            Console.Write("p: ");
            emptyPolynomial.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Sum: ");
            //polynomialSum = emptyPolynomial + polynomial2;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.4.5:");
            Console.WriteLine("When q is null/empty");
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            emptyPolynomial.Print();
            Console.Write("\nPolynomial Sum: ");
            //polynomialSum = polynomial1 + emptyPolynomial;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.4.6:");
            Console.WriteLine("When p and q are null/empty");
            Console.Write("p: ");
            emptyPolynomial.Print();
            Console.Write("\nq: ");
            emptyPolynomial.Print();
            Console.Write("\nPolynomial Sum: ");
            //polynomialSum = emptyPolynomial + emptyPolynomial;
            polynomialSum.Print();
            Console.WriteLine("\n");

            Console.WriteLine("End of + operator tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TestMultiplyOperator()
        {
            Term term1 = new Term(6, 8);
            Term term2 = new Term(5.8, 4);
            Term term3 = new Term(-3, 2);

            Polynomial polynomial1 = new Polynomial();
            polynomial1.AddTerm(term1);
            polynomial1.AddTerm(term2);

            Term term5 = new Term(9.8, 8);
            Term term6 = new Term(-8.5, 1);

            Polynomial polynomial2 = new Polynomial();
            polynomial2.AddTerm(term5);
            polynomial2.AddTerm(term6);

            Polynomial polynomialProduct = new Polynomial();

            Console.WriteLine("Testing Polynomial Class - Linear Array Implementation");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Method 5: * operator");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Scenario 2.5.1:");
            Console.WriteLine("When p and q has equal number of terms");
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Product: ");
            polynomialProduct = polynomial1 * polynomial2;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.5.2:");
            Console.WriteLine("When p has more terms than q");
            polynomial1.AddTerm(term3);
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Product: ");
            polynomialProduct = polynomial1 * polynomial2;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.5.3:");
            Console.WriteLine("When q has more terms than p");
            Console.Write("p: ");
            polynomial2.Print();
            Console.Write("\nq: ");
            polynomial1.Print();
            Console.Write("\nPolynomial Product ");
            polynomialProduct = polynomial2 * polynomial1;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.5.4:");
            Console.WriteLine("When p is null/empty");
            Polynomial emptyPolynomial = new Polynomial();
            Console.Write("p: ");
            emptyPolynomial.Print();
            Console.Write("\nq: ");
            polynomial2.Print();
            Console.Write("\nPolynomial Product: ");
            //polynomialProduct = emptyPolynomial * polynomial2;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.5.5:");
            Console.WriteLine("When q is null/empty");
            Console.Write("p: ");
            polynomial1.Print();
            Console.Write("\nq: ");
            emptyPolynomial.Print();
            Console.Write("\nPolynomial Product: ");
            //polynomialProduct = polynomial1 * emptyPolynomial;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Scenario 2.5.6:");
            Console.WriteLine("When p and q are null/empty");
            Console.Write("p: ");
            emptyPolynomial.Print();
            Console.Write("\nq: ");
            emptyPolynomial.Print();
            Console.Write("\nPolynomial Product: ");
            polynomialProduct = emptyPolynomial * emptyPolynomial;
            polynomialProduct.Print();
            Console.WriteLine("\n");

            Console.WriteLine("End of * operator tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
