using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class Enumerate : IEnumerator
    {
        private ObjectArray array;
        private int index;

        public Enumerate(ObjectArray array)
        {
            this.array = array;
            index = -1;
        }

        public object Current { get => array[index]; }

        public bool MoveNext()
        {
            index++;
            return index <= array.Count;
        }

        public void Reset()
        {
            index = -1;
        }

    }
}
