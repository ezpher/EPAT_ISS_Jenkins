using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TodoList
    {
        private Dictionary<String, Task> tasks = new Dictionary<String, Task>();

        public void addTask(Task task)
        {
            //Add code here
            tasks.Add(task.getDescription(), task);
        }
        public void completeTask(String description)
        {
            // Add code here    
            // Get the first key-value pair from dictionary and retrieve its value i.e. its task
            Task task = tasks.FirstOrDefault(t => t.Value.getDescription() == description).Value;
            if (task != null)
            {
                task.setComplete(true);
            }
        }
        public bool getStatus(String description)
        {
            //Add code here
            Task task = tasks.FirstOrDefault(t => t.Value.getDescription() == description).Value;
            if (task != null)
            {
                return task.isComplete();
            }

            return false;
        }
        public Task getTask(String description)
        {
            // Add code here            
            Task task = tasks.FirstOrDefault(t => t.Value.getDescription() == description).Value;
            if (task != null)
            {
                return task;
            }

            return null;
        }
        public bool removeTask(String description)
        {
            // Add code here
            string key = tasks.FirstOrDefault(t => t.Value.getDescription() == description).Key;
            if (key != null)
            {
                return tasks.Remove(key);
            }
            else
            {
                return false;
            }
        }
        public ICollection<Task> getAllTasks()
        {
            return tasks.Values;
        }
        public ICollection<Task> getCompletedTasks()
        {
            // Add code here
            var completedTasks = tasks.Where(t => t.Value.isComplete() == true).Select(t => t.Value);
            if (completedTasks != null)
            {
                return completedTasks.ToList();
            }

            return null;
        }
    }
}

