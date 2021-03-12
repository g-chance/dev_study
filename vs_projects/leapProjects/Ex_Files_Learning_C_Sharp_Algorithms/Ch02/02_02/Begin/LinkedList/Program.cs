using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL myList = new SLL();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.insertLast(999000);
            myList.displayList();
        }
    }

    public class SLL
    {
        private Node head;
        public bool isEmpty()
        {
            return head == null;
        }
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = head;
            head = newNode;
        }
        public Node deleteFirst()
        {
            Node temp = head;
            head = head.next;
            return temp;
        }
        public void displayList()
        {
            Console.WriteLine("List nodes");
            Node current = head;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
        public void insertLast(int data)
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine($"<{data}>");
        }
    }
}
