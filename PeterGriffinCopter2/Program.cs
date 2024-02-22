using System.Collections.Generic;

namespace PeterGriffinCopter2
{
    class chainOne
    {
        public int data;
        public chainOne next = null;


        public chainOne(int value)
        {
            data = value;
        }

        public void Add(chainOne newNode)
        {
            if (next == null || next.data > newNode.data)
            {
                newNode.next = next;
                next = newNode;
            }
            else
            {
                next.Add(newNode);
            }
        }

        public void Remove(int value)
        {
            if (next != null)
            {
                if (next.data == value)
                {
                    next = next.next;
                }
                else
                {
                    next.Remove(value);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            chainOne head = null;

            chainOne node1 = new chainOne(1);
            head = node1;

            chainOne node2 = new chainOne(2);
            node1.next = node2;

            chainOne node3 = new chainOne(3);
            node2.next = node3;

            // Add a new node
            chainOne newNode = new chainOne(4);
            node3.next = newNode; // Add the new node to the end of the chain

            // Remove a node
            head.Remove(2);

            chainOne item = head;
            while (item != null)
            {
                System.Console.WriteLine(item.data);
                item = item.next;
            }

            Console.ReadKey();
        }
    }
}