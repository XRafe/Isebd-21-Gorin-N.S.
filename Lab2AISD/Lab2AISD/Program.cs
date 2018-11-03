using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AISD
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Node> list = new List<Node>();

            int[] array = new int[]{45, 13, 12, 16, 9, 5};
            //int[] array = new int[] { 18, 25, 21, 17, 5, 14 };

            for (int i = 0; i < array.Length; i++)
            {
                list.Add(new Node("S" + (i + 1), array[i]));
            }

            Stack<Node> stack = GetSortedStack(list);

            while (stack.Count > 1)
            {
                Node leftChild = stack.Pop();
                Node rightChild = stack.Pop();

                Node parentNode = new Node(leftChild, rightChild);

                stack.Push(parentNode);

                stack = GetSortedStack(stack.ToList<Node>());
            }

            Node parentNode1 = stack.Pop();

            GenerateCode(parentNode1, "");

            DecodeData(parentNode1, parentNode1, 0, "0010011101001111");
            //DecodeData(parentNode1, parentNode1, 0, "100");

            Console.ReadKey();
        }

        public static Stack<Node> GetSortedStack(IList<Node> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].frequency > list[j].frequency)
                    {
                        Node tempNode = list[j];
                        list[j] = list[i];
                        list[i] = tempNode;
                    }
                }
            }

            Stack<Node> stack = new Stack<Node>();

            for (int j = 0; j < list.Count; j++)
                stack.Push(list[j]);

            return stack;
        }

        public static void GenerateCode(Node parentNode, string code)
        {
            if (parentNode != null)
            {
                GenerateCode(parentNode.leftChild, code + "0");

                if (parentNode.leftChild == null && parentNode.rightChild == null)
                    Console.WriteLine(parentNode.data + "{" + code + "}");

                GenerateCode(parentNode.rightChild, code + "1");
            }
        }

        public static void DecodeData(Node parentNode, Node currentNode, int pointer, string input)
        {
            if (input.Length == pointer)
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    Console.WriteLine(currentNode.data);
                }

                return;
            }
            else
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    Console.WriteLine(currentNode.data);
                    DecodeData(parentNode, parentNode, pointer, input);
                }
                else
                {
                    if (input.Substring(pointer, 1) == "0")
                    {
                        DecodeData(parentNode, currentNode.leftChild, ++pointer, input);
                    }
                    else
                    {
                        DecodeData(parentNode, currentNode.rightChild, ++pointer, input);
                    }
                }
            }
        }
    }
}
