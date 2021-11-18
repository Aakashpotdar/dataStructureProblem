using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc1_linkList
    {
        public void exicuteLinkList()
        {
            int[] num = { 30, 56, 70 };
            LinkedList<int> obj = new LinkedList<int>(num);
            Console.WriteLine("*uc1*");

            foreach (var key in obj)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------------");

        }
    }
}
