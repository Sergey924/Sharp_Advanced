using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeTask2
{
    public class SortedList
    {
        Dictionary<int, char> arrays = new Dictionary<int, char>();

        public int this[int index]
        {
            get
            {
                return arrays[index];
            }
        }
        public SortedList()
        {
            arrays.Add(1, 'A');
            arrays.Add(2, 'B');
            arrays.Add(3, 'C');
        }


        public void Display()
        {
            foreach (KeyValuePair<int, char> item in arrays)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }

    
        
      
    }
}
