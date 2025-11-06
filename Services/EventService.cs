using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private List<Event> events = new();

        public EventService()
        {
            // Initialize with mock data
            events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Tech Conference 2025",
                    Date = new DateTime(2025, 12, 15),
                    Location = "San Francisco, CA",
                    Description = "Annual technology conference featuring the latest in AI and cloud computing.",
                    MaxAttendees = 500,
                    CurrentAttendees = 342
                },
                new Event
                {
                    Id = 2,
                    Name = "Marketing Summit",
                    Date = new DateTime(2025, 11, 20),
                    Location = "New York, NY",
                    Description = "Learn the latest digital marketing strategies from industry experts.",
                    MaxAttendees = 300,
                    CurrentAttendees = 287
                },
                new Event
                {
                    Id = 3,
                    Name = "Developer Workshop",
                    Date = new DateTime(2025, 11, 30),
                    Location = "Seattle, WA",
                    Description = "Hands-on workshop covering modern web development with Blazor.",
                    MaxAttendees = 150,
                    CurrentAttendees = 89
                },
                new Event
                {
                    Id = 4,
                    Name = "Business Networking Event",
                    Date = new DateTime(2025, 12, 5),
                    Location = "Chicago, IL",
                    Description = "Connect with professionals and expand your business network.",
                    MaxAttendees = 200,
                    CurrentAttendees = 156
                },
                new Event
                {
                    Id = 5,
                    Name = "Product Launch",
                    Date = new DateTime(2026, 1, 10),
                    Location = "Austin, TX",
                    Description = "Exclusive product launch event for our newest innovations.",
                    MaxAttendees = 250,
                    CurrentAttendees = 78
                },
                new Event
                {
                    Id = 6,
                    Name = "Leadership Retreat",
                    Date = new DateTime(2026, 1, 25),
                    Location = "Denver, CO",
                    Description = "Executive leadership development and team building retreat.",
                    MaxAttendees = 100,
                    CurrentAttendees = 92
                }
            };
        }

        public List<Event> GetAllEvents()
        {
            return events;
        }

        public Event? GetEventById(int id)
        {
            // Add validation to handle invalid IDs
            if (id <= 0)
                return null;

            return events.FirstOrDefault(e => e.Id == id);
        }

        public bool AddEvent(Event newEvent)
        {
            // Add validation
            if (string.IsNullOrWhiteSpace(newEvent.Name) ||
                string.IsNullOrWhiteSpace(newEvent.Location) ||
                newEvent.MaxAttendees <= 0 ||
                newEvent.Date < DateTime.Now)
            {
                return false;
            }

            newEvent.Id = events.Any() ? events.Max(e => e.Id) + 1 : 1;
            newEvent.CurrentAttendees = 0;
            events.Add(newEvent);
            return true;
        }

        public bool UpdateEvent(Event updatedEvent)
        {
            var existingEvent = GetEventById(updatedEvent.Id);
            if (existingEvent == null)
                return false;

            // Validate update
            if (string.IsNullOrWhiteSpace(updatedEvent.Name) ||
                string.IsNullOrWhiteSpace(updatedEvent.Location) ||
                updatedEvent.MaxAttendees <= 0)
            {
                return false;
            }

            existingEvent.Name = updatedEvent.Name;
            existingEvent.Date = updatedEvent.Date;
            existingEvent.Location = updatedEvent.Location;
            existingEvent.Description = updatedEvent.Description;
            existingEvent.MaxAttendees = updatedEvent.MaxAttendees;

            return true;
        }

        public bool RegisterAttendee(int eventId)
        {
            var evt = GetEventById(eventId);
            if (evt == null || evt.CurrentAttendees >= evt.MaxAttendees)
                return false;

            evt.CurrentAttendees++;
            return true;
        }

        public int GetEventCount()
        {
            return events.Count;
        }

        public List<Event> GetUpcomingEvents()
        {
            return events
                .Where(e => e.Date >= DateTime.Now)
                .OrderBy(e => e.Date)
                .ToList();
        }
    }
}
