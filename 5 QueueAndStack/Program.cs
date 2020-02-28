using System;
using System.Collections.Generic;

namespace _5_QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> queue = new Queue<Customer>();

            queue.Enqueue(new Customer { Name = "Marcin" });
            queue.Enqueue(new Customer { Name = "Tomek" });
            queue.Enqueue(new Customer { Name = "Adam" });
            queue.Enqueue(new Customer { Name = "Iza" });
            queue.Enqueue(new Customer { Name = "Ola" });
            queue.Enqueue(new Customer { Name = "Piotrek" });
         
            while (queue.Count > 0)
            {
                var customer = queue.Dequeue();
                Console.WriteLine(customer.Name);
                Console.WriteLine("Ilość w kolejce: " + queue.Count);
            }

            Stack<Book> stack = new Stack<Book>();

            stack.Push(new Book { Name = "Books 1" });
            stack.Push(new Book { Name = "Books 2" });
            stack.Push(new Book { Name = "Books 3" });
            stack.Push(new Book { Name = "Books 4" });
            stack.Push(new Book { Name = "Books 5" });
            stack.Push(new Book { Name = "Books 6" });

            while (stack.Count > 0)
            {
                var book = stack.Pop();
                Console.WriteLine(book.Name);
                Console.WriteLine("Ilość na stosie: " + stack.Count);
            }
        }
    }
}
