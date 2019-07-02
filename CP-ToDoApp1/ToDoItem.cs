namespace CP_ToDoApp1
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public ToDoItem(string description)
        {
            Description = description;
        }
    }
}