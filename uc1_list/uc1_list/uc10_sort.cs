using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class uc10_sort
    {
        Node head;
        public void sortMethod()
        {
            LinkedList<int> llist = new LinkedList<int>();
            Node new_node;

            new_node = newNode(56);
            sortedInsert(new_node);

            new_node = newNode(30);
            sortedInsert(new_node);

            new_node = newNode(40);
            sortedInsert(new_node);

            new_node = newNode(70);
            sortedInsert(new_node);
                        
            Console.WriteLine("Created Linked List");
            printList();
        }

        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        void sortedInsert(Node new_node)
        {
            Node current;

            /* Special case for head node */
            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }

        Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }


    }
}
