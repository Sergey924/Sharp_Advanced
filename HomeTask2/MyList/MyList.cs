using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask2
{
    public class MyList<T> : IMyList<T>
    {
        private int[] array = new int[3];

        public MyList()
        {
            array[0] = 1;
            array[1] = 5;
            array[2] = 10;
        }
        


        public int Count
        {
            get => array.Length;
        }

       public int this[int index]
        {
            get => array[index];

        }

        public void Add(int a)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = a;
        }

        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int temp;

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }
            return 0;
        }

        public void Display ()
        {
            for(int i = 0 ; i < array.Length ; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        
        
    }
}
