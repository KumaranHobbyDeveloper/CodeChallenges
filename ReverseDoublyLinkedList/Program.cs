using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node IstNode = new Node { Value = "1" };
            Node IIndNode = new Node { Value = "2" };
            Node IIIrdNode = new Node { Value = "3" };
            Node IVthNode = new Node { Value = "4" };
            Node VthNode = new Node { Value = "5" };

            IstNode.Previous = null;
            IstNode.Next = IIndNode;

            IIndNode.Previous = IstNode;
            IIndNode.Next = IIIrdNode;

            IIIrdNode.Previous = IIndNode;
            IIIrdNode.Next = IVthNode;

            IVthNode.Previous = IIIrdNode;
            IVthNode.Next = VthNode;

            VthNode.Previous = IVthNode;
            VthNode.Next = null;

            Node newOrderNodeToptoBottom = null;
            Node newOrderNodeBottomtoUp = null;

            newOrderNodeToptoBottom = ReverseRecursiveTopToBottom(IstNode);
            ReverseRecursiveBottomToUp(IstNode, ref newOrderNodeBottomtoUp);

        }

        public static Node ReverseRecursiveTopToBottom(Node OldNode, Node NewNode = null)
        {
            Node currentNode = null;

            if (OldNode == null) return null;

            if (OldNode.Previous == null)
            {
                NewNode = new Node { Value = OldNode.Value };
                NewNode.Previous = new Node { Value = OldNode.Next.Value };
                currentNode = NewNode.Previous;
                currentNode.Next = NewNode;
            }
            else if (OldNode.Next == null)
            {
                //currentNode = new Node { Value = OldNode.Value };
                NewNode.Previous = null;
                currentNode = NewNode;
            }
            else
            {
                NewNode.Previous = new Node { Value = OldNode.Next.Value };
                currentNode = NewNode.Previous;
                currentNode.Next = NewNode;
            }
            if (OldNode.Next != null)
            { ReverseRecursiveTopToBottom(OldNode.Next, currentNode); }
            return currentNode;
        }

        public static void ReverseRecursiveBottomToUp(Node OldNode,ref Node NewNode)
        {
            Node currentNode = null;

            if (OldNode == null) return;

            if (OldNode.Next != null)
            {
                ReverseRecursiveBottomToUp(OldNode.Next, ref currentNode);
            }

            if (OldNode.Previous == null)
            {
                currentNode.Next = null;
                NewNode = currentNode;
            }
            else if(OldNode.Next == null)
            {
                currentNode = new Node { Value = OldNode.Value };
                currentNode.Next = new Node { Value = OldNode.Previous.Value };
                NewNode = currentNode.Next;
                NewNode.Previous = currentNode;
            }
            else
            {
                //currentNode.Previous = new Node { Value = oldNode.Next.Value} ;
                currentNode.Next = new Node { Value = OldNode.Previous.Value };
                NewNode = currentNode.Next;
                NewNode.Previous = currentNode;
            }
        }
    }

    public class Node
    {
        public Node Previous;
        public string Value;
        public Node Next;
    }
}
