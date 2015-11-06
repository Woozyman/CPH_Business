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
