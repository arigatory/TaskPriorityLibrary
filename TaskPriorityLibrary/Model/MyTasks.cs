using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPriorityLibrary.Model
{
    /// <summary>
    /// This class is for adding and managing my tasks
    /// </summary>
    public class MyTasks
    {
        private Node _first, _last;

        public void Add(Task t)
        {
            Node temp = new Node(t);
            if (_first == null)
            {
                _first = temp;
                _last = temp;
            } else {
                _last.Next = temp;
                temp.Previous = _last;
                _last = _last.Next;
            }
        }

        public void Swap(Task t1, Task t2)
        {
            Node node1 = _first;
            Node node2 = _first;

            while (node1.Data != t1 && node1 != null )
            {
                node1 = node1.Next;
            }
            while (node2.Data != t2 && node2 != null)
            {
                node2 = node2.Next;
            }
            node1.Data = t2;
            node2.Data = t1;
        }

        //for debug
        public void PrintAll()
        {
            Node temp = _first;
            while (temp != null)
            {
                Console.WriteLine(temp.Data.ToShortString());
                temp = temp.Next;
            }
        }

        public void Sort()
        {
            Node nodeResult = _first;
            nodeResult.Previous = null;
            _first = _first.Next;
            nodeResult.Next = null;
            while (_first != null)
            {
                Node temp = nodeResult;
                Node nextFirst = _first.Next;
                while (temp != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. " + temp.Data.ToShortString());
                    Console.WriteLine("2. " + _first.Data.ToShortString());
                    Console.WriteLine("1 or 2");
                    string input = Console.ReadLine();
                    bool secondValue = input == "2" ? true : false;
                    if (!secondValue)
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                            continue;
                        }
                        else
                        {
                            temp.Next = _first;
                            _first.Previous = temp;
                            _first.Next = null;
                        }
                    }
                    else
                    {
                        if (temp.Previous == null)
                        {
                            _first.Previous = null;
                            _first.Next = nodeResult;
                            nodeResult.Previous = _first;
                            nodeResult = _first;
                        }
                        else
                        {
                            temp.Previous.Next = _first;
                            _first.Previous = temp.Previous;
                            _first.Next = temp;
                            temp.Previous = _first;
                        }
                    }
                    _first = nextFirst;
                    break;
                }
            }
            _first = nodeResult;
            int i = 0;
            while (nodeResult != null)
            {
                nodeResult.Data.Priority = ++i;
                if (nodeResult.Next != null)
                {
                    nodeResult = nodeResult.Next;
                }
                else
                {
                    _last = nodeResult;
                }
            }
        }
        private class Node
        {
            public Node(Task data, Node next = null, Node previous = null)
            {
                Data = data;
                Next = next;
                Previous = previous;
            }
            public Task Data { get;  set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }
    }
}
