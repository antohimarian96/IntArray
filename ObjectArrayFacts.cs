using System;
using Xunit;
using Array;

namespace ObjectArrayFacts
{
    public class ObjectArrayFacts
    {
        [Fact]
        public void AddFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add("abc");
            array.Add(1.2);
            array.Add('a');
            Assert.Equal(1, array[0]);
            Assert.Equal("abc", array[1]);
            Assert.Equal(1.2, array[2]);
            Assert.Equal('a', array[3]);
        }

        [Fact]
        public void SetAndGetFact()
        {
            var array = new ObjectArray();
            array[0] = 1;
            array[1] = 1.2;
            array[2] = "abc";
            array[3] = 'a';
            Assert.Equal(1, array[0]);
            Assert.Equal(1.2, array[1]);
            Assert.Equal("abc", array[2]);
            Assert.Equal('a', array[3]);
        }

        [Fact]
        public void CointainsFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add("abc");
            array.Add(1.2);
            array.Add('a');
            array[0] = 2;
            array[1] = 3.2;
            array[2] = "asda";
            array[3] = 'b';
            Assert.True(array.Contains(2));
            Assert.True(array.Contains("asda"));
            Assert.False(array.Contains('c'));

        }

        [Fact]
        public void IndexOfFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add("abc");
            array.Add(1.2);
            array.Add('a');
            Assert.Equal(0, array.IndexOf(1));
            Assert.Equal(3, array.IndexOf('a'));
        }

        [Fact]
        public void InsertFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Insert(0,"abc");
            array.Insert(1, 1);
            array.Add('d');
            array.Insert(3, 2.33333);
            Assert.Equal(2.33333, array[3]);
            Assert.Equal("abc", array[0]);
        }

        [Fact]
        public void ClearFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Insert(0, "abc");
            array.Insert(1, 1);
            array.Add('d');
            array.Insert(3, 2.33333);
            array.Clear();
        }

        [Fact]
        public void RemoveAtFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add("abc");
            array.Add(1.2);
            array.Add('a');
            array.RemoveAt(0);
            array.RemoveAt(1);
            Assert.Equal("abc", array[0]);
            Assert.Equal('a', array[1]);
        }

        [Fact]
        public void RemoveFact()
        {
            var array = new ObjectArray();
            array.Add(1);
            array.Add("abc");
            array.Add(1.2);
            array.Add('a');
            array.Remove("abc");
            array.Remove('a');
            Assert.Equal(1, array[0]);
            Assert.Equal(1.2, array[1]);
        }
    }
}
