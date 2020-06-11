using System;
using LeetCodeExercise.QueueAndStack;

namespace LeetCodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue queue = new MyCircularQueue(2);
            queue.EnQueue(4);
            queue.EnQueue(9);
            queue.DeQueue();
            var val = queue.Front();
            Console.WriteLine(val);
            
            Console.WriteLine("Hello World!");
        }
    }
}