using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentry_linkedlist
{
    class Node
    {
        public string data;
        public Node next;

        public Node(string i)
        {
            data = i;
            next = null;
        }
        
        public void AddToEnd (string input)
        {
            if (next == null)
            {
                next = new Node(input);
            }
            else
            {
                next.AddToEnd(input);
            }
        }
        public string Contains(string input)
        {
            if (data.ToString().ToLower() == input.ToLower())
            {
                return data;
            }
            else if (next == null)
            {
                return null;
            }
            else
            {
                return next.Contains(input);
            }
        }

        //public void RemoveNode(string input)
        //{
        //    //Node previous = null;
        //    //Node Current = 
        //}

        public void PrintAll()
        {
            Console.Write("[" + data + "] ");
            if (next != null)
            {
                next.PrintAll();
            }
        }
    }
}
