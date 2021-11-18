using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc6_popLast
    {
        public void removeLast()
        {
            int[] num = { 56, 30, 70 };
            LinkedList<int> obj = new LinkedList<int>(num);
            Console.WriteLine("*uc6*");
            obj.RemoveLast();
            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
