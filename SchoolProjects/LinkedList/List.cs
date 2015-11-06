using System.Text;

namespace LinkedList
{
    class List
    {
        Node head;

        public List()
        {
            head = null;
        }
        public void Add(int i)
        {
            head = new Node(i, head);

        }

        public int Sum()
        {
            int res = 0;
            Node cur = head;
            while (cur != null)
            {
                res += cur.data;
                cur = cur.GetNext();
            }

            return res;
        }
        public int Count()
        {
            int res = 0;
            Node cur = head;
            while (cur != null)
            {
                ++res;
                cur = cur.GetNext();
            }

            return res;
        }

        public void RemoveEven()
        {
            Node cur = head;
            Node prev = null;
            while (cur != null)
            {
                if (cur.data % 2 == 0)
                {
                    if (prev != null)
                    {
                        prev.SetNext(cur.GetNext());
                    }
                    else
                    {
                        head = cur.GetNext();
                    }
                }
                else
                {
                    prev = cur;
                }

                cur = cur.GetNext();
            }
        }


        public override string ToString()
        {
            bool first = true;
            var sb = new StringBuilder();
            sb.Append("{");
            Node cur = head;
            while (cur != null)
            {
                if (!first)
                {
                    sb.Append(", ");
                }
                else
                {
                    first = false;
                }
                sb.Append(cur.data);
                cur = cur.GetNext();
            }

            sb.Append("}");

            return sb.ToString();
        }


    }
}
