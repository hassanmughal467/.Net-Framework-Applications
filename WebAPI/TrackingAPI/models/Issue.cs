using System.ComponentModel.DataAnnotations;

namespace TrackingAPI.models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public Priority Priority { get; set; }

        public IssueType Type { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime? Completed { get; set; }
    }

    public enum Priority
    { low, Medium , high }

    public enum IssueType
    {
        Feature, Bug, Documentation
    }
}
