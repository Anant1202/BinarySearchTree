using System;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            Node<int> obj = new Node<int>(56);
            obj.Add(30);
            obj.Add(70);
            obj.Display();
        }
    }
}

