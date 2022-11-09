using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
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
            
            Console.WriteLine($"cevvf: {SumArray(arr)}");
            Console.ReadKey();
        }
        static int SumArray(int[] summarray)
        {
            int sum = summarray.Sum();
            return sum;
        }
    }
    
}
