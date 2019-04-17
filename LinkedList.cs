using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class LinkedList<T>: ICollection<T>
    {
        private Node<T> head;
        public int Count { get; protected set; }
        public bool IsReadOnly { get; }

        public LinkedList()
        {
            head = new Node<T>(default(T));
            head.Previous = head;
            head.Next = head;
            Count = 0;
        }

        public void AddFirst(Node<T> newNode)
        {
            AddNode(newNode, head.Next);
        }

        public void AddLast(Node<T> newNode)
        {
            AddNode(newNode, head);
        }

        public void AddBefore(Node<T> newNode, Node<T> node)
        {
            CheckIfNodeBelongsToAnotherList(node);
            AddNode(newNode, node);
        }

        public void AddBefore(Node<T> newNode, T element)
        {
            AddBefore(newNode, Find(element));
        }

        public void AddAfter(Node<T> newNode, Node<T> node)
        {
            CheckIfNodeBelongsToAnotherList(node);
            AddNode(newNode, node.Next);
        }

        public void AddAfter(Node<T> newNode, T element)
        {
            AddNode(newNode, Find(element).Next);
        }

        private void AddNode(Node<T> newNode, Node<T> node)
        {
            Count++;
            CheckIfNodeIsNull(newNode);
            CheckIfNodeBelongsToAnotherList(newNode);
            CheckNodeLinks(newNode);
            newNode.Next = node;
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            node.Previous = newNode;
            newNode.List = this;
        }

        public Node<T> Find(T element)
        {
            var current = head.Next;
            while (current != head) 
            {
                if (Equals(current.Value, element))
                    return current;
                current = current.Next;
            }
            throw new InvalidOperationException();
        }

        private void CheckNodeLinks(Node<T> node)
        {
            if (node.Next != null || node.Previous != null)
                throw new InvalidOperationException();
        }

        private void CheckIfNodeBelongsToAnotherList(Node<T> node)
        {
            if(node.List != this && node.List != null)
                throw new InvalidOperationException();
        }

        private void CheckIfNodeIsNull(Node<T> node)
        {
            if (node == null)
                throw new ArgumentNullException();
        }

        public void Clear()
        {
            Count = 0;
            head.Previous = head;
            head.Next = head;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }
    }
}
