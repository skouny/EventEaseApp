using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class SessionService
    {
        private UserSession currentSession = new();

        public UserSession GetCurrentSession()
        {
            return currentSession;
        }

        public void UpdateActivity()
        {
            currentSession.LastActivity = DateTime.Now;
        }

        public void SetUserInfo(string name, string email)
        {
            currentSession.UserName = name;
            currentSession.UserEmail = email;
            UpdateActivity();
        }

        public void AddViewedEvent(int eventId)
        {
            if (!currentSession.ViewedEvents.Contains(eventId))
            {
                currentSession.ViewedEvents.Add(eventId);
            }
            UpdateActivity();
        }

        public void AddRegisteredEvent(int eventId)
        {
            if (!currentSession.RegisteredEvents.Contains(eventId))
            {
                currentSession.RegisteredEvents.Add(eventId);
            }
            UpdateActivity();
        }

        public TimeSpan GetSessionDuration()
        {
            return DateTime.Now - currentSession.SessionStart;
        }

        public void ResetSession()
        {
            currentSession = new UserSession();
        }
    }
}
