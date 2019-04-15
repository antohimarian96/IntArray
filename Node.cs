using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }


        public Node(T value, Node<T> next = null, Node<T> previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
