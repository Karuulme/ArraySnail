using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Sayac = 1;
        static void Main(string[] args)
        {
            int[,] array=new int[,]{{0,0,0,0, 0 },{0,0,0,0, 0 },{0,0,0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int Lenarray= ArrayLen(array);
            int[,] cikti =ArrayPrint(array, Lenarray);
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
            int n=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i * i == array.Length)
                {
                    n = i;
                }
            }
            return n;
        }
        static int intarray(int n)
        {
            int t = 0;
            for (int i = 1; i < n; i++)
            {
                if (i * i == n)
                {
                    t = i;
                }
            }
            return t;
        }
        static int[,] ArrayPrint(int[,] array,int Lenarray)
        {
 
            for (int i = 0; i < Lenarray; i++)
            {
                array[0, i] = Sayac;
                Sayac++;
            }
            for (int i = 1; i <Lenarray; i++)
            {
                array[i,Lenarray-1] = Sayac;
                Sayac++;
            }
            for (int i =Lenarray-2; i >= 0; i--)
            {
                array[Lenarray-1,i] = Sayac;
                Sayac++;
            }
            for (int i =Lenarray-2; i> 0; i--)
            {
                array[i, 0] = Sayac;
                 Sayac++;
            }

           
            int IcerikSayaci = 0;
            int indexNumberX = 0;
            int indexNumberY = 0;
            for (int i=0;i< Lenarray;i++)
            {
                for (int j = 0; j < Lenarray; j++)
                {
                    if (array[i,j]==0)
                    {
                        if (IcerikSayaci== 0)
                        {
                            indexNumberX =i;
                            indexNumberY =j;
                        }
                        IcerikSayaci++;
                       
                        
                    }
                }
            }
            float Midarray = Lenarray / 2;
            if (IcerikSayaci==1)
            {
                array[Convert.ToInt32(Math.Floor(Midarray)),Convert.ToInt32(Math.Floor(Midarray))] = Sayac;
            }
            else if(IcerikSayaci!=0)
            {
                int NewarraynLen = intarray(IcerikSayaci);
                int[,] Onarray = new int[NewarraynLen, NewarraynLen];
                for (int i = 0; i < NewarraynLen; i++)
                {
                    for (int j = 0; j < NewarraynLen; j++)
                    {
                        Onarray[i, j] = 0;
                    }
                }
                
               int[,] Getarray=ArrayPrint(Onarray, NewarraynLen);
                for (int i= indexNumberX,n=0;i<NewarraynLen+indexNumberX; i++,n++)
                {
                    for (int j = indexNumberY,t=0; j < NewarraynLen + indexNumberY; j++,t++)
                    {
                        array[i, j] = Getarray[n, t];
                    }
                }


            }
        
          

            return array;
        }
    }
}
