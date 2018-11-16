using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AISD
{
    public class Node
    {
        public int frequency;
        public string data;
        public Node leftChild, rightChild;

        public Node(string data, int frequency)
        {
            this.data = data;
            this.frequency = frequency;
        }

        public Node(Node leftChild, Node rightChild)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;

            this.data = leftChild.data + ":" + rightChild.data;
            this.frequency = leftChild.frequency + rightChild.frequency;
        }
    }
}