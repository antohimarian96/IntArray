using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class SortedList<T> : List<T> where T: IComparable<T>
    {
        public override void Add(T element)
        {
            if (Count == 0)
                base.Add(element);
            else
                base.Insert(FindElementPosition(element), element);
        }

        public override void Insert(int index, T element)
        {
            if (index == 0)
            {
                if (array[index].CompareTo(element) > 0) 
                    base.Insert(index, element);
            }
            else
            {
                if (array[index - 1].CompareTo(element) < 0 && array[index].CompareTo(element) > 0) 
                    base.Insert(index, element);
            }
        }

        public override T this[int index]
        {
            get => base[index];
            set
            {
               if(CheckIfCanSet(index,value))
                array[index] = value;
            }
        }

        private int FindElementPosition(T element)
        {
            for (int i = 0; i < Count; i++)
               if( array[i].CompareTo(element) > 0)
                    return i;
            return Count;
        }

        private bool CheckIfCanSet(int index,T value)
        {
            if (index == 0)
                return value.CompareTo(array[index + 1]) < 0;
            if (index == Count - 1)
                return value.CompareTo(array[index - 1]) > 0;
            return array[index - 1].CompareTo(value) < 0 && array[index + 1].CompareTo(value) > 0;
                

        }
    }
}

