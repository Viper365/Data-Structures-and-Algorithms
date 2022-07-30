using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Array
{
    public class QArray
    {

        // 4, 10, 5, 8, 20, 15, 3, 12
        // O(n^2)
        // O(n) --> Use Stack
        // if(stack.pop() == empty)
        // print -1;
        // else if(stack.pop < arr[i])
        // print stack.pop()
        // stack.push(arr[i])

        public void PrintNearestSmallestOnLeft(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        Console.WriteLine("Nearest smallest of {0} on left is {1}", arr[i], arr[j]);
                        break;
                    }
                    if (j == 0)
                    {
                        Console.WriteLine("Nearest smallest of {0} on left is {1}", arr[i], -1);
                        
                    }
                }
            }
        }
    }
}
