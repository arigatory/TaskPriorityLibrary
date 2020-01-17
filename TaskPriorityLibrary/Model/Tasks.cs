using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskPriorityLibrary.Model
{
    public class Tasks
    {
        private List<Task> tasks;

        public Tasks()
        {
            LoadTestTasks();
        }
        public void LoadTestTasks()
        {
            tasks = new List<Task>
            {
                new Task("Read Troelsen","almost finished but still have to read"),
                new Task("Set up VPN","my rasbperry pi needs to be used all the way"),
                new Task("Neural Network","complete the book you're reading")
            };
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        //public List<Task> GetSortedTasks()
        //{
        //    List<Task> temp = new List<Task>();
        //    for (int i = 0; i < tasks.Count-1; i++)
        //    {
        //        Console.WriteLine($"Compare:\n" +
        //                          $"\t{tasks[i]}\n" +
        //                          $"\t{tasks[i+1]}\n" +
        //                          $"\tWhish is more important? 1 or 2?\n");
        //        string input = Console.ReadLine();
        //        if (input == "1")
        //        {

        //        }
        //    }
        //}

        //public void SortTasks()
        //{
        //    Console.WriteLine("Starting sorting...");
        //    List<Task> resTasks = new List<Task>();
        //    resTasks.Add(tasks[0]);
        //    for (int i = 1; i < tasks.Count; i++)
        //    {
        //        Task taskToCompare = tasks[i];
        //        for (int j = 0; j < resTasks.Count; j++)
        //        {
        //            Console.WriteLine("");
        //            PrintTasks(resTasks);
        //            Console.WriteLine("^");
        //            if (tasks[i].Name == resTasks[j].Name)
        //            {
        //                continue;
        //            }
        //            Console.WriteLine("Analysing two tasks:");
        //            Console.WriteLine($"\t{tasks[i]}");
        //            Console.WriteLine($"\t{resTasks[j]}");
        //            Console.Write("Wich one is more important? 1 or 2?\n>");
        //            string input = Console.ReadLine();
        //            if (input == "1")
        //            {
        //                resTasks.Insert(j, tasks[i]);
        //            }

        //            if (input == "2")
        //            {
        //                resTasks.Insert(j + 1, tasks[i]);
        //            }

        //        }
        //    }
        //    PrintTasks(resTasks);
        //    Console.WriteLine("\nTasks have been sorted!");
        //}
   
        private void PrintTasks(List<Task> rr)
        { 
            foreach (Task t in rr)
            {
                Console.WriteLine(t.ToShortString());
            }
        }
    }
}
