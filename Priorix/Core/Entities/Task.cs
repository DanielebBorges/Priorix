namespace Priorix.Priorix.Core.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ResponsibleUserId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public int EffortEstimated { get; set; }
        public int ImpactExpected { get; set; }
        public int Urgency { get; set; }
        public int PriorityScore { get; set; }
        public string AIRecommendation { get; set; }
        public string Justification { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }


}
