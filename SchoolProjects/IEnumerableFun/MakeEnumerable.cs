using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableFun
{
    class MakeEnumerable<T> : IEnumerable<T>
    {
        private int pos;
        private T[] arr;

        public MakeEnumerable(int size)
        {
              arr = new T[size];  
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MakeEnumerator<T>(arr);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T element)
        {
            int countZeros = 0;
            int count = arr.Length;
            if (arr[count - 1].ToString() != "0")
            {
                var newArr = new T[arr.Length*2];
                for (var i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                arr = newArr;
                // insert new element after the last element in the old array.
                arr[count] = element;
            }
            else
            {
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i].ToString() == "0") countZeros++;

                    if (arr[i].ToString() != "0")
                    {
                        break;
                    }
                    
                }
                arr[arr.Length - countZeros] = element;
               // pos++;
            }
           
           

        }
        // Removes Element at specified index
        public void Remove(int element)
        {
            var countZeros = 0;
            int count = arr.Length;
            T[] newArr = new T[count];

            arr[element] = (T) Convert.ChangeType(0, typeof (int)); // Replace Value that is removed by zero

            newArr = arr; //Save the new Array

            //Removes "Zero" values from the new array i.e Resizing it.

            for (int i = 0; i < count; i++)
            {
                if (newArr[i].ToString() == "0")
                {
                    countZeros++;
                }
            }

            Array.Resize(ref arr, count - countZeros);

            for (int i = 0; i < arr.Length;)
            {
                while(newArr[i].ToString() == "0") // as long as a value at a given index is zero
                {

                    for (int j = i; j < newArr.Length; j++) // skip it and save next found non-zero value into arr[i]
                    {
                        if (newArr[j].ToString() != "0")
                        {
                            arr[i] = newArr[j]; // Saving all changes to the original Array
                            i++; // return to outer for-loop condition. and repeat
                        }
                    }
                   
                }
               
            }
        }

    }
}
