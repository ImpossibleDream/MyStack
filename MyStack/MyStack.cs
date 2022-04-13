using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack
    {
        // stack -> LIFO, so the top stack is the end of this stack
        private List<int> stack = new List<int>();

        // save the input number to the top stack
        public void Push(int num)
        {
            stack.Add(num);
        }

        // return the value of the top item and remove it
        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return value;
        }

        // return the value of the top item but don't remove it
        public int Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return stack[stack.Count - 1];
        }

        public int Count
        {
            get
            {
                return stack.Count;
            }
        }

        static void Main(string[] args)
        {
            MyStack stack1 = new MyStack();
            int NUM = 23;
            stack1.Push(NUM);
            //stack1.Pop();
            stack1.Peek();
            Console.WriteLine(NUM);
            Console.ReadKey();
        }
    }
}
