using System;
using Xunit;
using Array;

namespace SortedIntArrayFacts
{
    public class SortedIntArrayFacts
    {
        [Fact]
        public void AddFacts()
        {
            var result = new SortedIntArray();
            result.Add(3);
            result.Add(1);
            result.Add(2);
            result.Add(1);
            result.Add(10);
            result.Add(0);
            result.Add(11);
            Assert.Equal(3,result[4]);
        }

        [Fact]
        public void Insert()
        {
            var result = new SortedIntArray();
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
            var result = new SortedIntArray();
            result.Add(3);
            result.Add(1);
            result[1] = 2;
            result[0] = 4;
            Assert.Equal(3, result[2]);
        }
    }
}
