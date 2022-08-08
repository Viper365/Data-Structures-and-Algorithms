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
                    else
                    {
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

        public void PrintNearestlargestOnLeft(int[] a)
        {
            Stack<int> vs = new Stack<int>();

            for (int i = 0; i < a.Length; i++)
            {
                while (vs.Count != 0)
                {
                    if (vs.Peek() < a[i])
                    {
                        vs.Pop();
                    }
                    else
                    {
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

        public void PrintNearestSmallestOnRight(int[] a)
        {
            Stack<int> vs = new Stack<int>();
            int n = a.Length - 1;

            for (int i = n; i >= 0; i--)
            {
                while (vs.Count != 0)
                {
                    if (vs.Peek() < a[i])
                    {
                        Console.WriteLine("Nearest smallest of {0} on left is {1}", a[i], vs.Peek());
                        break;
                    }
                    else
                    {
                        vs.Pop();
                    }
                }
                if (vs.Count == 0)
                {
                    Console.WriteLine("Nearest smallest of {0} on left is {1}", a[i], -1);
                }
                vs.Push(a[i]);
            }
        }

        //Check the expression has valid or Balanced parenthesis or not.
        public bool BalancedParenthesis(string s)
        {
            Stack<char> vs = new Stack<char>();


            for (int i = 0; i < s.Length; i++)
            {
                if (IsOpening(s[i]))
                {
                    vs.Push(s[i]);
                }
                else
                {
                    if (vs.Count == 0)
                    {
                        Console.WriteLine("{0} does not have Balanced Parenthesis.", s);
                        return false;
                    }
                    if (isMatching(vs.Peek(), s[i]))
                    {
                        vs.Pop();
                    }
                }
            }

            if (vs.Count == 0)
            {
                Console.WriteLine("{0} has Balanced Parenthesis.", s);

                return true; }
            else {
                Console.WriteLine("{0} does not have Balanced Parenthesis.", s);
                return false; }

        }

        private bool isMatching(char v1, char v2)
        {
            if (v1 == '(' && v2 == ')')
                return true;

            else if (v1 == '{' && v2 == '}')
                return true;

            else if (v1 == '[' && v2 == ']')
                return true;

            else
                return false;
        }

        private bool IsOpening(char c)
        {
            if (c == '(' || c == '{' || c == '[')
                return true;
            else
                return false;
        }


        private string DeCom(string s)
        {
            Stack<char> stac = new Stack<char>();
            string ans = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                stac.Push(s[i]);
            }



            while (stac.Count != 0)
            {
                
                while (stac.Pop() == ']') { }
                
                char c = stac.Pop();
                if (Char.IsDigit(c))
                {

                }
                else if (Char.IsLetter(c))
                {
                    string temp = c.ToString();
                    while (Char.IsLetter(stac.Pop()))
                    {
                        
                    }

                    
                }

            }






            return ans;
        }
    }
}