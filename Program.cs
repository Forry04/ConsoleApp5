using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5
{
    internal class Program
    {
        class OneChain
        {
            public int Data;
            public OneChain Next = null;

            public OneChain(int _data)
            {
                Data = _data;
            }

        }
        static void Main(string[] args)
        {
            OneChain head = null;

            OneChain node1 = new OneChain(1);
            head = node1;

            OneChain node2 = new OneChain(2);
            node1.Next = node2;
            OneChain node3 = new OneChain(3);
            node2.Next = node3;


            OneChain item = head;
            while (item != null)
            {
                Console.WriteLine(item.Data);
                item = item.Next;
            }
            
           
            
        }
    }
}