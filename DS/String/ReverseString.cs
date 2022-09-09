using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public static class StringDS
    {
        public static string ReverseThisString(this string s)
        {
            var strInput = s.Split(".");
            string strOutput = string.Empty;
            for (int i = strInput.Length - 1; i >= 0; i--)
            {
                strOutput += strInput[i];
            }
            return strOutput;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = String.Empty;

            int minSize = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minSize)
                {
                    minSize = strs[i].Length;
                }
            }
            for (int i = 0; i < minSize; i++)
            {
                Dictionary<char, int> valuePairs = new Dictionary<char, int>();

                for (int j = 0; j < strs.Length; j++)
                {
                    if (valuePairs.ContainsKey(strs[j][i]))
                    {
                        valuePairs[strs[j][i]]++;
                    }
                    else
                    {
                        valuePairs.Add(strs[j][i], 1);
                    }
                }

                if (valuePairs.Count > 1)
                    break;
                else {
                    prefix += strs[0][i];
                }
            }
            return prefix;
        }


        public static string LongestPalindrome(this string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                int s = i;
                int e = str.Length - 1;
                bool r = true;
                while (s < e)
                {
                    if (str[s] != str[e])
                    {
                        r = false;
                        break;
                    }
                        s++;
                    e--;
                }
                if (r)
                {
                    result = str.Substring(i);
                    break;
                }
            }
            return result;
        }

        private static string SubString(string str, int i)
        {
            string s = string.Empty;
            for (int k = i; k <= (str.Length - i); k++)
            {
                s = s + str[k];
            }
            return s;
        }


        public static void SubString(this string s)
        {
            //Start
            for (int i = 0; i < s.Length; i++)
            {
                for (int k = i; k < s.Length - i; k++)
                {
                    Console.WriteLine(s[i] + "" + s[k]);           
                }
            }
        }

        public static char FirstNonRepeatingChar(this string s)
        {
            int[] arr = new int[26];
            char result = char.MinValue;

            for (int i = 0; i < s.Length; i++)
            {
                int ansii = (int)s[i];
                arr[ansii - 97] = arr[ansii - 97] + 1;
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < s.Length; i++)
            {
                int position = (int)s[i] - 97;
                if (arr[position] == 1)
                {
                    Console.WriteLine("{0} is the first non repeating char", s[i]);
                    result =  s[i];
                }
            }
            return result;
        }

        public static bool IsValid(string s)
        {
            Stack<char> _s = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (IsAOpening(s[i]))
                {
                    _s.Push(s[i]);
                }
                else
                {
                    char c = _s.Pop();
                    if (IsNotAMatch(c, s[i])) { return false; }
                }

               
            }
            if (_s.Count == 0)
                return true;
            else
                return false;
        }

        public static bool IsAOpening(char c)
        {
            return c == '(' ||
                c == '{' ||
                c == '[' ||
                c == '<';
        }

        public static bool IsNotAMatch(char c, char v)
        {
            bool result = (c == '(' && v == ')') ||
                (c == '{' && v == '}') ||
                (c == '[' && v == ']') ||
                (c == '<' && v == '>');
            return !result;
        }

    }
}
