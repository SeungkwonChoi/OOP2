using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Dan
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        private Node head;

        public SinglyLinkedList()
        {
            head = null;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void RemoveAt(int index)
        {
            if (head == null || index < 0)
            {
                throw new InvalidOperationException("List is empty or index is out of range.");
            }

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node previous = null;

            for (int i = 0; i < index; i++)
            {
                if (current.Next == null)
                {
                    throw new InvalidOperationException("Index is out of range.");
                }

                previous = current;
                current = current.Next;
            }

            previous.Next = current.Next;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty.");
            }

            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty.");
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public void InsertAt(int index, int data)
        {
            if (index < 0)
            {
                throw new InvalidOperationException("Index is out of range.");
            }

            Node newNode = new Node(data);

            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;
            Node previous = null;

            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new InvalidOperationException("Index is out of range.");
                }

                previous = current;
                current = current.Next;
            }

            newNode.Next = current;
            previous.Next = newNode;
        }

        public void Replace(int index, int data)
        {
            if (index < 0 || head == null)
            {
                throw new InvalidOperationException("List is empty or index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                if (current.Next == null)
                {
                    throw new InvalidOperationException("Index is out of range.");
                }

                current = current.Next;
            }

            current.Data = data;
        }

        public int GetItemAt(int index)
        {
            if (index < 0 || head == null)
            {
                throw new InvalidOperationException("List is empty or index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                if (current.Next == null)
                {
                    throw new InvalidOperationException("Index is out of range.");
                }

                current = current.Next;
            }

            return current.Data;
        }

        public int IndexOf(int data)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1; 
        }

        public bool Contains(int data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
        }

        public int Count()
        {
            int count = 0;
            Node current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }
    }
}
