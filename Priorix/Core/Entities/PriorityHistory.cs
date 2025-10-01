
namespace Priorix.Priorix.Core.Entities
{
    public class PriorityHistory
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ChangedByUserId { get; set; }
        public string ChangeType { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangeDate { get; set; }
    }

}
