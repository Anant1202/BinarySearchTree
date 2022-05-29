using System;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Binary Search Tree Program");
            do
            {
                Console.WriteLine("1.Add 30 and 70 ");
                Console.WriteLine("2.Add more elements and get size");
                Console.WriteLine("3.Search 63");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                Node<int> obj = new Node<int>(56);
                switch (choice)
                {
                    case 1:
                        obj.Add(30);
                        obj.Add(70);
                        obj.Display();
                        break;
                    case 2:
                        obj.Add(30);
                        obj.Add(70);
                        obj.Add(22);
                        obj.Add(40);
                        obj.Add(11);
                        obj.Add(3);
                        obj.Add(16);
                        obj.Add(60);
                        obj.Add(95);
                        obj.Add(65);
                        obj.Add(63);
                        obj.Add(67);
                        obj.Display();
                        obj.Size();
                        break;
                    case 3:
                        obj.Add(30);
                        obj.Add(70);
                        obj.Add(22);
                        obj.Add(40);
                        obj.Add(11);
                        obj.Add(3);
                        obj.Add(16);
                        obj.Add(60);
                        obj.Add(95);
                        obj.Add(65);
                        obj.Add(63);
                        obj.Add(67);
                        bool result = obj.IfExists(63,obj);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}

