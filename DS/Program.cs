using System;

namespace DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Head = new Node(10);
            ll.InsertNodeAtEnd(11);
            ll.InsertNodeAtEnd(12);
            ll.InsertNodeAtEnd(13);
            ll.InsertNodeAtEnd(14);
            ll.InsertNodeAtEnd(15);
            ll.InsertNodeAtEnd(16);
            ll.InsertNodeAtEnd(17);
            ll.InsertNodeAtEnd(18);

            Node c = ll.Head;

            while (c.Next != null)
            {
                c = c.Next;
            }

            c.Next = ll.Head;

            //ll.PrintList();

            Node slow;

            Console.WriteLine("LinkedList : {0}", ll.FindIfLinkedListIsCircular(ll.Head, out slow));

            Console.WriteLine("Meeting point is : {0}", slow.Data);

            Console.WriteLine("Removing circle");

            ll.RemoveCircle(ll.Head);

            ll.PrintList();


            //Node node = ll.FindMidpoint(ll.Head);

            //Console.WriteLine(node.Data);


            Console.Read();
        }
    }
}
