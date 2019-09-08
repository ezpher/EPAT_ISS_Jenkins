using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
        private String description = null;
        private bool isCompleted = false;


        public Task(String description)
        {
            this.description = description;
        }

        public Task(String description, bool isComplete)
        {
            this.description = description;
            this.isCompleted = isComplete;
        }

        public String getDescription()
        {
            return description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public bool isComplete()
        {
            return isCompleted;
        }
        public void setComplete(bool isComplete)
        {
            this.isCompleted = isComplete;
        }
    }

}
