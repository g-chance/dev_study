using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars1");
            theStack.push("Star Wars2");
            theStack.push("Star Wars3");
            theStack.push("Star Wars4");
            theStack.push("Star Wars5");

            Console.WriteLine("The stack contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                Console.WriteLine(movie);
            }
            
        }
    }

    public class Stack
    {
        private int maxSize;
        private String[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }
        public void push(string m)
        {
            if (isFull())
            {
                Console.WriteLine("This stack is full");
            } 
            else
            {
                top++;
                stackArray[top] = m;
            }
        }
        private bool isFull()
        {
            return maxSize - 1 == top;
        }
        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("It's empty");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }
        public string peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return top == -1;
        }
    }
}
