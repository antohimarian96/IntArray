using System;
using Xunit;
using Array;

namespace LinkedListFacts
{
    public class LinkedListFacts
    {
        [Fact]
        public void AddFirstFact()
        {
            var list = new LinkedList<int>();
            list.AddFirst(new Node<int>(1));
            list.AddFirst(new Node<int>(2));
            list.AddFirst(new Node<int>(3));
            list.AddFirst(new Node<int>(4));
            Assert.Throws<ArgumentNullException>(() => list.AddFirst(null));
            Assert.Throws<InvalidOperationException>(() => list.AddFirst(new Node<int>(2, new Node<int>(3))));
        }

        [Fact]
        public void AddLastFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(1));
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(4));
            Assert.Throws<ArgumentNullException>(() => list.AddLast(null));
            Assert.Throws<InvalidOperationException>(() => list.AddLast(new Node<int>(2, new Node<int>(3))));
        }

        [Fact]
        public void AddAfterFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(1));
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(4));
            list.AddLast(new Node<int>(5));
            list.AddAfter(new Node<int>(3),list.Find(2));
            list.AddAfter(new Node<int>(6),list.Find(5));
        }

        [Fact] 
        public void AddAfterExceptionFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(1));
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(4));
            list.AddLast(new Node<int>(5));
            list.AddAfter(new Node<int>(3), list.Find(2));
            list.AddAfter(new Node<int>(6), list.Find(5));
            Assert.Throws<ArgumentNullException>(() => list.AddAfter(null, new Node<int>(3)));
            Assert.Throws<InvalidOperationException>(() => list.AddAfter(list.Find(7), new Node<int>(3)));
        }

        [Fact]
        public void AddBeforeFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
        }

        [Fact]
        public void AddBeforeExceptionFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
            Assert.Throws<ArgumentNullException>(() => list.AddBefore(null, new Node<int>(4)));
            Assert.Throws<InvalidOperationException>(() => list.AddBefore(list.Find(7), new Node<int>(4)));
        }

        [Fact]
        public void ClearFact()
        {
            var list = new LinkedList<int>();
            list.AddFirst(new Node<int>(1));
            list.AddFirst(new Node<int>(2));
            list.AddFirst(new Node<int>(3));
            list.AddFirst(new Node<int>(4));
            list.Clear();
            Assert.Equal(0,list.Count);
        }

        [Fact]
        public void ContainsFact()
        {
            var list = new LinkedList<int>();
            list.AddFirst(new Node<int>(1));
            list.AddFirst(new Node<int>(2));
            list.AddFirst(new Node<int>(3));
            list.AddFirst(new Node<int>(4));
            Assert.True(list.Contains(3));
            Assert.False(list.Contains(5));
        }

        [Fact]
        public void CopyToFact()
        {
            var list = new LinkedList<int>();
            list.AddFirst(new Node<int>(1));
            list.AddFirst(new Node<int>(2));
            list.AddFirst(new Node<int>(3));
            list.AddFirst(new Node<int>(4));
            int[] array = { 4, 5, 6, 7, 8, 9, 10 };
            list.CopyTo(array, 2);
            Assert.Equal(new int[] { 4, 5, 4, 3, 2, 1, 10 }, array);
            Assert.Throws< ArgumentOutOfRangeException> (() => list.CopyTo(array,-1));
            int[] nullArray = new int[0];
            Assert.Throws<ArgumentNullException>(() => list.CopyTo(nullArray, 1));
        }

        [Fact]
        public void FindLastFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
            list.AddLast(new Node<int>(3));
            Node<int> node = list.FindLast(3);
        }

        [Fact]
        public void Remove()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
            list.Remove(list.Find(5));
            list.Remove(4);
        }

        [Fact]
        public void RemoveFirstFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
            list.RemoveFirst();
        }

        [Fact]
        public void RemoveLastFact()
        {
            var list = new LinkedList<int>();
            list.AddLast(new Node<int>(2));
            list.AddLast(new Node<int>(3));
            list.AddLast(new Node<int>(5));
            list.AddBefore(new Node<int>(1), list.Find(2));
            list.AddBefore(new Node<int>(4), list.Find(5));
            list.RemoveLast();
        }
    }
}
