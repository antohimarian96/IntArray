using System;
using Xunit;
using Array;

namespace ArrayFacts
{
    public class ArrayFacts
    {
        [Fact]
        public void ArrayTests()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            int count = array.Count();
            Assert.Equal(2, count);
            int elementTwo = array.Element(1);
            Assert.Equal(2, elementTwo);
            array.SetElement(1, 3);
            Assert.True(array.Contains(3));
            Assert.Equal(1, array.IndexOf(3));
            array.Insert(1, 2);
            Assert.Equal(3, array.Count());
            array.Add(4);
            array.Add(7);
            array.Add(4);
            array.Add(5);
            array.Remove(4);
            array.RemoveAt(6);
            Assert.Equal(5, array.Count());
        }
    }
}
