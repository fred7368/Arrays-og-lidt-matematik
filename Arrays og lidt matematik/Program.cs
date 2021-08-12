using System;
using System.Collections.Generic;

namespace Arrays_og_lidt_matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i = 2; i<= 20; i = i + 2)
            {
                numbers.Add(i);

            }
            PrintList(numbers, "just created");
            for (int i = 0; i< numbers.Count; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            PrintList(numbers, "Removed those that mod 3");



        }
        static void PrintList(List<int> list,string label)
        {
            Console.WriteLine(label);
            foreach(int tmp in list)
            {
                Console.WriteLine(tmp);
            }
        }
    }
}
