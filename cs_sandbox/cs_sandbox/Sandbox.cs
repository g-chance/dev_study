using System;
using System.Collections.Generic;
using System.IO;

namespace cs_sandbox
{
    class Sandbox
    {
        public IDictionary<string, int> BladeProperties
        {
            set
            {
                Console.WriteLine($"dafuq is happening here: {value.ContainsKey("a")}");
            }
        }
        public Sandbox() 
        {
            BladeProperties = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };
        }

        public void ExecuteSandboxCode()
        {
            //// ========== Polymorphism Overriding ==========
            var childClass = new ChildClassTest();
            var baseClass = new BaseClassTest();
            BaseClassTest upCastChildClass = childClass;
            childClass.DoThings();
            baseClass.DoThings();
            upCastChildClass.DoThings();

            //Dictionary<int, int> myDict = new Dictionary<int, int>
            //{
            //    { 1, 1 },
            //    { 2, 2 }
            //};
            //foreach (var item in myDict)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(myDict is IDictionary<int, int>);
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
}
