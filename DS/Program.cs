using System;

namespace DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string s = "saketchoubey";
            int[] arr = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                int ansii = (int)s[i];
                arr[ansii - 97] = arr[ansii - 97] + 1;
            }

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < s.Length; i++)
            {
                int position = (int)s[i] - 97;
                if (arr[position] == 1)
                {
                    Console.WriteLine("{0} is the first non repeating char", s[i]);
                    break;
                }
            }
            Console.Read();
        }
    }
}
