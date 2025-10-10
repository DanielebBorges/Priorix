namespace Priorix.Priorix.Core.Entities
{
    public class TaskHistory
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Action { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
