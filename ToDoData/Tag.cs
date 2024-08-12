using System.Drawing;

namespace ToDoListApp.ToDoData
{
    public class Tag
    {
        public Color tagColor {  get; set; }
        public string Name { get; set; }

        public Tag(Color tagColor, string Name)
        {
            this.tagColor = tagColor;
            this.Name = Name;
        }

        public Tag() { }
    }
}
