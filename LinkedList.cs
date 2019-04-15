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
            Count++;
            CheckIfNodeIsNull(newNode);
            CheckIfNodeBelongsToOtherList(newNode);
            newNode.Previous = head;
            if (head.Previous == head)
            {
                head.Previous = newNode;
                newNode.Next = head;
            }
            else
            {
                newNode.Next = head.Next;
            }
            head.Next = newNode;
        }

        private void CheckIfNodeBelongsToOtherList(Node<T> node)
        {
            if (node.Next != null || node.Previous != null)
                throw new InvalidOperationException();
        }

        public void AddLast(Node<T> newNode)
        {
            Count++;
            CheckIfNodeBelongsToOtherList(newNode);
            CheckIfNodeIsNull(newNode);
            newNode.Next = head;
            if(head.Next == head)
            {
                head.Next = newNode;
                newNode.Previous = head;
            }
            else
            {
                newNode.Previous = head.Previous;
                head.Previous.Next = newNode;
            }
            head.Previous = newNode;

        }

        public void AddBefore(Node<T> node, T element)
        {
            Count++;
            CheckIfNodeIsNull(node);
            Find(node.Value);
            var current = Find(node.Value);
            Node<T> newNode = new Node<T>(element, node, null);
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            node.Previous = newNode;
            
        }

        public void AddAfter(Node<T> node, T element)
        {
            Count++;
            CheckIfNodeIsNull(node);
            Find(node.Value);
            var current = Find(node.Value);
            Node<T> newNode = new Node<T>(element, null, node);
            if (node.Next != head)
            {
                newNode.Next = node.Next;
                node.Next.Previous = newNode;
                node.Next = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                node.Next = newNode;
            }
        }

        public Node<T> Find(T element)
        {
            var current = head;
            int checkCount = 0;
            while (!Equals(current.Value,element) && checkCount <= Count)
            {
                current = current.Next;
                checkCount++;
            }
            if (Equals(current.Value, element))
                return current;
            else
                throw new InvalidOperationException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
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

        private void CheckIfNodeIsNull(Node<T> node)
        {
            if (node == null)
                throw new ArgumentNullException();
        }
    }
}
