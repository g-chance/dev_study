using Castle.Core.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace cs_sandbox
{
    class Sandbox
    {
        public void ExecuteSandboxCode()
        {

            //// ========== Async await ==========
            //Console.WriteLine();
            //var asyncResult = MiscMethods.TestAsync();

            //Console.WriteLine("Happens after async method start");
            //while (!asyncResult.IsCompleted)
            //{
            //    Console.WriteLine($"async operation {asyncResult.Id} still in progress, " +
            //        $"status: {asyncResult.Status}");
            //    Thread.Sleep(1000);
            //}

            //// ========== Interfaces + Polymorphism ==========
            Console.WriteLine();
            var wfe = new WorkflowEngine();
            wfe.QueueActivity(new Improvise());
            wfe.QueueActivity(new FreakOut());
            wfe.Run();

            //// ========== Constructor Test ==========
            Console.WriteLine();
            var cTest = new ConstructorTest();

            //// ========== Polymorphism ==========
            Console.WriteLine();
            var dbConn = new DbCommand(new SqlConnection(@"C:\_db_location"), "do db stuff");
            dbConn.Execute();

            //// ========== Polymorphism Overriding ==========
            Console.WriteLine();
            var childClass = new ChildClassTest();
            var baseClass = new BaseClassTest();
            BaseClassTest upCastChildClass = childClass;
            childClass.DoThings();
            baseClass.DoThings();
            upCastChildClass.DoThings();

            // ===== Enum as param =====
            Console.WriteLine();
            TestMe(MyEnum.HostOsDecrypt);

            // ===== FileIO =====
            Console.WriteLine();
            Console.WriteLine(
                File.ReadAllText(@"C:\Users\v-gchance\OneDrive - Microsoft\Documents\_Development\algorithms\Makefile")
            );

            // ===== Dictionary =====

            Console.WriteLine();
            Dictionary<int, int> myDict = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 2 }
            };
            foreach (var item in myDict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myDict is IDictionary<int, int>);
        }

        static void TestMe(MyEnum enumParam)
        {
            Console.WriteLine(enumParam);
            bool enumTestResult = enumParam.HasFlag(MyEnum.HostOsDecrypt);
            Console.WriteLine($"Enum test result {enumTestResult}");
        }

    }

    class BaseClassTest
    {
        public virtual void DoThings()
        {
            Console.WriteLine("Base DoThings");
        }
    }
    class ChildClassTest : BaseClassTest
    {
        public override void DoThings()
        {
            Console.WriteLine("Child DoThings");
        }
    }
    class ConstructorTest
    {
        public IDictionary<string, int> BladeProperties
        {
            set
            {
                Console.WriteLine($"dafuq is happening here: {value.ContainsKey("a")}");
            }
        }
        public ConstructorTest()
        {
            BladeProperties = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };
        }
    }
}
