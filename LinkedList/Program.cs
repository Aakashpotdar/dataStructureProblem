using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList obj = new LinkedList();
            obj.add(57);
            obj.add(30);
            obj.add(70);
            obj.add(40);

            obj.Display();
            Console.WriteLine("-------add after--------");

            obj.addAfter(70, 50);
            obj.Display();

            Console.WriteLine("------delete first---------");

            obj.deleteFirst();
            obj.Display();
            Console.WriteLine("-------delete last--------");

            obj.deleteLast();
            obj.Display();
            Console.WriteLine("------delete---------");
            obj.add(10);
            obj.add(90);

            obj.delete(30);
            obj.Display();

            Console.WriteLine("------Ascending order---------");

            obj.sortAscending();
            obj.Display();

        }
    }
}
