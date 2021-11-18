using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc4_insert
    {
        public void insertData()
        {
            LinkedList<int> obj = new LinkedList<int>();
            var num=obj.AddLast(56);
            obj.AddLast(70);
            obj.AddAfter(num,30);
            Console.WriteLine("*uc4*");

            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
