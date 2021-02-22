using System;
using System.IO;

namespace cs_sandbox
{
    class _Program
    {
        static void Main(string[] args)
        {

            //// ========== Stack ==========
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //// ===== Enum as param =====
            //TestMe(Enum.HostOsDecrypt);

            //// ===== FileIO =====
            //Console.WriteLine(
            //    File.ReadAllText(@"C:\Users\v-gchance\OneDrive - Microsoft\Documents\Development\algorithms\hi.txt")
            //);

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

            //// ========== Always run sandbox code ==========
            var mySandbox = new Sandbox();
            mySandbox.ExecuteSandboxCode();
            //// ========== End sandbox code ==========
        }
        static void TestMe(Enum enumParam)
        {
            Console.WriteLine(enumParam);
            bool enumTestResult = enumParam.HasFlag(Enum.HostOsDecrypt);
            Console.WriteLine($"Enum test result {enumTestResult}");
        }
    }
}
