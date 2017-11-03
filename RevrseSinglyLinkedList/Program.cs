using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevrseSinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node currentNode = new Node
            {
                Value = "1",
                Next = new Node
                {
                    Value = "2",
                    Next = new Node
                    {
                        Value = "3",
                        Next = new Node
                        {
                            Value = "4",
                            Next = null
                        }
                    }
                }
            };
            Node reversedNode = null;
            ReverseRecursive(currentNode,ref reversedNode);
            Console.Read();
        }

        public static void ReverseRecursive(Node oldNode,ref Node reverseNode)
        {
            Node current = null;
            if (oldNode.Next != null)
            {
                ReverseRecursive(oldNode.Next,ref current);
            }
            Node newNode = new Node { Value = oldNode.Value, Next = null };
            if (current == null)
            {
                current = newNode;
                reverseNode = current;
            }
            else
            {
                current.Next = newNode;
                reverseNode = current.Next;
            }
            //Console.WriteLine(reverseNode.Value);
        }
    }

    public class Node
    {
        public string Value;
        public Node Next = null;
        
    }
}
