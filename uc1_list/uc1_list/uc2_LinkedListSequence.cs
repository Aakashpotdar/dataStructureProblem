using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc2_LinkedListSequence
    {
        public void sequenceExicute()
        {
            LinkedList<int> obj = new LinkedList<int>();

            obj.AddLast(70);
            obj.AddLast(30);
            obj.AddLast(56);
            Console.WriteLine("*uc2*");

            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
