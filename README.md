🛒 E-commerce Platform
This is a modular and layered E-commerce system built using C# and .NET, following clean architecture principles. It separates domain logic, application services, infrastructure, and identity management into distinct projects, making it scalable and maintainable.

📁 Project Structure
E-Commerce.Domain – Contains domain entities and business rules (Products, Orders, Customers, etc.)

E-Commerce.Application – Contains application services that orchestrate domain logic

E-Commerce.Application.Contact – Defines DTOs and service contracts for communication

E-Commerce.Infrastructure.EFCore – Entity Framework Core implementations for data persistence

E-Commerce.Infrastructure.Identity – Handles user identity and authentication

E-Commerce.Infrastructure.Configuration – Contains configuration and dependency injection setup

0_Framework – Base classes and shared utilities used across layers

✅ Key Features
Clean Architecture with separation of concerns

Entity Framework Core for data access

Modular structure for better scalability

User authentication and identity management system

Follows SOLID principles and dependency injection

🔧 Prerequisites
.NET 6 SDK or higher

SQL Server (or another compatible RDBMS)

Visual Studio / Visual Studio Code

🚀 Getting Started
Clone the repository:

bash
Copy
Edit
git clone https://github.com/hejazij88/E-commerce.git
Configure the database connection string in the relevant configuration file.

Apply database migrations:

bash
Copy
Edit
dotnet ef database update
Run the project:

bash
Copy
Edit
dotnet run
🧪 Testing
You can use tools like xUnit or NUnit to implement and run unit tests.

For API testing and documentation, Swagger can be integrated easily.

