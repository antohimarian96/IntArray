using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class List<type> : IEnumerable
    {
        protected type[] array;
        public int Count { get; protected set; }

        public List()
        {
            array = new type[4];
            Count = 0;
        }

        public void Add(type element)
        {
            EnsureCapacity();
            array[Count] = element;
            Count++;
        }

        public type this[int index]
        {
            get => array[index];
            set => array[index] = value;

        }

        public bool Contains(type element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(type element)
        {
            for (int i = 0; i < Count; i++)
                if (Equals(array[i], element))
                    return i;
            return -1;
        }

        public void Insert(int index, type element)
        {
            EnsureCapacity();
            for (int i = Count; i >= index + 1; i--)
                array[i] = array[i - 1];
            array[index] = element;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
        }

        public void RemoveAt(int index)
        {
            if (index <= Count)
            {
                for (int i = index; i < array.Length - 1; i++)
                    array[i] = array[i + 1];
                Count--;
            }
        }

        public void Remove(type element)
        {
            RemoveAt(IndexOf(element));
        }

        private void EnsureCapacity()
        {
            if (Count == array.Length)
                System.Array.Resize(ref array, array.Length * 2);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return array[i];
        }
    }
}
