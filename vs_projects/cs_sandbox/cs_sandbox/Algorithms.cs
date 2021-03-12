using System;

namespace cs_sandbox
{
    class Algorithms
    {
        public static void Run()
        {
            //// ========== Stack ==========
            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //// ========== Queue ==========
            //int x = 5;
            //var myQueue = new Queue(5);
            //myQueue.insert(100);
            //myQueue.insert(10);
            //myQueue.insert(50);
            //myQueue.insert(30);
            //myQueue.insert(80);
            //myQueue.view();
            //Console.WriteLine(myQueue.peekFront());
            //myQueue.remove();
            //myQueue.insert(99);
            //Console.WriteLine(myQueue.peekFront());
            //myQueue.view();

            int MyFirstAlgo(int x)
            {
                return x * x;
            }
            Console.WriteLine($"MyFirstAlgo {MyFirstAlgo(5)}");
        }
    }
}
