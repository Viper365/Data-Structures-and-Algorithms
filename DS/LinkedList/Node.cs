using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    internal class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node Next { get; set; }

    }
}
