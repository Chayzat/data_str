using System;
using System.Collections;
using System.Linq.Expressions;

namespace str_data
{
    class Program
    {
        static void Main(string[] args)
        {
            //стек
            Stack myStack = new Stack();
            myStack.Push("Карандаш");
            myStack.Push("Ручка");
            myStack.Push("Пенал");

            // Displays the properties and values of the Stack.
            Console.WriteLine("стек");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            PrintValues(myStack);

            //очередь
            Queue myQ = new Queue();
            myQ.Enqueue("Карандаш");
            myQ.Enqueue("Ручка");
            myQ.Enqueue("Пенал");

            Console.WriteLine("очередь");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues_2(myQ);

            //массив
            Console.WriteLine("массив");
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
        public static void PrintValues_2(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

    }
}
