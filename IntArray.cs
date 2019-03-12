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
            if(index == array.Length-1)
            System.Array.Resize(ref array, array.Length * 2);
            index++;
        }

        public int Count()
        {
            return array.Length;
        }

        public int Element(int index)
        {
            return array[index];
        }

        public void SetElement(int index, int element)
        {
            array[index] = element;
        }

        public bool Contains(int element)
        {
            return System.Array.IndexOf(array, element) != -1;
        }

        public int IndexOf(int element)
        {
            return System.Array.IndexOf(array, element);
        }

        public void Insert(int index, int element)
        {
            if(index==array.Length)
            System.Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length-1 ; i >= index; i--)
                array[i] = array[i-1];
            array[index] = element;
            if(index==this.index)
            this.index++;
        }

        public void Clear()
        {
            index = 0;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < array.Length - 1; i++)
                array[i] = array[i + 1];
            System.Array.Resize(ref array, array.Length - 1);
        }

        public void Remove(int element)
        {
            if (IndexOf(element)!=-1) 
            RemoveAt(IndexOf(element));
        }

    }
}
