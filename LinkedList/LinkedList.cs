using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        public void add(int number)
        {
            Node node = new Node(number);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " added in the linked list");
        }

        public void addAfter(int num1,int num2)
        {
            Node node = new Node(num2);
            Node temp,temp2;
            temp= (Node)search(num1);
            temp2 = temp.Next;
            if (node.Next == null)
            {
                node.Next = temp2;
            }

                while (temp2.Next != null)
                {
                    temp2 = temp2.Next;
                }
             temp.Next = node;
            Console.WriteLine("the new node is added successfully");
        }

        public void deleteFirst()
        {
            head = head.Next;
            Node temp = head.Next;
            head.Next = temp;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
        }

        public void deleteLast()
        {
            if (head != null)
            {
                Node temp = head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                if (temp.Next.Next == null)
                {
                    temp.Next = null;
                }
            }
        }
        public void delete(int number)
        {
            Node temp = head;
            while (temp.Next != null)
            {
                if (number == temp.data)
                {
                    head = temp.Next;
                    break;
                }
                else if (number==temp.Next.data)
                {
                    temp.Next = temp.Next.Next;
                    break;
                }
               temp = temp.Next;
            }
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
        }

        public void sortAscending()
        {
            Node newTempNode = new Node(0);
            Node temp1 = head;
            newTempNode = head;
            int num1;
            while (newTempNode.Next != null)
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    if (temp.data > temp.Next.data)
                    {
                        num1 = temp.data;
                        temp.data = temp.Next.data;
                        temp.Next.data = num1;
                        temp = temp.Next;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                newTempNode = newTempNode.Next;
            }
        }
        public Object search(int number)
        {
            Node temp=this.head;
            while (temp.Next != null)
            {
                if (number == temp.data)
                {
                    Console.WriteLine(temp.data+" the num is present ");
                    break;
                }
                temp = temp.Next;
            }
            return temp;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
