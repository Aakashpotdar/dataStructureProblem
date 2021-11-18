using System;
using System.Collections.Generic;


namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            uc1_linkList obj1 = new uc1_linkList();
            obj1.exicuteLinkList();

            uc2_LinkedListSequence obj2 = new uc2_LinkedListSequence();
            obj2.sequenceExicute();

            uc3_ListAppending obj3 = new uc3_ListAppending();
            obj3.ExicuteCode();

            uc4_insert obj4=new uc4_insert();
            obj4.insertData();
            
            uc5_delete obj5 = new uc5_delete();
            obj5.remove();

            uc6_popLast obj6 = new uc6_popLast();
            obj6.removeLast();

            uc7_search obj7 = new uc7_search();
            obj7.searchData();

            uc8_addNew obj8 = new uc8_addNew();
            obj8.addData();

            uc9_Size obj9 = new uc9_Size();
            obj9.sizeOfLinkedList();

            uc10_sort obj10 = new uc10_sort();
            obj10.sortMethod();
        }
    }
}
