using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;

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
                
            public void Add(OneChain newNode)
            {

                if (Next == null || Next.Data > newNode.Data)
                {
                    newNode.Next = Next;
                    Next = newNode;
                }
                else
                {
                    Next.Add(newNode);
                }


            }

            public void Remove(OneChain node)
            {
                if (node == null || this.Next == null)
                    return;

                if (this.Next == node)
                {
                    this.Next = this.Next.Next;
                }
                else
                {
                    this.Next.Remove(node);
                }


            }
        }
        static void Main(string[] args)
        {
            OneChain head = null;

            OneChain node1 = new OneChain(1);
            head = node1;

            OneChain node2 = new OneChain(3);
            head.Add(node2);


            head.Remove(node2);
            OneChain node3 = new OneChain(2);
            head.Add(node3);

            
       



            OneChain item = head;
            while (item != null)
            {
                Console.WriteLine(item.Data);
                item = item.Next;
            }            
        }
    }
}