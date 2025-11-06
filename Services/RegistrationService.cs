using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class RegistrationService
    {
        private List<Registration> registrations = new();

        public bool RegisterForEvent(Registration registration)
        {
            // Validate registration
            if (string.IsNullOrWhiteSpace(registration.Name) ||
                string.IsNullOrWhiteSpace(registration.Email) ||
                string.IsNullOrWhiteSpace(registration.Phone) ||
                registration.EventId <= 0)
            {
                return false;
            }

            // Check for duplicate registration
            var existingRegistration = registrations.FirstOrDefault(r =>
                r.Email == registration.Email && r.EventId == registration.EventId);

            if (existingRegistration != null)
            {
                return false; // Already registered
            }

            registration.Id = registrations.Any() ? registrations.Max(r => r.Id) + 1 : 1;
            registration.RegistrationDate = DateTime.Now;
            registrations.Add(registration);

            return true;
        }

        public List<Registration> GetAllRegistrations()
        {
            return registrations;
        }

        public List<Registration> GetRegistrationsByEvent(int eventId)
        {
            return registrations.Where(r => r.EventId == eventId).ToList();
        }

        public List<Registration> GetRegistrationsByEmail(string email)
        {
            return registrations.Where(r => r.Email.Equals(email, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public int GetRegistrationCount(int eventId)
        {
            return registrations.Count(r => r.EventId == eventId);
        }

        public bool CancelRegistration(int registrationId)
        {
            var registration = registrations.FirstOrDefault(r => r.Id == registrationId);
            if (registration == null)
                return false;

            registrations.Remove(registration);
            return true;
        }
    }
}
