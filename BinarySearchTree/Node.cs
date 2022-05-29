using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T nodeData;
        public Node<T> Leftc;
        public Node<T> Rightc;
        public Node(T data)
        {
            this.nodeData = data;
            this.Leftc = null;
            this.Rightc = null;
        }
        int leftCount = 0, rightCount = 0;
        public void Add(T item)
        {
            T current = nodeData;
            if ((current.CompareTo(item)) > 0)
            {
                if (Leftc == null)
                {
                    Leftc = new Node<T>(item);
                }
                else
                {
                    Leftc.Add(item);
                }
            }
            else
            {
                if (Rightc == null)
                {
                    Rightc = new Node<T>(item);
                }
                else
                {
                    Rightc.Add(item);
                }
            }
        }

        public void Display()
        {
            if (Leftc != null)
            {
                leftCount++;
                Leftc.Display();
            }
            Console.WriteLine(this.nodeData);
            if (Rightc != null)
            {
                rightCount++;
                Rightc.Display();
            }
        }
    }
}


