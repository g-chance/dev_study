using System;
using System.Collections.Generic;

namespace cs_sandbox
{
    class Stack
    {
        private List<object> _myStack;
        public Stack()
        {
            _myStack = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj != null)
            {
                _myStack.Add(obj);
            }
        }
        public object Pop()
        {
            try
            {
                var last = _myStack[_myStack.Count - 1];
                _myStack.RemoveAt(_myStack.Count - 1);
                return last;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred when trying to Pop from stack: {e}");
                return null;
            }
        }
        public void Clear()
        {
            _myStack.Clear();
        }
    }
}
