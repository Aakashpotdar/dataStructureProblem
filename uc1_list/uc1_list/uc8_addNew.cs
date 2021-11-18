using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc8_addNew
    {
        public void addData()
        {
            LinkedList<int> obj = new LinkedList<int>();
            obj.AddLast(56);
            var num = obj.AddLast(30);
            obj.AddLast(70);
            obj.AddAfter(num, 40);
            Console.WriteLine("*uc8*");
            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
