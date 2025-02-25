namespace TodoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public required string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}