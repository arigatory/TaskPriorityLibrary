using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPriorityLibrary.Model
{
    public class Task : IComparable
    {
        public int Priority;
        private DateTime _dateTimeCreated;
        private DateTime _lastAcsess;
        
        public Task()
        :this("no name","no description")
        {
            Priority = 0;
            _dateTimeCreated = DateTime.Now;
            Completed = false;
        }

        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            Priority = 0;
            _dateTimeCreated = DateTime.Now;
            Completed = false;
        }

        public bool Completed { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Sorted { get; set; }

        public int CompareTo(object obj)
        {
            return Priority.CompareTo(obj);
        }

        public override string ToString()
        {
            return $"{Name}: {Description} from {_dateTimeCreated.ToString()}\n  priority: {Priority}";
        }

        public string ToShortString()
        {
            return $"{Name}: {Priority}";
        }
    }
}
