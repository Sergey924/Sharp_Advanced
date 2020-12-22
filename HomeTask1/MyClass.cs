using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
    // Задание № 2
    class MyClass<T>
    {
        static T FactoryMethod()
        {

            return (T)(object) new MyClass<T>();
    
        }
    }
}
