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

           
            string[] array = new string[]{"a", "b", "c", "d", "e", "f"};
            
            
        //    for (int j = 0; j < array.Length; j++)
          //  {
                for (int i = 0; i < array.Length; i++)
                {
                 list.Add(new Node("" + array[i], i));
                   /* if (array[j] == array[i])
                    {

                    }
                    else
                    {
                       
                    }*/
            //    }
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

            DecodeData(parentNode1, parentNode1, 0, "1001001001000010010011101001111");

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
                    Console.WriteLine("Символ: " + parentNode.data + " Код: " + code);

                GenerateCode(parentNode.rightChild, code + "1");
            }
        }


        static string TextEnd = "";
        static int l = 0;

        public static void DecodeData(Node parentNode, Node currentNode, int pointer, string input)
        {

            if (input.Length == pointer)
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    TextEnd = TextEnd + currentNode.data;
                }

                return;
            }
            else
            {
                if (currentNode.leftChild == null && currentNode.rightChild == null)
                {
                    TextEnd = TextEnd + currentNode.data;
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

            if (l==0) {
                Console.WriteLine(TextEnd);
                l++;
            }
        }
    }
}
