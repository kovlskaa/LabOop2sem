using System;
using System.Collections.Generic;
using System.Text;

namespace laba7
{
    class Node
    {
        public Node(int data)
        {
            this.data = data;
        }
        public int data { get; set; }
        public Node Next { get; set; }
    }
}
