using System;

namespace puzzlesCoDo
{
    class Program
    {
        public static void Random()
        {
            Random rand = new Random();
            for(int i=0; i<30; i++)
            {
                Console.WriteLine(rand.Next(0,10));
            }
        }
        public static void RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int max = 4;
            int min = 26;
            int sum = 0;
            for(int i=0; i<10; i++)
            {
                arr[i] = rand.Next(5,26);
                sum += arr[i];
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int avg = sum / arr.Length;
            Console.WriteLine("The random array:");
            Console.WriteLine($"[{String.Join(", ",arr)}]");
            Console.WriteLine($"Min : {min}, Max : {max}, Sum : {sum}, Avg : {avg}");
        }
        static void Main(string[] args)
        {
            RandomArray();
        }
    }
}
