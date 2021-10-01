using System;

namespace minMAx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayVettore = new int[5] { 3, 6, -3, 5, 7 };
            int min = arrayVettore[0];

            for (int i = 1; i < 5; i++)
            {
                if (arrayVettore[i] < min)
                {
                    min = arrayVettore[i];
                }
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
