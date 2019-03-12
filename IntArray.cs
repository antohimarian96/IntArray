namespace Array
{
    public class IntArray
    {
        private int[] array;
        private int index;

        public IntArray()
        {
            array = new int[4];
            index = 0;
        }

        public void Add(int element)
        {
            array[index] = element;
            EnsureCapacity();
            index++;
        }

        public int Count()
        {
            return index;
        }

        public int Element(int index)
        {
            if (index <= this.index) 
                return array[index];
            return 0;
        }

        public void SetElement(int index, int element)
        {
            if (index <= this.index)
                array[index] = element;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < index; i++)
                if (array[i] == element)
                    return true;
            return false;
        }

        public int IndexOf(int element)
        {
            return System.Array.IndexOf(array, element);
        }

        public void Insert(int index, int element)
        {
            EnsureCapacity();
            for (int i = array.Length-1 ; i >= index; i--)
                array[i] = array[i-1];
            array[index] = element;
            this.index++;
        }

        public void Clear()
        {
            index = 0;
        }

        public void RemoveAt(int index)
        {
            if (index <= this.index)
            {
                for (int i = index; i < array.Length - 1; i++)
                    array[i] = array[i + 1];
                this.index--;
            }
        }

        public void Remove(int element)
        {
            RemoveAt(IndexOf(element));
        }

        public void EnsureCapacity()
        {
            if (index == array.Length-1)
                System.Array.Resize(ref array, array.Length * 2);
        }

    }
}
