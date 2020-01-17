using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using TaskPriorityLibrary.Model;


namespace TaskPriorityTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTasks myTasks = new MyTasks();
            Task t1 = new Task("Read Troelsen", "almost finished but still have to read");
            Task t2 = new Task("Set up VPN", "my rasbperry pi needs to be used all the way");
            Task t3 = new Task("Neural Network", "complete the book you're reading");


            myTasks.Add(t1);
            myTasks.Add(t2);
            myTasks.Add(t3);

            myTasks.PrintAll();

            myTasks.Sort();

            myTasks.PrintAll();

            Console.ReadLine();
        }
    }
}
