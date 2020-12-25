using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask2
{
    public interface IMyList<T>
    {
        public int this[int index]{get;}
        public int Count { get; }
        public void Add(int a);
        public void Clear();
        public bool Contains(int item);
    }
}
