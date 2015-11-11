using System.Collections;
using System.Collections.Generic;

namespace CollectionFun
{
    public class Evens : IEnumerable<int>
    {
        private readonly int end;
        private readonly int start;

        public Evens(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new EvensEnumerator(start, end);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}