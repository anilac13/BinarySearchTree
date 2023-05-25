using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private Node Root;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Node temp = Root;
            while (true)
            {
                if (data < temp.Data)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = newNode;
                        return;
                    }
                    temp = temp.Left;
                }
                else if (data > temp.Data)
                {
                    if (temp.Right == null)
                    {
                        temp.Right = newNode;
                        return;
                    }
                    temp = temp.Right;
                }
                else
                {
                    return;
                }
            }
        }
        public bool Search(int data)
        {
            return Search(Root, data);
        }
        private bool Search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            if (data < node.Data)
            {
                return Search(node.Left, data);
            }
            else if (data > node.Data)
            {
                return Search(node.Right, data);
            }
            else
            {
                return true;
            }
        }
        public void Print()
        {
            PrintInOrder(Root);
        }
        public void PrintInOrder(Node node)
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (node != null)
            {
                PrintInOrder(node.Left);
                Console.Write(node.Data + " ");
                PrintInOrder(node.Right);
            }
        }
    }
}
