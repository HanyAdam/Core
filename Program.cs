using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string exit = "";
            Console.WriteLine("Enter array items:-");
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------");

            while (exit != "e")
            {
                int key = 0;
              
                Console.WriteLine("Enter value to show it's index:-");                
                string value = Console.ReadLine();
                int.TryParse(value, out key);
               
                Console.WriteLine(Indexof(a, key));
                Console.WriteLine("----------------------------");
                Console.WriteLine("Press (e) to exit or press (c) to contuine");
                exit = Console.ReadLine();
            }

        }
        public static int Indexof(int[] a ,int key)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while(lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                    hi = mid -1;
                else if (key > a[mid])
                    lo = mid +1;
                else return mid;
                                   }
            return -1;
        }
    }

}
