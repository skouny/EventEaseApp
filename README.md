# EventEase Application

EventEase is a comprehensive event management web application built with **Blazor Server** in **.NET 9.0**. The application allows users to browse events, register for events, and track attendance.

## Features

### Core Functionality

- **Event Browsing**: View all available events with detailed information
- **Event Details**: See comprehensive information about each event including capacity, location, and date
- **Registration System**: Complete form validation and user registration for events
- **Attendance Tracker**: Monitor event participation and capacity in real-time
- **Session Management**: Track user activity and viewed events during their session

### Technical Highlights

- **Input Validation**: Comprehensive form validation using Data Annotations
- **Error Handling**: Graceful error handling for invalid inputs and edge cases
- **State Management**: Centralized state management using singleton and scoped services
- **Responsive Design**: Mobile-friendly UI using Bootstrap 5
- **Performance Optimized**: Efficient data handling and rendering

## Project Structure

```txt
EventEaseApp/
├── Components/
│   ├── Layout/              # Application layout components
│   ├── Pages/               # Razor pages/routes
│   └── EventCard.razor      # Reusable event card component
├── Models/
│   ├── Event.cs            # Event model
│   ├── Registration.cs     # Registration model with validation
│   └── UserSession.cs      # User session model
├── Services/
│   ├── EventService.cs     # Event management service
│   ├── RegistrationService.cs  # Registration management service
│   └── SessionService.cs   # Session tracking service
└── wwwroot/                # Static assets
```

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### Running the Application

1. Clone the repository
2. Navigate to the project directory
3. Run the application:

   ```bash
   dotnet run
   ```

4. Open your browser and navigate to:
   - HTTP: `http://localhost:5022`
   - HTTPS: `https://localhost:7237`

## Pages

### Home (`/`)

- Welcome page with overview of EventEase features
- Quick navigation to browse events and register

### Events (`/events`)

- Browse all available events
- View event cards with key information
- Navigate to detailed event pages

### Event Details (`/event-details/{id}`)

- Comprehensive event information
- Capacity tracking with visual indicators
- Direct registration link
- Breadcrumb navigation

### Register (`/register`)

- User registration form with validation
- Event selection dropdown
- Form fields:
  - Full Name (required)
  - Email (required, validated format)
  - Phone (required, validated format)
  - Company/Organization (optional)
  - Special Requirements (optional)
- Success confirmation with next steps

### Attendance Tracker (`/attendance`)

- Overview statistics (total events, registrations, views)
- Session information display
- Detailed attendance table with capacity indicators
- Event registration list viewer

## Services

### EventService

- Manages event data
- Handles event retrieval and updates
- Validates event capacity
- Tracks attendee registration

### RegistrationService

- Manages user registrations
- Prevents duplicate registrations
- Validates registration data
- Provides registration queries

### SessionService

- Tracks user session information
- Records viewed and registered events
- Monitors session activity
- Manages session duration

## Validation

The application implements comprehensive validation:

- **Email**: Valid email format required
- **Phone**: Standard phone number format (123-456-7890 or (123) 456-7890)
- **Name**: 2-100 characters
- **Special Requirements**: Maximum 500 characters
- **Event Selection**: Must select valid event
- **Capacity Check**: Prevents registration for full events
- **Duplicate Check**: Prevents duplicate registrations

## Development Activities

This project was developed following three structured activities:

### Activity 1: Generate Blazor Code

- Created Event Card component with data binding
- Implemented routing between pages
- Set up foundational codebase

### Activity 2: Debugging and Optimization

- Added input validation
- Implemented error handling for invalid paths
- Optimized performance with centralized service management
- Fixed data binding issues

### Activity 3: Develop Comprehensive Project

- Created Registration Form with validation
- Implemented Session Tracker for state management
- Added Attendance Tracker for monitoring participation
- Prepared application for production

## Technologies Used

- **.NET 9.0**
- **Blazor Server**
- **Bootstrap 5**
- **C# 12**
- **Razor Components**
- **Data Annotations for validation**

## Best Practices Implemented

- **Separation of Concerns**: Models, Services, and Components are well-organized
- **Dependency Injection**: Services are properly registered and injected
- **Error Handling**: Try-catch blocks with user-friendly error messages
- **Input Validation**: Server-side validation using Data Annotations
- **Responsive Design**: Mobile-first approach using Bootstrap
- **Code Reusability**: Shared components (EventCard)
- **State Management**: Centralized data management through services

## Future Enhancements

- Database integration (Entity Framework Core)
- User authentication and authorization
- Email notification system
- Event search and filtering
- Calendar view for events
- Payment integration for paid events
- Admin dashboard for event management
- Export attendance reports

## License

This project is for educational purposes.

## Author

Developed as part of Microsoft Copilot for Blazor development course.
