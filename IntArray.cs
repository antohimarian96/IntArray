namespace Array
{
    public class IntArray
    {
        private int[] array;

        public IntArray()
        {
            array = new int[0];
        }

        public void Add(int element)
        {
            System.Array.Resize(ref array, array.Length+1);
            array[array.Length - 1] = element;
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
            System.Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length-1 ; i >= index; i--)
                array[i] = array[i-1];
            array[index] = element;
        }

        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < array.Length - 1; i++)
                array[i] = array[i + 1];
            System.Array.Resize(ref array, array.Length - 1);
        }

        public void Remove(int element)
        {
            var result = new IntArray();
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element && index==0)
                {
                    index = i;
                }
                result.Add(array[i]);
            }
            result.RemoveAt(index);
            array = result.array;
            
        }

    }
}
