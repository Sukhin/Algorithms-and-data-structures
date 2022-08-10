// Bubble sort algorithm 
using System;

namespace Bubble_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tBubble sort algorithm");
            Console.WriteLine("Hello friend!");
            Console.Write("Set the size of the data array:"+" ");
                int i = Convert.ToInt32(Console.ReadLine());
                float [] array = new float [i];
            Console.WriteLine("Enter the data array value!");
                for (int j=0; j<i; j++)
            {
                Console.Write("Enter the value for index array:"+" "+j+"\t");
                array[j] = float.Parse(Console.ReadLine());
            }
            for (int g=1; g<i; g++)
                {
                for (int k=0; k<i-1; k++) 
                {
                    if (array[k] > array[k+1])
                    {
                        float a = array[k];
                        float b = array[k + 1];
                        array[k] = b;
                        array[k + 1] = a;
                    }
                    else
                    {
                       continue;
                    }
                }
                }
            Console.WriteLine("The algorithm is complete!");
            for (int p=0; p<i; p++)
            {
                Console.WriteLine(array[p]);
            }
        }
    }
}
