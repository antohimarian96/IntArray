using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class SortedIntArray : IntArray
    {
        public override void Add(int element)
        {
            if(Count==0)
            base.Add(element);
            else
            base.Insert(FindElementPosition(element),element);
        }

        public override void Insert(int index, int element)
        {
            if (index == 0)
            {
                if (element < array[index])
                    base.Insert(index, element);
            }
            else
            {
                if (element > array[index - 1] && element < array[index])
                    base.Insert(index, element);
            }
        }

        public override int this[int index]
        {
            get => base[index];
            set 
            {
                Insert(index,value);
            }
        }

        private int FindElementPosition(int element)
        {
            bool found = false;
            int index = 0;
            for (int i = 0; i < Count && !found; i++)
                if (array[i] > element)
                {
                    index = i;
                    found = true;
                }
            if (!found)
                index = Count;
            return index;
        }
    }
}
