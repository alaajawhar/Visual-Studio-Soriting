using System;

namespace BubbleSorting
{
    class BubbleSorting
    {
        public int[] array { get; set; }
        public int[] Sort()
        {
            bool isNotSorted = true;
            while (isNotSorted)
            {
                isNotSorted = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        //switch
                        array[i] = array[i] + array[i + 1];
                        array[i+1] = array[i] - array[i + 1];
                        array[i] = array[i] - array[i + 1];
                        isNotSorted = true;
                    }
                }
            }
            return array;
        }
        public static void Main(string[] args)
        {
            BubbleSorting bubbleSorting = new BubbleSorting();
            bubbleSorting.array = new int[] { 9, 6, 5, 8, 2, 4 };
            int[] result = bubbleSorting.Sort();
            Console.WriteLine(string.Join("  |  ",result));
            Console.ReadLine();
        }
    }
}
