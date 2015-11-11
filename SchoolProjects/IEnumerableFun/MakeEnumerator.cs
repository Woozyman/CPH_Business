using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableFun
{
    class MakeEnumerator<T> : IEnumerator<T>
    {
        private T[] arr;
        private int pos;

        public MakeEnumerator(T[] array)
        {
            arr = array;
            Reset();
        }

        public T Current
        {
            get { return arr[pos]; }
        }

        object IEnumerator.Current => Current;

        //object IEnumerator.Current
        //{
        //    get { return Current; }
        //}

        public void Dispose()
        {
            Console.WriteLine("Disposed!");
        }

        public bool MoveNext()
        {
            pos++;
            return pos < arr.Length;
        }

        public void Reset()
        {
            pos = -1;
        }

        
    }
}
