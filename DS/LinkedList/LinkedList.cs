using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public int Count { get; set; }


        public void InsertNewNode(int data)
        {
            var node = new Node(data);
            node.Next = Head;
            Head = node;
            Count++;
        }

        public void InsertNodeAtEnd(int data)
        {
            var node = new Node(data);
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }

        // Given a key, deletes the first
        // occurrence of key in linked list
        public void DeleteNode(int key)
        {
            Console.WriteLine("Deleting node {0}", key);
            if (Head == null)
                Console.WriteLine("List is Empty");

            if (Head.Data == key)
            {
                Head = Head.Next;
                Console.WriteLine("Deleting Head Node");
            }

            var current = Head;
            Node previous = null;
            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Key Not found");
                return;
            }

            previous.Next = current.Next;
        }

        public void DeleteNodeFromIndex(int index)
        {
            if (Head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            if (index > Count)
            {
                Console.WriteLine("Index out of the range");
                return;
            }
            if (index == 0)
            {
                Head = Head.Next;
                Console.WriteLine("Deleting head nOde");
                return;
            }
            int i = 0;
            Node current = Head;
            Node previous = null;
            while (i < index)
            {
                previous = current;
                current = current.Next;
                i++;
            }
            previous.Next = current.Next;
        }

        public void PrintList()
        {
            Console.WriteLine("Printing List");
            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data + " -> ");
                current = current.Next;
            }
        }

        public void ReverseList()
        {
            Node p = null;
            Node c = Head;
            Node n = null;


            while (c != null)
            {
                n = c.Next;
                c.Next = p;
                p = c;
                c = n;
            }
            Head = p;
        }

        //Find the midpoint of LinkedList
        public Node FindMidpoint(Node head)
        {
            if (head == null)
                return head;


            Node fastPointer = head;
            Node slowPointer = head;

            while (fastPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
            }

            return slowPointer;
        }

        public bool FindIfLinkedListIsCircular(Node head, out Node slow)
        {

            if (head.Next == null)
            {
                slow = null;
                return false;
            }


            Node sNode = head;
            Node fNode = head;

            while (fNode.Next != null)
            {
                sNode = sNode.Next;
                fNode = fNode.Next.Next;

                if (fNode.Data == sNode.Data)
                {
                    slow = sNode;
                    return true;
                    
                }
            }

            slow = null;
            return false;
        }



        public void RemoveCircle(Node head)
        {
            
        }
        


    }
}
