using System;

namespace TodoDone.Core
{
    public class Task
    {
        private DateTime creationDate;
        private string task;

        public Task(string task)
        {
            this.creationDate = DateTime.Now;
            this.task = task;
        }
        
        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        public string getTask()
        {
            return task;
        }
    }
}
