using System;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Implimentation!");

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(24);
            binarySearchTree.Insert(33);
            binarySearchTree.Insert(98);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(34);
            binarySearchTree.Insert(77);
            binarySearchTree.Insert(5);
            
            //  binarySearchTree.Insert(16);

            binarySearchTree.Display();

            binarySearchTree.GetSize();

            if (binarySearchTree.Search(5, binarySearchTree))
            {
                Console.WriteLine("5 is found");
            }
            else
            {
                Console.WriteLine("5 is not found");
            }
        }
    }
}
