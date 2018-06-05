using System;
using System.Collections.Generic;
namespace puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int min = 26;
            int max = 4;
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(5,26);
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine(max);
            System.Console.WriteLine(min);
            foreach(int item in arr)
            {
                System.Console.Write(item+" ");
            }
            return arr;
        }

        public static string TossCoin()
        {
            System.Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            string[] result = {"Heads!", "Tails!"};
            int check = rand.Next(0,2);
            System.Console.WriteLine(result[check]);
            return "You got "+result[check];
        }

        public static string[] Names()
        {
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int i=0; i<arr.Length; i++)
            {
                string temp = arr[i];
                int x = rand.Next(0,arr.Length);
                arr[i] = arr[x];
                arr[x] = temp;
            }
            string[] arr2 = new string[4];
            int idx = 0;
            foreach (string item in arr)
            {
                if (item.Length < 5)
                {
                    continue;
                }
                else
                {
                    arr2[idx] = item;
                    idx++;
                }
            }
            return arr2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = RandomArray();
            TossCoin();
            Names();
        }
    }
}
