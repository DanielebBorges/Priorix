namespace Priorix.Priorix.Core.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } // Data de vencimento
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
        public int UserId { get; set; }
    }
}
