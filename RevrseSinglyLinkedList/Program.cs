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
            reversedNode = ReverseRecursive(currentNode,ref reversedNode);

        }

        public static Node ReverseRecursive(Node oldNode,ref Node newNode)
        {
            if (oldNode.Next != null)
                ReverseRecursive(oldNode.Next,ref newNode);
            else
            {
                if (newNode == null)
                    newNode = oldNode;
                else
                    newNode.Next = oldNode;
                oldNode = null;
            }
            return newNode;
        }
    }

    public class Node
    {
        public string Value;
        public Node Next = null;
    }
}
