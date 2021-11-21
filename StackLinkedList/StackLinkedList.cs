using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedList
{
    public class StackLinkedList
    {
        Node head;
        Node1 head1;

        public void push(int var)
        {
            add(var);
        }

        public void pop()
        {
            deleteLast();
        }

        public void enqueu(int num)
        {
            add1(num);
        }
        public void dequeue()
        {
            deleteFirst();
        }

        private void add(int number)
        {
            Node node = new Node(number);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " data pushed to Stack");
        }
        private void add1(int number)
        {
            Node1 node1 = new Node1(number);
            if (this.head1 == null)
            {
                this.head1 = node1;
            }
            else
            {
                Node1 temp1 = head1;
                while (temp1.Next1 != null)
                {
                    temp1 = temp1.Next1;
                }
                temp1.Next1 = node1;
            }
            Console.WriteLine(node1.data1 + " data pushed to Queue");
        }
        public void peak()
        {
            if (head != null)
            {
                Node temp = head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                Console.WriteLine(" " + temp.Next.data);
            }
        }

        private void deleteLast()
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
        public void deleteFirst()
        {
            head1 = head1.Next1;
            Node1 temp1 = head1.Next1;
            head1.Next1 = temp1;
            while (temp1.Next1 != null)
            {
                temp1 = temp1.Next1;
            }
        }
        internal void Display()
        {
            Node1 temp1 = this.head1;
            if (this.head1 == null)
            {
                Console.WriteLine("the Queue is empty");
                return;
            }
            while (temp1 != null)
            {
                Console.WriteLine(temp1.data1 + " ");
                temp1 = temp1.Next1;
            }
            Console.WriteLine();
        }
    }
}
