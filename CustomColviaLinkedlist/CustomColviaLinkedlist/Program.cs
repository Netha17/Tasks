using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomColviaLinkedlist
{
    // Class for Doubly Linked List

    public class Nithin
    {

        // head of list
        Node head;
        Node tail;
        public int length;

        // Doubly Linked list Node
        public class Node
        {
            public object data;
            public Node prev;
            public Node next;

            // Constructor to create a new node
            // next and prev is by default initialized as null
            public Node(object d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }
        public void Add(Object o)
        {
            Node newNode = new Node(o);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                Node temp = tail;
                temp.next = newNode;
                newNode.prev = temp;
                tail = newNode;

            }
            length++;
        }
        public void Reverse()
        {
            Node temp = head;
            if(temp ==null|| temp.next==null)
            {
                return;
            }
            while(temp!=null)
            {
                Node tempNode= temp.next;
                temp.next = temp.prev;
                temp.prev = tempNode;   
                temp= tempNode;

            }
            Node temp2 = tail;
            tail = head;
            head= temp2;

        }
        public void Traverse()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("No elements exists");
                return;
            }

            
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public bool Contains(object value)
        {
            Node temp = head;
            while(temp!=null)
            {
                if(temp.data == value) return true;
                temp = temp.next;
            }
            return false;
        }
        public int indexOf(object value)
        {
            Node temp = head;
            int count= 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return -1;
        }
        public void Remove(object value)
        {
            int doesExists=indexOf(value);
            if(doesExists == -1) {
                Console.WriteLine("Element not found");

            }
            else
            {
                Node temp = head;
                //Console.WriteLine("element found at "+doesExists);
                if(doesExists == 0)
                {
                    if(length==1 )
                    {
                        head = null;
                        return;
                    }
                    head = temp.next;
                    temp.next = null;
                    head.prev = null;
                    temp = null;
                    Console.WriteLine("first node deleted");

                }
                else if(doesExists==length-1)
                {
                    temp = tail;
                    temp.prev.next = null;
                    temp.prev = null;
                    temp = null;
                    Console.WriteLine("last node deleted");
                }

                else
                {
                    
                    int count = 0;
                    while(count<doesExists)
                    {
                        temp=temp.next;
                        count++;
                    }
                    temp.prev.next = temp.next;
                    temp.next.prev = temp.prev;
                    temp = null;
                    Console.WriteLine("node deleted at location :" +( doesExists + 1));
                }

            }
            length = length - 1;


        }

        
    }
    

      



    internal class Program
    {
        static void Main(string[] args)
        {
            Nithin n = new Nithin();
           n.Add("ammu");
           // n.Add("nithin");
            //n.Add("venkatesham");
            //n.Add("chandrakala");
            //n.Add("Meghana");
            n.Traverse();
            Console.WriteLine("reversal list");
            n.Reverse();
            n.Traverse();


            Console.ReadLine();
        }
    }
}
