using DS.Array;
using DS.Stack;
using System;

namespace DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList ll = new LinkedList();
            //ll.Head = new Node(10);
            //ll.InsertNodeAtEnd(10);
            //ll.InsertNodeAtEnd(16);
            //ll.InsertNodeAtEnd(13);
            //ll.InsertNodeAtEnd(1);
            //ll.InsertNodeAtEnd(16);
            //ll.InsertNodeAtEnd(1);
            //ll.InsertNodeAtEnd(17);
            //ll.InsertNodeAtEnd(11);

            //Node c = ll.Head;

            //while (c.Next != null)
            //{
            //    c = c.Next;
            //}

            //c.Next = ll.Head;

            ////ll.PrintList();

            //Node slow;

            //Console.WriteLine("LinkedList : {0}", ll.FindIfLinkedListIsCircular(ll.Head, out slow));

            //Console.WriteLine("Meeting point is : {0}", slow.Data);

            //Console.WriteLine("Removing circle");

            //ll.RemoveCircle(ll.Head);
            //ll.PrintList();

            //Node n = ll.FindNthNodeFromEnd(ll.Head, 4);
            //Console.WriteLine("nth node is {0}", n.Data);

            
            //Node node = ll.FindMidpoint(ll.Head);

            //Console.WriteLine(node.Data);

            QArray a = new QArray();


            int[] arr = new int[] { 4, 10, 5, 8, 20, 15, 3, 12 };
            a.PrintNearestSmallestOnLeft(arr);

            StackQ s = new StackQ();

            s.PrintNearestSmallestOnLeft(arr);

            Console.Read();
        }
    }
}
