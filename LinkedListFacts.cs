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
        public void CheckIfNodeBelongsToAnotherList()
        {

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
    }
}
