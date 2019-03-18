using System;
using Xunit;
using Array;

namespace EnumerateFacts
{
    public class UnitTest1
    {
        [Fact]
        public void CurrentFacts()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            var result = new Enumerate(array);
            result.MoveNext();
            Assert.Equal(1, result.Current);
            result.MoveNext();
            Assert.Equal(2, result.Current);
        }

        [Fact]
        public void MoveNextFacts()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            var result = new Enumerate(array);
            result.MoveNext();
            result.MoveNext();
            result.MoveNext();
            Assert.True(result.MoveNext());
            result.MoveNext();
            Assert.False(result.MoveNext());
        }

        [Fact]
        public void ResetFacts()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            var result = new Enumerate(array);
            result.MoveNext();
            result.MoveNext();
            result.MoveNext();
            result.MoveNext();
            result.Reset();
            result.MoveNext();
            Assert.Equal(1, result.Current);
        }
    }
}
