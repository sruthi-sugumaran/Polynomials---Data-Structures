using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures;

namespace DatastructuresLinkedList
{
    public class Polynomial
    {
        //A reference to the first node of a singly linked list
        public Datastructures.Node<Datastructures.Term> front;

        //Creates the polynomial 0
        public Polynomial()
        {
            this.front = null;
        }

        //Inserts term t into the current polynomial in its proper order
        //If a term with the same exponent already exists then the two terms are added together
        public void AddTerm(Datastructures.Term t)
        {
            Datastructures.Node<Datastructures.Term> toAdd = new Datastructures.Node<Datastructures.Term>(t, null);
            Datastructures.Node<Datastructures.Term> current = this.front;
            if (front == null)
            {
                this.front = toAdd;
            }
            else if (front.Item.Exponent < toAdd.Item.Exponent)
            {
                toAdd.Next = front;
                this.front = toAdd;
            }
            else
            {
                int flag = 0;

                while (current != null)
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
            //Note to Sruthi: Implement linked list tranversal
        }

        //Adds polynomials p and q to yield a new polynomial
        public static Polynomial operator +(Polynomial p, Polynomial q)
        {
            Polynomial result = new Polynomial();

            Datastructures.Node<Datastructures.Term> currentP = p.front;
            Datastructures.Node<Datastructures.Term> currentQ = q.front;

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
            Datastructures.Node<Datastructures.Term> currentP = p.front;
            Datastructures.Node<Datastructures.Term> currentQ = q.front;

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
            Datastructures.Node<Datastructures.Term> current = this.front;
            double value = 0;

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
            Datastructures.Node<Datastructures.Term> current = this.front;
            while (current != null)
            {
                Console.Write(current.Item);

                if (current.Next != null)
                    Console.Write(" + ");

                current = current.Next;
            }
        }
    }
}
