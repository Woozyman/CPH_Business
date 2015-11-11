using System.Collections;
using System.Collections.Generic;

namespace CollectionFun
{
    class ArrayEnumerable<T> : IEnumerable<T>
    {
        private readonly T[] array;

        public ArrayEnumerable(int size)
        {
            array = new T[size];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Set(int index, T value)
        {
            array[index] = value;
        }
    }
}