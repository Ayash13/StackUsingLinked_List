using System;
namespace StackUsingLinked_List
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if ( top == null)
                return (true);
            else 
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine(" " + element + "Pushed");

        }
        public void pop()
        {
            Console.WriteLine("The popped elemet is : " + top.info);
            top = top.next; //Make top point to the next node in sequence
        }
        public void display()
        {
           
        }
    }
}