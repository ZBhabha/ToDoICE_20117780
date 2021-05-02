using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    
    class ToDo
    {
        
        private string description;
        private DateTime date;
        private string priority;

        public ToDo(string description, DateTime date, string priority)
        {
            this.description = description;
            this.date = date;
            this.priority = priority;
        }

        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Priority { get => priority; set => priority = value; }

        public override string ToString()
        {
            return this.Description + "(" + this.Priority + ")" + "-"+this.Date ;
        }
    }
}
