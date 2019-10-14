using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public int data;
        public TreeNode node;
        public TreeNode left;
        public TreeNode right;
        public TreeNode root = null;

        public BinaryTree()
        {
            
        }

        public void Add(int data)
        {
            TreeNode node = new TreeNode(data);
            if (root == null)
            {
                root = node;
                Console.WriteLine("The root node is " + data);
            }
            else
            {
                TreeNode currentNode = root;
                TreeNode parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    if(data < currentNode.data)
                    {
                        currentNode = currentNode.left;
                        if(currentNode == null)
                        {
                            parentNode.left = node;                            
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode .right = node;
                            return;
                        }
                    }
                }
            }           
            
        }
        public void SearchTree()
        {
            Console.WriteLine("Please enter the number you are looking for");
            int value = int.Parse(Console.ReadLine());
            if(value == root.data)
            {
                Console.WriteLine(value + " was found.");
            }
            else if (value < root.data)
            {
                if (value == node.data)
                {
                    Console.WriteLine(value + " was found.");
                }
                Console.WriteLine(value + " is on the left side.");
            }
            else if (value > root.data)
            {
                Console.WriteLine(value + " is on the right side.");
            }





        }












    }
    
}
