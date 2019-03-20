using System;
using Xunit;
using Array;

namespace ObjectArrayFacts
{
    public class ListFacts
    {
        [Fact]
        public void AddFact()
        {
            var array = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(1, array[0]);
            Assert.Equal(2, array[1]);
            Assert.Equal(3, array[2]);
            Assert.Equal(4, array[3]);
        }

        [Fact]
        public void SetAndGetFact()
        {
            var array = new List<string>
            {
                [0] = "a",
                [1] = "b",
                [2] = "c",
                [3] = "d"
            };
            Assert.Equal("a", array[0]);
            Assert.Equal("b", array[1]);
            Assert.Equal("c", array[2]);
            Assert.Equal("d", array[3]);
        }

        [Fact]
        public void CointainsFact()
        {
            var array = new List<double> { 1, 3.5, 1.2, 4.5 };
            array[0] = 2;
            array[1] = 3.2;
            array[2] = 0;
            array[3] = 1;
            Assert.True(array.Contains(2));
            Assert.True(array.Contains(3.2));
            Assert.False(array.Contains(1.1231));
        }

        [Fact]
        public void IndexOfFact()
        {
            var array = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(0, array.IndexOf(1));
            Assert.Equal(3, array.IndexOf(4));
        }

        [Fact]
        public void InsertFact()
        {
            var array = new List<int>();
            array.Add(1);
            array.Insert(0,2);
            array.Insert(1, 3);
            array.Add(4);
            array.Insert(3, 5);
            Assert.Equal(5, array[3]);
            Assert.Equal(2, array[0]);
        }

        [Fact]
        public void ClearFact()
        {
            var array = new List<string> {"abc","def","ghi"};
            array.Clear();
        }

        [Fact]
        public void RemoveAtFact()
        {
            var array = new List<char> { 'a', 'b', 'c', 'd' };
            array.RemoveAt(0);
            array.RemoveAt(1);
            Assert.Equal('b', array[0]);
            Assert.Equal('d', array[1]);
        }

        [Fact]
        public void RemoveFact()
        {
            var array = new List<string> { "Ana", "are", "multe", "mere" };
            array.Remove("Ana");
            array.Remove("are");
            Assert.Equal("multe", array[0]);
            Assert.Equal("mere", array[1]);
        }
    }
}
