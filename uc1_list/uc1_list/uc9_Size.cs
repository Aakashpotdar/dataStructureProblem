using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc9_Size
    {
        public void sizeOfLinkedList()
        {
            LinkedList<int> obj = new LinkedList<int>();
            obj.AddLast(56);
            var num = obj.AddLast(30);
            obj.AddLast(70);
            obj.AddAfter(num, 40);
            Console.WriteLine("*uc9*");
            obj.Remove(40);
            int size=obj.Count;
            
            Console.WriteLine("size of LinkedList : "+size);

            Console.WriteLine("-------------------");

        }
    }
}
