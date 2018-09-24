using System;

namespace ServiceNowLib
{
    public class Program
    {
        public static void Main()
        {
            int[] a = { 2, 1, 4, 3, 5 };
            int temp;
            for (int j = 1; j < a.Length; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("The Sorted array");
            foreach (int element in a)
                Console.Write(element + " ");
            Console.Read();
        }
    }
}
