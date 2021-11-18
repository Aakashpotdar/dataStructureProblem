using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc3_ListAppending
    {
        public void ExicuteCode()
        {
            LinkedList<int> obj = new LinkedList<int>();

            obj.AddLast(56);
            obj.AddLast(30);
            obj.AddLast(70);
            Console.WriteLine("*uc3*");

            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
