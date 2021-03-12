using System;
using System.IO;

namespace cs_sandbox
{
    class _Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            now.ToString("D");
            //// ========== Always run sandbox code ==========
            Console.WriteLine("========== SANDBOX CODE ==========");
            var mySandbox = new Sandbox();
            mySandbox.ExecuteSandboxCode();
            //// ========== End sandbox code ==========

            //// ========== Always run Algorithms ==========
            Console.WriteLine("\n========== ALGORITHMS ==========\n");
            Algorithms.Run();
            //// ========== End Algorithms ==========
        }
    }
}
