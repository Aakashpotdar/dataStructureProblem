using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc5_delete
    {
        public void remove()
        {
            int[] num = { 56, 30, 70 };
            LinkedList<int> obj = new LinkedList<int>(num);
            Console.WriteLine("*uc5*");
            obj.RemoveFirst();
            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
