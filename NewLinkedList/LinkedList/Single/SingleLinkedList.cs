using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLinkedList.Single
{
    class SingleLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void printAll()
        {
            Node node = new Node();
            node = Head;
            while(node != null)
            {
                Console.WriteLine(node.Data.ToString() + '\n');
                node = node.Next;
            }
        }
        public void AddNode(int data)
        {
            Node node = new Node();
            node.Data = data;
            AddNode(node);
        }
        public void AddNode(Node node)
        {
            if(Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        public void AddtoHead(int data)
        {
            Node node = new Node();
            node.Data = data;
            AddtoHead(node);
        }
        public void AddtoHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public SingleLinkedList getRevert()
        {
            SingleLinkedList newList = new SingleLinkedList();
            Node temp = Head;
            while(temp != null)
            {
                newList.AddtoHead(temp.Data);
                temp = temp.Next;
            }
            return newList;
        }
        public void increaseNodeData(int k, int d)
        {
            Node node = Head;
            for (int i = 0; i < k - 1; i++)
            {
                node = node.Next;
            }

            node.Data += d;
        }
        public void removeLast()
        {
            if (Head == null && Tail == null) return;

            Node node = Head;
            while(node != null)
            {
                if (node.Next == Tail) break;
                node = node.Next;
            }

            Tail = node;
            Tail.Next = null;
        }
        public void removeFirst()
        {
            Head = Head.Next;
        }
        public void removeByIndex(int index)
        {
            Node node = Head;
            Node before = null;
            Node after = Head.Next;
            int i = 1;
            while(node != null)
            {
                if (i == index) break;
                i++;
                before = node;
                node = node.Next;
                after= node.Next;
            }

            if(before == null)
            {
                Head = after;
            }
            else
            {
                before.Next = after;
                node = null;
            }
        }
        public int dataIndex(int data) // index of first data in list, return -1 if not find out 
        {
            int result = 1;
            Node node = Head;
            while (node != null)
            {
                if (node.Data == data) break;
                result += 1;
                node = node.Next;
            }
            if (node == null) result = -1;
            return result;
        }
        public int lastDataIndex(int data)
        {
            int result = -1;
            Node node = Head;
            int index = 1;
            while (node != null)
            {
                if (node.Data == data)
                {
                    result = index;
                }
                index++;
                node = node.Next;
            }
            return result;
        }
        public void removeByData(int data)
        {
            removeByIndex(lastDataIndex(data));
        }
        public void removeFisrtThree()
        {
            for (int i = 0; i < 3; i++)
            {
                removeFirst();
            }
        }
        public void revertThisList()
        {
            SingleLinkedList newList = this.getRevert();
            Head = newList.Head;
            Tail = newList.Tail;
        }
    }
}
