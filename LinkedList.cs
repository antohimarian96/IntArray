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
            return TryToFind(element) ?? throw new InvalidOperationException();
        }

        private Node<T> TryToFind(T element)
        {
            for (var current = head.Next; current != head; current = current.Next)
            {
                if (Equals(current.Value, element))
                    return current;
            }
            return null;
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
            return TryToFind(item) != null;
        }

        public void CopyTo(T[] array, int index)
        {
            var current = head;
            if (array.Length == 0)
                throw new ArgumentNullException();
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (index > Count)
                throw new ArgumentException();
            for (int i = index; i < Count + index; i++)
            {
                current = current.Next;
                array[i] = current.Value;
            }
        }

        public Node<T> FindLast(T element)
        {
            var current = head.Next;
            Node<T> node = null;
            while (current != head)
            {
                if (Equals(current.Value, element))
                    node = current;
                current = current.Next;
            }
            return node;
        }

        public void Remove(Node<T> node)
        {
            CheckIfNodeIsNull(node);
            CheckIfNodeBelongsToAnotherList(node);
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            node.Next = null;
            node.Previous = null;
            node.List = null;
            Count--;
        }

        public void Remove(T item)
        {
            Remove(Find(item));
        }

        public void RemoveFirst()
        {
            Remove(head.Next);
        }

        public void RemoveLast()
        {
            Remove(head.Previous);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (var current = head.Next; current != head; current = current.Next)
            {
                yield return current.Value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var result = this;
            IEnumerable<T> enumerator = result;
            return enumerator.GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
