using System;

namespace StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList obj = new StackLinkedList();
            Console.WriteLine("stack oprations");
            Console.WriteLine("----push data----");
            obj.push(70);
            obj.push(30);
            obj.push(56);
            
            Console.WriteLine("----peak data----");
            obj.peak();

            Console.WriteLine("----pop data----");
            obj.pop();

            Console.WriteLine("Queue oprations");
            Console.WriteLine("----enqueu data----");
            obj.enqueu(56);
            obj.enqueu(30);
            obj.enqueu(70);

            Console.WriteLine();
            obj.Display();

            Console.WriteLine("----dequeue data----");
            obj.dequeue();
            obj.Display();


        }
    }
}
