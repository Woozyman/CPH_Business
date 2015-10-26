using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data { get; set; }
        Node next;
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;

        }

        public Node GetNext()
        {
            return next;
        }

        public void SetNext(Node next)
        {
            this.next = next;
        }
    }
}
