using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLinkedList
{
    public class Polynomial
    {
        //A reference to the first node of a singly linked list
        private Node<Datastructures.Term> front;
        
        //Property for front
        public Node<Datastructures.Term> Front
        {
            get { return this.front; }
        }

        //Creates the polynomial 0
        public Polynomial()
        {
            this.front = null;
        }

        //Inserts term t into the current polynomial in its proper order
        //If a term with the same exponent already exists then the two terms are added together
        public void AddTerm(Datastructures.Term t)
        {
            Node<Datastructures.Term> toAdd = new Node<Datastructures.Term>(t, null);
            Node<Datastructures.Term> current = this.front;

            if (front == null)                                              //If the polynomial is empty
            {
                this.front = toAdd;
            }
            else if (front.Item.Exponent < toAdd.Item.Exponent)             //If the new term's exponent is greater than the exponent in fron
            {
                toAdd.Next = front;
                this.front = toAdd;
            }
            else
            {
                int flag = 0;

                while (current != null)                                     //Iterate through the linked list and place the term in proper order
                {
                    if (current.Item.Exponent == toAdd.Item.Exponent)
                    {
                        current.Item.Coefficient += toAdd.Item.Coefficient;
                        flag = 1;
                        break;
                    }

                    if (current.Next == null)
                        break;

                    if (current.Next.Item.Exponent < toAdd.Item.Exponent)
                    {
                        toAdd.Next = current.Next;
                        current.Next = toAdd;
                        break;
                    }

                    current = current.Next;
                }

                if (flag == 0)
                    current.Next = toAdd;
            }
        }

        //Adds polynomials p and q to yield a new polynomial
        public static Polynomial operator + (Polynomial p, Polynomial q)
        {
            Polynomial result = new Polynomial();

            Node<Datastructures.Term> currentP = p.front;
            Node<Datastructures.Term> currentQ = q.front;

            //Throws exception when p and/or q are empty polynomials
            if (p.front == null || q.front == null)
            {
                throw new ArgumentException("Please enter non-null polynomials");
            }

            while (currentP != null)
            {
                result.AddTerm(new Datastructures.Term(currentP.Item.Coefficient, currentP.Item.Exponent));
                currentP = currentP.Next;
            }

            while (currentQ != null)
            {
                result.AddTerm(new Datastructures.Term(currentQ.Item.Coefficient, currentQ.Item.Exponent));
                currentQ = currentQ.Next;
            }
            return result;
        }

        //Multiplies polynomials p and q to yield a new polynomial
        public static Polynomial operator *(Polynomial p, Polynomial q)
        {
            Polynomial result = new Polynomial();
            Node<Datastructures.Term> currentP = p.front;
            Node<Datastructures.Term> currentQ = q.front;

            //Throws exception when p and/or q are empty polynomials
            if (p.front == null || q.front == null)
            {
                throw new ArgumentException("Please enter non-null polynomials");
            }

            while (currentP != null)
            {
                while (currentQ != null)
                {
                    result.AddTerm(new Datastructures.Term(currentP.Item.Coefficient * currentQ.Item.Coefficient, 
                        currentP.Item.Exponent + currentQ.Item.Exponent));
                    currentQ = currentQ.Next;
                }

                currentQ = q.front;
                currentP = currentP.Next;
            }
            return result;
        }

        //Evaluates the current polynomial at x
        public double Evaluate(double x)
        {
            Node<Datastructures.Term> current = this.front;
            double value = 0;

            //Throws exception when polynomial is empty
            if (this.front == null)
            {
                throw new InvalidOperationException("Please enter non-null polynomials");
            }

            while (current != null)
            {
                value += current.Item.Evaluate(x);
                current = current.Next;
            }
            return value;
        }

        //Prints the current polynomial
        public void Print()
        {
            Node<Datastructures.Term> current = this.front;
            while (current != null)
            {
                Console.Write(current.Item);

                if (current.Next != null)
                    Console.Write(" + ");

                current = current.Next;
            }

            //Prints null if polynomial is empty
            if(this.front==null)
            {
                Console.Write("null");
            }
        }
    }
}
