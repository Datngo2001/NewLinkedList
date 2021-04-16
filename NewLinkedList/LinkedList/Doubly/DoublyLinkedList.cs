using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLinkedList.Doubly
{
    public class DoubleLinkedList
    {
        public DoubleNode Head { get; set; }
        public DoubleNode Tail { get; set; }
        public int Size { get; set; }
        public DoubleLinkedList(int nodeValue)
        {
            DoubleNode node = new DoubleNode();
            node.Value = nodeValue;
            node.Next = null;
            node.Prev = null;
            this.Head = node;
            this.Tail = node;
            this.Size = 1;
        }
        void InsertInDoublyLL(int nodeValue, int location)
        {

            //create blank node   
            var node = new DoubleNode();
            node.Value = nodeValue;
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList doesnot exists");
                return;
            }
            else if (location == 0)
            {

                node.Next = this.Head;
                node.Prev = null;
                this.Head.Prev = node;
                this.Head = node;

            }
            else if (location >= this.Size)
            { // last position  

                node.Next = null;
                this.Tail.Next = node;
                node.Prev = this.Tail;
                this.Tail = node;

            }
            else
            {
                DoubleNode tempNode = this.Head;
                int index = 0;
                while (index < location - 1)
                {
                    tempNode = tempNode.Next;
                    index++;
                }  
                node.Next = tempNode.Next;
                node.Prev = tempNode;
                tempNode.Next = node;
                node.Next.Prev = node;
            }
            this.Size++;
        }
        void TraverseDDL()
        {
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList does not exists");
                return;
            }
            else
            {
                DoubleNode tempNode = this.Head;
                for (int i = 0; i < this.Size; i++)
                {
                    Console.Write(tempNode.Value);
                    Console.Write("-->");
                    tempNode = tempNode.Next;
                }
            }
            Console.WriteLine("\n");
        }
        void ReverseTraverseDDL()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Linked list doesnot exists");
                return;
            }
            else
            {
                DoubleNode tempNode = this.Tail;
                for (int i = 0; i < this.Size; i++)
                {
                    Console.Write(tempNode.Value);
                    Console.Write("<---");
                    tempNode = tempNode.Prev;
                }

            }
            Console.WriteLine("\n");
        }
        DoubleNode SearchNodeInDDL(int nodeValue)
        {
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList does not exists");
                return null;
            }
            else
            {
                DoubleNode tempNode = this.Head;
                for (int i = 0; i < this.Size; i++)
                {
                    if (tempNode.Value == nodeValue)
                    {
                        Console.WriteLine("node exists in the Linked list:" + nodeValue);
                        return tempNode;
                    }
                    tempNode = tempNode.Next;
                }
                return null;
            }

        }
        // Deletes a node having a given value  
        public void deletionOfNode(int location)
        {
            if (this.Head == null)
            {
                Console.WriteLine("The linked list does not exist!!");// Linked List does not exists  
                return;
            }
            else if (location == 0)
            { // we want to delete first element  
                if (this.Size == 1)
                { // if this is the only node in this list  
                    this.Head = this.Tail = null;
                    this.Size -= 1;
                    return;
                }
                else
                {
                    this.Head = this.Head.Next;
                    this.Head.Prev = null;
                    this.Size -= 1;
                }
            }
            else if (location >= this.Size)
            { // If location is not in range or equal, then delete last node  
                DoubleNode tempNode = this.Tail.Prev; // temp node points to 2nd last node  
                if (tempNode == this.Head)
                { // if this is the only element in the list  
                    this.Tail = this.Head = null;
                    this.Size -= 1;
                    return;
                }
                tempNode.Next = null;
                this.Tail = tempNode;
                this.Size -= 1;

            }
            else
            { // if any inside node is to be deleted  
                DoubleNode tempNode = this.Head;
                for (int i = 0; i < location - 1; i++)
                {
                    tempNode = tempNode.Next; // we need to traverse till we find the location  
                }
                tempNode.Next = tempNode.Next.Next; // delete the required node  
                tempNode.Next.Prev = tempNode;
                this.Size -= 1;
            } // end of else  

        }// end of method  
    }
}
