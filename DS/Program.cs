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

            //var root = new BTNode(10);
            //root.left = new BTNode(11);
            //root.left.left = new BTNode(7);
            //root.left.right = new BTNode(12);
            //root.right = new BTNode(9);
            //root.right.left = new BTNode(15);
            //root.right.right = new BTNode(8);
            ////BTLevelOrderTraversal(root, 3);
            ////BTLevelOrderTraversalUsingQueue(root);

            //ZigZagTraversal(root);
            //Console.WriteLine("Height of the BT is {0}", HeighOfBT(root));


            PowerSet("abc", 0, " ");
            String str = "abc";
            int index = 0;
            String curr = "";
            powerSet(str, index, curr);





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

        static void powerSet(String str, int index,
                String curr)

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
