using System.Collections.Generic;

namespace ToDoListApp.ToDoData
{
    public class Data
    {
        public Data() { }

        public List<ToDoMainTask> mainTasks = new List<ToDoMainTask>();
    }

    public class ToDoBase
    {
        public ToDoBase() { }

        public ToDoBase(string Name, List<Tag> tags) 
        {
            this.Name = Name;
            this.tags = tags;
        }

        public string Name { get; set; }
        public bool State { get; set; }
        public List<Tag> tags { get; set; }
    }

    public class ToDoMainTask : ToDoBase
    {
        public List<ToDoSubTask> subTasks = new List<ToDoSubTask>();

        public ToDoMainTask() { }

        public ToDoMainTask(string Name, List<Tag> tags) : base(Name, tags)
        { 
            subTasks = new List<ToDoSubTask>();
        }

        public ToDoMainTask(string Name, List<Tag> tags, List<ToDoSubTask> subtasks) : base(Name, tags)
        {
            this.subTasks = subtasks;
        }
    }

    public class ToDoSubTask : ToDoBase
    {
        public ToDoSubTask() { }

        public ToDoSubTask(string Name, List<Tag> tags) : base (Name, tags)
        {

        }
    }
}
