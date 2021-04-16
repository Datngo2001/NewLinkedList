using NewLinkedList.Single;
using System;

namespace NewLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            //list.AddNode(12);
            //list.AddNode(5);
            //list.AddNode(79);
            //list.AddNode(57);
            //list.AddNode(21);
            //list.AddNode(57);
            //list.AddNode(31);
            //list.AddNode(35);
            //list.AddNode(57);

            int n;
            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.AddNode(Convert.ToInt32(Console.ReadLine()));
            }

            list.revertThisList();

            Console.WriteLine("Result: ");
            list.printAll();
        }
    }
}
