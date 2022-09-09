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

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> vs = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 3 ; i++)
            {

                int threeSum = nums[i];
                List<int> lst = new List<int>();
                lst.Add(nums[i]);

                for (int j = i + 1; j < i+3 ; j++)
                {
                    threeSum += nums[j];
                    lst.Add(nums[j]);
                }
                if (threeSum == 0)
                {
                    vs.Add(lst);
                }    
            }
            return vs;
        }


        public static int[] duplicates(int[] arr, int n)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();


            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic.Add(arr[i], 1);
            }
            List<int> a = new List<int>();


            foreach (var item in dic)
            { 
                if(item.Value > 1)
                    a.Add(item.Key);
            }

            a.Sort();
            return a.Count == 0 ? new int[] { -1 } : a.ToArray();

        }

        public static int[] sort012(int[] arr, int n)
        {

            int one = 0;
            int zero = 0;
            int two = n-1;

            while (one <= two)
            {
                if (arr[one] == 0)
                {
                    int temp = arr[one];
                    arr[one] = arr[zero];
                    arr[zero] = temp;
                    zero++;
                    one++;
                }
                else if (arr[one] == 2)
                {
                    int temp = arr[one];
                    arr[one] = arr[two];
                    arr[two] = temp;
                    two--;
                }
                else if (arr[one] == 1)
                {
                    one++;
                }


            }
            return arr;
        }

    }
}
