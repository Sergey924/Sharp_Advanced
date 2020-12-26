using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask2
{
    static public class Extension_method
    {
        public static void GetArray(this MyList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
