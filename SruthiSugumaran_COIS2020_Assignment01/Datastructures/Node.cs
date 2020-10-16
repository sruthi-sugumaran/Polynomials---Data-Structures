using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLinkedList
{
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
}
