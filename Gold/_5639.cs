using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _5639
    {
        class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value) { this.value = value; left = null; right = null; }

            public void Insert(int num)
            {
                if(num < value)
                {
                    if (left == null)
                        left = new Node(num);
                    else
                        left.Insert(num);
                }
                else
                {
                    if (right == null)
                        right = new Node(num);
                    else
                        right.Insert(num);
                }
            }
        }

        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Node root = new Node(int.Parse(n));

            while(true)
            {
                n = Console.ReadLine();
                if (n == null || n == "")
                    break;
                root.Insert(int.Parse(n));
            }

            PostOrder(root);
            Console.WriteLine(stb);
        }

        static void PostOrder(Node node)
        {
            if (node == null) return;

            PostOrder(node.left);
            PostOrder(node.right);
            stb.AppendLine(node.value.ToString());
        }
    }
}
