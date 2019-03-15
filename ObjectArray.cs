using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class ObjectArray
    {
        protected object[] array;
        public int Count { get; protected set; }

        public ObjectArray()
        {
            array = new object[4];
            Count = 0;
        }

        public void Add(object element)
        {
            EnsureCapacity();
            array[Count] = element;
            Count++;
        }

        public object this[int index]
        {
            get => array[index];
            set => array[index] = value;
            
        }

        public bool Contains(object element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(object element)
        {
            for (int i = 0; i < Count; i++)
                if (Equals(array[i],element))
                    return i;
            return -1;
        }

        public void Insert(int index, object element)
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

        public void Remove(object element)
        {
            RemoveAt(IndexOf(element));
        }

        private void EnsureCapacity()
        {
            if (Count == array.Length)
                System.Array.Resize(ref array, array.Length * 2);
        }

    }
}
