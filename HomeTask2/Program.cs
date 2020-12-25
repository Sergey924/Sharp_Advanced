using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*MyList <int> myList = new MyList<int>();

            Random rnd = new Random();

            for(int i = 0; i < 20; i++)
            {
                myList.Add(rnd.Next(0_20));
            }
            for (int i = 0; i < myList.Count; i++)
            {
                myList.Sort();
            }

           myList.Display();*/

            SortedList abc = new SortedList();

            abc.Display();
            Console.WriteLine("-----");
            abc.Reverse1();

         
        }
    }
}
