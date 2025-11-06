namespace EventEaseApp.Models
{
    public class UserSession
    {
        public string SessionId { get; set; } = Guid.NewGuid().ToString();
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public DateTime SessionStart { get; set; } = DateTime.Now;
        public DateTime LastActivity { get; set; } = DateTime.Now;
        public List<int> ViewedEvents { get; set; } = new();
        public List<int> RegisteredEvents { get; set; } = new();
        public bool IsActive => (DateTime.Now - LastActivity).TotalMinutes < 30;
    }
}
