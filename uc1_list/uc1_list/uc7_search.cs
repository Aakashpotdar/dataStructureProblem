using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc7_search
    {
        public void searchData()
        {
            int[] num = { 56, 30, 70 };
            LinkedList<int> obj = new LinkedList<int>(num);
            Console.WriteLine("*uc7*");
            
            if (obj.Contains(30))
            {
                Console.WriteLine("the value 30 is present in linked list");
            }
            else
            {
                Console.WriteLine("the value 30 is not present in linked list");
            }
            Console.WriteLine("-------------------");
        }
    }
}
