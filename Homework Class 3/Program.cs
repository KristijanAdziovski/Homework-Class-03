using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int i;
            Console.Write("Input 6 elements in the array :\n");
            for (i = 0; i < 6; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

            int sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                {
                    sum += arr[j];
                }
                
            }
            Console.WriteLine(sum);
        }
    }


}
