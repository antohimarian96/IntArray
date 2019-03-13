namespace Array
{
    public class IntArray
    {
        private int[] array;
        private int count;

        public IntArray()
        {
            array = new int[4];
            count = 0;
        }

        public void Add(int element)
        {
            EnsureCapacity();
            array[count] = element;
            count++;
        }

        public int Count { get => count; }

        public int this[int index]
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
            for (int i = 0; i < count; i++)
                if (array[i] == element)
                    return i;
            return -1;
        }

        public void Insert(int index, int element)
        {
            EnsureCapacity();
            for (int i = array.Length-1 ; i >= index; i--)
                array[i] = array[i-1];
            array[index] = element;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public void RemoveAt(int index)
        {
            if (index <= count)
            {
                for (int i = index; i < array.Length - 1; i++)
                    array[i] = array[i + 1];
                count--;
            }
        }

        public void Remove(int element)
        {
            RemoveAt(IndexOf(element));
        }

        public void EnsureCapacity()
        {
            if (count == array.Length)
                System.Array.Resize(ref array, array.Length * 2);
        }

    }
}
