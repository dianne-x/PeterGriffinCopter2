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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            chainOne head  = null;

            chainOne node1 = new chainOne(1);
            head = node1;

            chainOne node2 = new chainOne(2);
            node1.next = node2;

            chainOne node3 = new chainOne(3);
            node2.next = node3;

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