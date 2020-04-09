using System;
using System.Collections.Generic;

namespace puzzlesCoDo
{
    class Program
    {
        public static void Random()
        {
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(rand.Next(0, 10));
            }
        }
        public static void RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int max = 4;
            int min = 26;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(5, 26);
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int avg = sum / arr.Length;
            Console.WriteLine("The random array:");
            Console.WriteLine($"[{String.Join(", ", arr)}]");
            Console.WriteLine($"Min : {min}, Max : {max}, Sum : {sum}, Avg : {avg}");
        }
        public static int TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            int num = rand.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Heads");
            }
            if (num == 1)
            {
                Console.WriteLine("Tails");
            }
            return num;
        }
        public static void TossMultipleCoins(int num)
        {
            int heads = 0;
            for (int i = 0; i < num; i++)
            {
                int result = TossCoin();
                if (result == 0)
                {
                    heads += 1;
                }

            }
            int tails = num - heads;
            if (heads == 0 || tails == 0)
            {
                if (heads == 0)
                {
                    Console.WriteLine("Tails never fails!");
                }
                if (tails == 0)
                {
                    Console.WriteLine("A-Head always!");
                }
            }
            else
            {
                if (heads > tails)
                {
                    double ratio = heads / tails;
                    Console.WriteLine($"Heads to tails, {ratio}:1");
                }
                if (tails > heads)
                {
                    double ratio = tails / heads;
                    Console.WriteLine($"Tails to heads, {ratio}:1");
                }
                if (heads == tails)
                {
                    Console.WriteLine("Heads to tails, 1:1");
                }
            }
        }
        public static void Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            int x = names.Count;
            List<string> shufflednames = new List<string>();
            Random rand = new Random();
            for(int i=0; i<x; i++)
            {
                int y = rand.Next(0,x-i);
                shufflednames.Add(names[y]);
                names.RemoveAt(y);
            }
            Console.WriteLine(String.Join(", ",shufflednames));
        }
        public static void NamesLongerThanFive()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            for(int i=0; i<names.Count; i++)
            {
                if(names[i].Length < 5)
                {
                    names.RemoveAt(i);
                }
            }
            int x = names.Count;
            List<string> shufflednames = new List<string>();
            Random rand = new Random();
            for(int i=0; i<x; i++)
            {
                int y = rand.Next(0,x-i);
                shufflednames.Add(names[y]);
                names.RemoveAt(y);
            }
            Console.WriteLine(String.Join(", ",shufflednames));
        }
        static void Main(string[] args)
        {
            NamesLongerThanFive();
        }
    }
}
