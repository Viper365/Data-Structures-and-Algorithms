using System;
using System.Collections.Generic;
using System.Text;

namespace DS.BinaryTree
{
    internal class BTNode
    {
        public BTNode left { get; set; }
        public BTNode right { get; set; }
        public int data { get; set; }

        public BTNode(int _data)
        {
            this.data = _data;
            left = null;
            right = null;
        }
    }
}
