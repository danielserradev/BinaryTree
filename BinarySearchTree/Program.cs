using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeNode = new BinaryTree();
            treeNode.Add(100);
            treeNode.Add(99);
            treeNode.Add(101);
            treeNode.Add(55);
            treeNode.Add(130);
            treeNode.Add(120);
            treeNode.Add(75);

            treeNode.SearchTree();
            Console.ReadLine();

        }
    }
}
