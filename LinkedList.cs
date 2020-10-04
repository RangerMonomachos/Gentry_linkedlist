using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentry_linkedlist
{
    class LinkedList
    {
        public Node HeadNode;
        public LinkedList()
        {
            HeadNode = null;
        }

        public void AddEnd(string input)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(input);
            }
            else
            {
                HeadNode.AddToEnd(input);
            }

        }

        public void AddStart(string input)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(input);
            }
            else
            {
                Node temperary = new Node(input);
                temperary.next = HeadNode;
                HeadNode = temperary;
            }
        }

        public string PrintFirst()
        {
            if(HeadNode == null)
            {
                return null;
            }
            else
            {
                return HeadNode.data;
            }
        }

        public string Contains(string input)
        {
            if(HeadNode == null)
            {
                return null;
            }
            string curentData = HeadNode.data;
            if(curentData.ToString().ToLower() == input.ToString().ToLower())
            {
                return HeadNode.data;
            }
            else
            {
                return HeadNode.Contains(input);
            }
        }

        public string remove(string input)
        {
            if(HeadNode == null)
            {
                return null;
            }
            else if (HeadNode.data.ToString().ToLower() == input.ToLower())
            {
                HeadNode = HeadNode.next;
                return "done";
            }
            else
            {
                Node current = HeadNode;
                Node previous = null;
                while(current != null)
                {
                    if(current.data.ToString().ToLower() == input.ToLower())
                    {
                        previous.next = current.next;
                        return "done";
                    }
                    else
                    {
                        if(previous == null)
                        {
                            previous = HeadNode;
                        }
                        else
                        {
                            previous = current;
                        }
                        current = current.next;
                    }
                }
                return "done";
            }
        }

        public void PrintList()
        {
            if (HeadNode != null)
            {
                HeadNode.PrintAll();
            }
        }
    }
}
