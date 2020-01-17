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
            Task task1 = null;
            Task task2 = null;
            Node node1 = _first;
            while (node1 != null)
            {
                Node node2 = node1.Next;
                while (node2 != null)
                {
                    bool secondValue = false;
                    Console.WriteLine();
                    Console.WriteLine(node1.Data.ToShortString());
                    Console.WriteLine(node2.Data.ToShortString());
                    Console.WriteLine("1 or 2");
                    string input = Console.ReadLine();
                    secondValue = input == "2" ? true : false;
                    if (secondValue)
                    {
                        node2.Previous = node1.Previous;
                        node1.Next = node2.Next;
                        node1.Previous = node2;
                        node2.Next = node1.Next;
                        continue;
                    }
                    node2 = node2.Next;
                }
                node1 = node1.Next;
            }
            int i = 0;
            node1 = _first;
            while (node1 != null)
            {
                node1.Data.Priority = ++i ;
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
