using System;
using Xunit;
using Array;

namespace ExceptionsFacts
{
    public class ExceptionsFacts
    {
        [Fact]
        public void Exemple()
        {
            int object1 = -132;
            Assert.Throws<ArgumentOutOfRangeException>(() => SquareArea(object1));
        }

        private int SquareArea(int length)
        {
                int result = 0;
                if (length < 0)
                    throw new ArgumentOutOfRangeException("Length must be at least 0");
                else
                    result = length * length;
                return length;
        }

        [Fact]
        public void CopyToFactWhenArrayIsEmpty()
        {
            var firstArrayInt = new List<int> { 1, 2, 3, 4 };
            int[] secondArrayInt = { };
            Assert.Throws<ArgumentNullException>(() => firstArrayInt.CopyTo(secondArrayInt, 2));
        }

        [Fact]
        public void CopyToFactWhenIndexArrayIsLessThanZero()
        {
            var firstArrayInt = new List<int> { 1, 2, 3, 4 };
            int[] secondArrayInt = { 4, 5, 6, 7, 8 };
            Assert.Throws<ArgumentOutOfRangeException>(() => firstArrayInt.CopyTo(secondArrayInt, -2));
        }

        [Fact]
        public void RemoveAtFact()
        {
            var array = new List<char> { 'a', 'b', 'c', 'd' };
            Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveAt(-2));
        }

        [Fact]
        public void InsertFact()
        {
            var array = new List<char> { 'a', 'b', 'c', 'd' };
            Assert.Throws<ArgumentOutOfRangeException>(() => array.Insert(-2, '1'));
        }
    }
}
