using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Stack
{
    internal class StackQ
    {
        //Find nearest smallest element on left

        public void PrintNearestSmallestOnLeft(int[] a)
        {
            Stack<int> vs = new Stack<int>();

            for (int i = 0; i < a.Length; i++)
            {
                while (vs.Count != 0)
                {
                    if (vs.Peek() > a[i])
                    {
                        vs.Pop();
                    }
                    else {
                        Console.WriteLine("Nearest smallest of {0} on left is {1}", a[i], vs.Peek());
                        break;
                    }
                }
                if (vs.Count == 0)
                {
                    Console.WriteLine("Nearest smallest of {0} on left is {1}", a[i], -1);
                }
                vs.Push(a[i]);
            }
        }
    }
}
