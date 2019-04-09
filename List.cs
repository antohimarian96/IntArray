using System.Collections;
using System.Collections.Generic;

namespace Array
{
    public class List<T> : IList<T>
    {
        protected T[] array;
        public int Count { get; protected set; }

        public bool IsReadOnly => true;

        public List()
        {
            array = new T[4];
            Count = 0;
        }

        public virtual void Add(T element)
        {
            CheckReadOnly();
            EnsureCapacity();
            array[Count] = element;
            Count++;
        }

        public virtual T this[int index]
        {
            get => array[index];
            set
            {
                CheckReadOnly();
                IndexValidation(index);
                array[index] = value;
            }
        }

        public bool Contains(T element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
                if (Equals(array[i], element))
                    return i;
            return -1;
        }

        public virtual void Insert(int index, T element)
        {
            CheckReadOnly();
            IndexValidation(index);
            EnsureCapacity();
            for (int i = Count; i >= index + 1; i--)
                array[i] = array[i - 1];
            array[index] = element;
            Count++;
        }

        public void Clear()
        {
            CheckReadOnly();
            Count = 0;
        }

        public void RemoveAt(int index)
        {
            CheckReadOnly();
            IndexValidation(index);
            for (int i = index; i < array.Length - 1; i++)
                array[i] = array[i + 1];
            Count--;
            
        }

        public bool Remove(T element)
        {
            CheckReadOnly();
            RemoveAt(IndexOf(element));
            return true;
        }

        private void EnsureCapacity()
        {
            if (Count == array.Length)
                System.Array.Resize(ref array, array.Length * 2);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return array[i];
        }

        public IEnumerator GetEnumerator()
        {
            var result = this;
            IEnumerable<T> enumerator = result;
            return enumerator.GetEnumerator();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array.Length == 0)
                throw new System.ArgumentNullException();
            IndexValidation(arrayIndex);
            for (int i = arrayIndex ; i < Count + arrayIndex ; i++) 
            {
                array[i] = this.array[i - arrayIndex];
            }
        }

        private void IndexValidation(int index)
        {
            if (index > Count || index < 0)
                throw new System.ArgumentOutOfRangeException();
        }

        private void CheckReadOnly()
        {
            if (IsReadOnly)
                throw new System.NotSupportedException();
        }
    }
}
