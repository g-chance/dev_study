using System;
using System.Threading.Tasks;

namespace cs_sandbox
{
    class MiscMethods
    {
        public static async Task TestAsync()
        {
            Console.WriteLine("async operation start");
            await Task.Delay(2000);
            Console.WriteLine("async operation complete");
        }
    }
}
