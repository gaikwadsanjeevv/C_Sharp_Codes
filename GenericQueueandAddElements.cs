using System;
using System.Collections.Generic;
namespace GenericQueueCollection
{
    public class Program
    {
        public static void Main()
        {
            //Creating a Queue to Store Integer Values
            Queue<int> queue = new Queue<int>();

            //Adding Elements to the Queue using Enqueue Method
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            //Adding Duplicate
            queue.Enqueue(30);
r

            //Accesing all the Elements of the Queue using For Each Loop
            Console.WriteLine("Generic Queue Elements");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    } 
}
