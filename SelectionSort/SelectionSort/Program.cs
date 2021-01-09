using System;

namespace SelectionSorting
{
    class SelectionSorting
    {
        public int[] array { get; set; }
        public void Substitude( ref int x,  ref int y)//take care this is not may valid for negative or weird numbers
        {
            {
                x = x + y;
                y = x - y;
                x = x - y;
            }
        }
        public int[] Sort()
        {
            int MinimalIndex;
            for(int i = 0; i< array.Length; i++)
            {
                MinimalIndex = i;
                for (int j = i; j< array.Length; j++)
                {
                    if (array[i] > array[j] && array[MinimalIndex] > array[j])
                    {
                        MinimalIndex = j;
                    }
                }
                //int x = array[MinimalIndex];
                //array[MinimalIndex] = array[i];
                //array[i] = x;
                Substitude(ref array[i], ref array[MinimalIndex]);
            }
            return array;
        }
        public static void Main(string[] args)
        {
            SelectionSorting selectionSorting = new SelectionSorting();
            selectionSorting.array = new int[] { 1,9,6,4,2,5};
            int[] result = selectionSorting.Sort();
            Console.WriteLine(string.Join("  |  ", result));
            Console.ReadLine();
        }
    }
}
