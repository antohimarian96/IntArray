using System;
using Xunit;
using Array;

namespace SortedListFacts
{
    public class SortedListFacts
    { 
        
        [Fact]
        public void AddFacts()
        {
            var result = new SortedList<int>();
            result.Add(3);
            result.Add(1);
            result.Add(2);
            result.Add(1);
            result.Add(10);
            result.Add(0);
            result.Add(11);
            Assert.Equal(3, result[4]);
        }

        [Fact]
        public void Insert()
        {
            var result = new SortedList<int>();
            result.Add(3);
            result.Add(1);
            result.Insert(1, 2);
            result.Insert(0, 2);
            result.Insert(0, 0);
            Assert.Equal(2, result[2]);
        }

        [Fact]
        public void SetElement()
        {
            var result = new SortedList<int>();
            result.Add(4);
            result.Add(1);
            result.Add(3);
            result[1] = 2;
            result[0] = 4;
            result[0] = 0;
            result[2] = 6;
            result[2] = 1;
            Assert.Equal(0, result[0]);
        }
    }
}

