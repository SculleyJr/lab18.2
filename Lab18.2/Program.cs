using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int>();
            int[] array = {1, 2, 3, 2, 2, 4, 5, 5, 7 ,8 , 4, 4, 1, 0, 10};
            int frequency = 0;

            foreach (var num in array)
            {
                for (int n = 0; n <= array.Length-1; n++)
                {
                    if (arrayList.Contains(num))
                    {
                        break;
                    }
                    
                    if (array[n] == num)
                    {
                        frequency++;
                    }

                   
                }
                arrayList.Add(num);
                if (frequency == 0)
                {
                    continue;
                }
                Console.WriteLine($"The number {num.ToString()} occurs {frequency} times");
                frequency = 0;

                Console.ReadKey();

            }
        }
    }
}
