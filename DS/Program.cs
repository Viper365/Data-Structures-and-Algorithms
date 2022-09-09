using DS.Array;
using DS.BinaryTree;
using DS.Stack;
using System;
using System.Collections.Generic;

namespace DS
{
    internal class Program
    {
        static void Seperator()
        {
            Console.WriteLine("==================================================");
        }
        static void Main(string[] args)
        {
            //[2,4,9]
            //[5,6,4,9]
            //LinkedList ll = new LinkedList();
            //ll.Head = new Node(1);
            //ll.InsertNodeAtEnd(2);
            //ll.InsertNodeAtEnd(2);
            //ll.InsertNodeAtEnd(1);
            //ll.PrintList(ll.Head);
            //Console.WriteLine(ll.IsPalindrome(ll.Head));

            //string[] str = new string[] { "flower", "flow", "flight" };
            //Console.WriteLine("Longest prefix is {0}",StringDS.LongestCommonPrefix(str));

            //int[] str =  { -1, 0, 1, 2, -1, -4 };
            //QArray q = new QArray();
            //q.ThreeSum(str);

            //            8
            //[4, 1, 8, 4, 5]
            //[5, 6, 1, 8, 4, 5]
            //2
            //3


            //LinkedList ll = new LinkedList();
            //ll.Head = new Node(4);
            //ll.InsertNodeAtEnd(1);
            //ll.InsertNodeAtEnd(8);
            //ll.InsertNodeAtEnd(4);
            //ll.InsertNodeAtEnd(5);
            //ll.PrintList(ll.Head);

            //LinkedList ll1 = new LinkedList();
            //ll1.Head = new Node(5);
            //ll1.InsertNodeAtEnd(6);
            //ll1.InsertNodeAtEnd(1);
            //ll1.InsertNodeAtEnd(8);
            //ll1.InsertNodeAtEnd(4);
            //ll1.InsertNodeAtEnd(5);

            //ll.PrintList(ll1.Head);

            //Node n = ll.GetIntersectionNode1(ll.Head, ll1.Head);
            //Console.WriteLine("Intersection on {0}", n.Data); ;

            int[] arr = { 0,2,1,2,0 };

            int[] res = QArray.sort012(arr, arr.Length);

            Console.WriteLine(String.Join(' ', res));
            Console.Read();
        }

        static void PowerSet(string s, int index, string output)
        {
            //Base Condition 
            if (index == s.Length)
            {
                Console.WriteLine(output);
                return;
            }
            PowerSet(s, index + 1, output + s[index]);
            PowerSet(s, index + 1, output);
        }

        static void powerSet(String str, int index, String curr)
        {
            int n = str.Length;

            // base case
            if (index == n)
            {
                Console.WriteLine(curr);
                return;
            }

            // Two cases for every character
            // (i) We consider the character
            // as part of current subset
            // (ii) We do not consider current
            // character as part of current
            // subset
            powerSet(str, index + 1, curr + str[index]);
            powerSet(str, index + 1, curr);
        }

        static void PrintLeftViewOfBinaryTree(BTNode root)
        {
            Queue<int> list = new Queue<int>();
        }
        static void ZigZagTraversal(BTNode node)
        {
            if (node == null) return;
            Queue<BTNode> list = new Queue<BTNode>();
            list.Enqueue(node);
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();

            while (list.Count != 0)
            {
                BTNode bTNode = list.Dequeue();
                Console.WriteLine(bTNode.data);
                if (bTNode.left != null) list.Enqueue(bTNode.left);
                if (bTNode.right != null) list.Enqueue(bTNode.right);
            }
        }

        static void BTLevelOrderTraversalUsingQueue(BTNode root)
        {
            Queue<BTNode> list = new Queue<BTNode>();
            list.Enqueue(root);

            while (list.Count > 0)
            {
                BTNode item = list.Dequeue();
                Console.WriteLine(item.data);

                if (item.right != null)
                    list.Enqueue(item.right);
                if (item.left != null)
                    list.Enqueue(item.left);
            }
        }

        static int HeighOfBT(BTNode node)
        {
            if (node == null)
                return 0;

            return Math.Max(HeighOfBT(node.left), HeighOfBT(node.right)) + 1;
        }
        static void BTLevelOrderTraversal(BTNode root, int height)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= height; i++)
            {
                BTLevelPrinter(root, i, list);
            }
            Console.WriteLine(String.Join('>', list));
        }

        static void BTLevelPrinter(BTNode root, int level, List<int> ls)
        {
            if (root == null) return;

            if (level == 1)
                ls.Add(root.data);
            else
            {
                BTLevelPrinter(root.left, level - 1, ls);
                BTLevelPrinter(root.right, level - 1, ls);
            }
        }
    }
}