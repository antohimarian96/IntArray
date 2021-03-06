﻿namespace Array
{
    public class IntArray
    {
        protected int[] array;
        public int Count { get; protected set; }

        public IntArray()
        {
            array = new int[4];
            Count = 0;
        }

        public virtual void Add(int element)
        {
            EnsureCapacity();
            array[Count] = element;
            Count++;
        }

        public virtual int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public bool Contains(int element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < Count; i++)
                if (array[i] == element)
                    return i;
            return -1;
        }

        public virtual void Insert(int index, int element)
        {
            EnsureCapacity();
            for (int i = Count; i >= index+1; i--)
                array[i] = array[i-1];
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

        public void Remove(int element)
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
