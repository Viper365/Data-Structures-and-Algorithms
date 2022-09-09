using System;
using System.Collections;
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

        public void PrintList(Node n1)
        {
            Console.WriteLine("Printing List");
            var current = n1;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine(" null");
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
            Node prev = null;

            while (fNode.Next != null)
            {
                prev = sNode;
                sNode = sNode.Next;
                fNode = fNode.Next.Next;

                if (fNode.Data == sNode.Data)
                {
                    slow = prev;
                    return true;
                    
                }
            }
            slow = null;
            return false;
        }

        public void RemoveCircle(Node head)
        {
            Node node;
            Node current = head;
            if (FindIfLinkedListIsCircular(head, out node))
            {
                Node prev = node;
                node = node.Next;
                while (current.Data != node.Data)
                {
                    prev = node;
                    current = current.Next;
                    node = node.Next;
                }

                prev.Next = null;
            }
        }


        public void RemoveDuplicateFromSortedLinkedList(Node head)
        {
            Node pre = head;
            Node cur = head.Next;
            while (cur != null)
            {
                if (pre.Data == cur.Data)
                {
                    pre.Next = cur.Next;
                    cur = cur.Next;
                }
                else
                {
                    pre = pre.Next;
                    cur = cur.Next;
                }
            }
        }

        public void RemoveDuplicateFromUnSortedLinkedList(Node head)
        {
            Node pre = head;

            Dictionary<int, int> keydataues = new Dictionary<int, int>();
            keydataues.Add(pre.Data, 0);

            Node cur = head.Next;
            while (cur != null)
            {
                if (keydataues.ContainsKey(cur.Data))
                {
                    pre.Next = cur.Next;
                    cur = cur.Next;
                }
                else
                {
                    pre = pre.Next;
                    cur = cur.Next;
                    keydataues.Add(pre.Data, 0);
                }
            }
        }

        public Node FindNthNodeFromEnd(Node head, int k)
        {
            int count = 0;
            Node cur = head;
            while (cur != null)
            {
                count++;
                cur = cur.Next;
            }

            int nth = count - k;
            if (nth < 0)
                return null;


            cur = head;
            while (nth != 0)
            {
                cur = cur.Next;
                nth--;
            }

            return cur;
        }


        public Node AddTwoNumbers(Node l1, Node l2)
        {
            Node head = l1;
            Node pl1 = null;            
            Node pl2 = null;

            int carry = 0;
            while (l1 != null && l2 != null)
            {
                pl1 = l1;
                pl2 = l2;

                int r = l1.Data + l2.Data + carry;

                if (r > 9)
                {
                    r = r % 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                l1.Data = r;

                l1 = l1.Next;
                l2 = l2.Next;
            }

            if (l1 == null && l2 != null)
            {

                l1 = pl1;
                while (l2 != null)
                {
                    int i = l2.Data + carry;
                    if (i > 9)
                    {
                        i = i % 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                    l1.Next = new Node(i);
                    l1 = l1.Next;
                    l2 = l2.Next;
                }
            }
            if (l2 == null && l1 != null)
            {
                while (l1 != null)
                {
                    int i = l1.Data + carry;

                    if (i > 9)
                    {
                        i = i % 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                    l1.Data = i;
                    l1 = l1.Next;
                }
            }
            if (carry != 0)
            {
                l1.Next = new Node(1);
            }
            return head;
        }



        public bool IsPalindrome(Node head)
        {
            Node sp = head;
            Node fp = head;

            while (fp != null)
            {
                sp = sp.Next;
                fp = fp.Next.Next;
            }

            Node rearHead = ReverseLinkedList(sp);

            while (rearHead != null)
            {
                if (rearHead.Data != head.Data)
                {
                    return false;
                }
                rearHead = rearHead.Next;
                head = head.Next;
            }

            return true;
        }

        public static Node ReverseLinkedList(Node sp)
        {
            if (sp == null || sp.Next == null) return null;
            
            Node rearHead = ReverseLinkedList(sp.Next);
            Node headNext = sp.Next;
            headNext.Next = sp;
            sp.Next = null;
            return rearHead;
        }

        public Node MergeTwoLists(Node list1, Node list2)
        {
            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list2;
            else
            {
                Node newHead = new Node(0);
                Node current = newHead;
                while (list1 != null && list2 != null)
                {
                    if (list1.Data < list2.Data)
                    {
                        current.Data = list1.Data;
                        list1 = list1.Next;
                    }
                    else
                    {
                        newHead.Data = list2.Data;
                        list2 = list2.Next;
                    }
                    current = current.Next;
                }
                if (list1 == null)
                    current.Next = list2;
                else if (list2 == null)
                    current.Next = list1;
                return newHead;
            }
        }

        public Node GetIntersectionNode(Node headA, Node headB)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            while (headA != null)
            {
                if (!map.ContainsKey(headA.Data))
                {
                    map.Add(headA.Data, 1);
                }

                headA = headA.Next;
            }


            while (headB != null)
            {
                if (map.ContainsKey(headB.Data))
                {
                    return headB;
                }

                headB = headB.Next;
            }

            return null;
        }

        public Node GetIntersectionNode1(Node headA, Node headB)
        {
            Node n = headA;
            Node m = headB;
            while (headA != null)
            {
                headB = m;
                while (headB != null)
                {
                    if (headA.Data == headB.Data)
                    {
                        return headB;
                    }
                    headB = headB.Next;
                }
                headA = headA.Next;
            }
            return null;
        }

    }
}

