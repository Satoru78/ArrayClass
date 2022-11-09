using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    public class Array
    {
        static int[] ArrayRandom(int[] array)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-15, 15);
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item + "\t");
            }
            return arr;
        }
        static int MinNumArray(int[] arraymin)
        {
            int minimal = arraymin[0];
            for (int i = 0; i < arraymin.Length / 2; i++)
            {
                if (minimal > arraymin[i])
                {
                    minimal = arraymin[i];
                }
            }
            return minimal;
        }
        static int MaxNumArray(int [] arraymax)
        {
            int maximal = arraymax[0];
            
            for (int i = 0; i > arraymax.Length; i++)
            {
                if (maximal < arraymax[i])
                {
                    maximal = arraymax[i];
                }
                
            }           
            return maximal;
        }
        static int SumArray(int[] summarray)
        {
            int sum = summarray.Sum();     
            return sum;
        }
        static bool SearchArray(bool nmr ,int[] arraySearch)
        {
            int number = arraySearch[0];
            for (int i = 0; i > arraySearch.Length; i++)
            {
                if (number == arraySearch[i])
                {
                    Console.WriteLine("Данный эдемент существует в массиве");
                }
                else
                {
                    Console.WriteLine("Данный элемент не существует в массиве");
                }

            }
            return nmr;
        }
    }
}
