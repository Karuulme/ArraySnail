using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 2, 5, 8, 8 }, { 8, 8, 9, 9}, { 8, 8, 9, 9 }, {3, 30, 0, 0}};
            int Lenarray = ArrayLen(array);
            int[,] cikti = ArrayPrint(array, Lenarray);
            for (int i = 0; i < Lenarray; i++)
            {
                for (int j = 0; j < Lenarray; j++)
                {
                    Console.Write(cikti[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static int ArrayLen(int[,] array)
        {
            int n = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i * i == array.Length)
                {
                    n = i;
                }
            }
            return n;
        }
        static int[,] ArrayPrint(int[,] array, int Lenarray)
        {
            float loopArray = Lenarray / 2;
            for (int n = 0; n <=Convert.ToInt32(Math.Floor(loopArray)); n++)
            {
                for (int i = 0+n; i < Lenarray-n; i++)
                {
                    array[n, i] = 1;
                }
                for (int i = 1+n; i < Lenarray-n; i++)
                {
                    array[i, Lenarray - 1-n] = 1;
                }
                for (int i = Lenarray - 2-n; i >= 0+n; i--)
                {
                    array[Lenarray - 1-n, i] = 1;
                }
                for (int i = Lenarray - 2-n; i > 0+n; i--)
                {
                    array[i, 0+n] = 1;
                }
            }
            if (Lenarray%2==1)
            {
                float Midarray = Lenarray / 2;
                array[Convert.ToInt32(Math.Floor(Midarray)), Convert.ToInt32(Math.Floor(Midarray))] = 1;
            }
            return array;
        }
    }
}
