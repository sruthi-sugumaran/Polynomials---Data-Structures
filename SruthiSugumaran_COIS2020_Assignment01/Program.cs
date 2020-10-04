//It is a test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace SruthiSugumaran_COIS2020_Assignment01
{
    public class Term: IComparable
    {
        //Data members and their corresponding properties
        private double coefficient;
        private int exponent;

        public double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }

        public int Exponent
        {
            get { return exponent; }
            set {
                if (value < 0 || value > 99)
                    throw new ArgumentOutOfRangeException("Exponent must be between 0 and 99"); 
                else
                    exponent = value; 
            }
        }

        //Creates a term with the given coefficient and exponent
        public Term(double coefficient, int exponent)
        {
            this.Coefficient = coefficient;
            this.Exponent = exponent;
        }

        //Evaluates the current term at x
        public double Evaluate(double x)
        {
            double value = 0;
            value = this.Coefficient * Math.Pow(x, this.Exponent);
            return value;
        }

        //Returns -1,0, or 1 if the exponent of the current term 
        //is less than, equal to, or greater than the exponent of obj
        public int CompareTo(object obj)
        {
            if (obj is Term)
            {
                Term newObj = (Term)obj;
                if (this.Exponent < newObj.Exponent)
                    return -1;
                else if (this.Exponent > newObj.Exponent)
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new ArgumentException("Enter a valid term");
            }
        }

        //Returns a string representation of the current term
        public override string ToString()
        {
            return this.Coefficient.ToString() + $"(x^{this.Exponent})";
        }
    }

    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        public Node(T item, Node<T> next)
        {
            this.Item = item;
            this.Next = next;
        }
    }

    public class Polynomial
    {
        //A reference to the first node of a singly linked list
        private Node<Term> front;

        //Creates the polynomial 0
        public Polynomial()
        {
            this.front = null;
        }
        
        //Inserts term t into the current polynomial in its proper order
        //If a term with the same exponent already exists then the two terms are added together
        public void AddTerm(Term t)
        {
            Node<Term> toAdd = new Node<Term>(t, null);
            Node<Term> current = this.front;
            if(front == null)
            {
                this.front = toAdd;
            }
            else if(front.Item.Exponent < toAdd.Item.Exponent)
            {
                toAdd.Next = front;
                this.front = toAdd;
            }
            else
            {
                int flag = 0;

                while (current != null)
                {
                    if (current.Next == null)
                        break;

                    if(current.Item.Exponent == toAdd.Item.Exponent)
                    {
                        current.Item.Coefficient += toAdd.Item.Coefficient;
                        flag = 1;
                        break;
                    }

                    if(current.Next.Item.Exponent < toAdd.Item.Exponent)
                    {
                        toAdd.Next = current.Next;
                        current.Next = toAdd;
                        break;
                    }

                    current = current.Next;
                }

                if(flag == 0)
                    current.Next = toAdd;
            }
            //Note to Sruthi: Implement linked list tranversal
        }

        //Adds polynomials p and q to yield a new polynomial
        public static Polynomial operator + (Polynomial p, Polynomial q)
        {
            return null;
        }

        //Multiplies polynomials p and q to yield a new polynomial
        public static Polynomial operator * (Polynomial p, Polynomial q)
        {
            return null;
        }

        //Evaluates the current polynomial at x
        public double Evaluate(double x)
        {
            return 0;
        }

        //Prints the current polynomial
        public void Print()
        {
            Node<Term> current = this.front;
            while(current!=null)
            {
                Console.Write(current.Item);
                if (current.Next != null)
                    Console.Write(" + ");
                current = current.Next;
            }
        }
    }

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
            
            

            //Checking polynomial list
            Console.WriteLine("\n\nChecking polynomial list");
            Polynomial p1 = new Polynomial();

            Console.WriteLine("\nAdding term1: 2(x^3)");
            p1.AddTerm(term1);
            Console.Write("Result:");
            p1.Print();

            Console.WriteLine("\n\nAdding term2: 4(x^3)");
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

            Console.WriteLine("");
        }
    }
}
