using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
    // Задание № 1
    class Book<T>
    {
        private string Name;
        private T Price;
        
        public string name { get; set; }
        public T price { get; set; }

        public Book(string name, T price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Название книги: {Name} \nЦена: {Price}");
        }
    }
}
