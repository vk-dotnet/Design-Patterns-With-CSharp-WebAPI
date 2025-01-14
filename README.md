📌 README.md - Design Patterns with .NET 8 Web API 🚀
# **Design Patterns with .NET 8 Web API** 🚀  

This project showcases the implementation of key **design patterns** in **.NET 8 Web API**, including:  
✅ **Singleton** - Managing shared resources efficiently.  
✅ **Factory** - Creating objects without exposing instantiation logic.  
✅ **Strategy** - Implementing interchangeable business logic dynamically.  
✅ **Repository** - Abstracting data access for better maintainability.  
✅ **CQRS** - Separating read and write operations for performance and scalability.  

---

## **📌 Project Structure**  

📂 DesignPatternsWebApi
├── 📂 DesignPatterns
│ ├── 📂 Singleton
│ │ ├── SingletonBasic.cs
│ ├── 📂 Factory
│ │ ├── IProduct.cs
│ │ ├── ConcreteProduct.cs
│ │ ├── ProductFactory.cs
│ ├── 📂 Repository
│ │ ├── IRepository.cs
│ │ ├── UserRepository.cs
│ ├── 📂 Strategy
│ │ ├── IDiscountStrategy.cs
│ │ ├── PercentageDiscount.cs
│ │ ├── FixedDiscount.cs
│ │ ├── DiscountContext.cs
│ ├── 📂 CQRS
│ │ ├── Commands
│ │ │ ├── CreateUserCommand.cs
│ │ ├── Queries
│ │ │ ├── GetUserQuery.cs
│ │ ├── Handlers
│ │ │ ├── CreateUserHandler.cs
│ │ │ ├── GetUserHandler.cs
├── 📂 Controllers
│ ├── SingletonController.cs
│ ├── FactoryController.cs
│ ├── RepositoryController.cs
│ ├── StrategyController.cs
│ ├── CqrsController.cs
├── 📂 Services
│ ├── SingletonService.cs
│ ├── FactoryService.cs
│ ├── UserService.cs
│ ├── StrategyService.cs
│ ├── CqrsService.cs
├── 📂 UnitTests
│ ├── SingletonTests.cs
│ ├── FactoryTests.cs
│ ├── RepositoryTests.cs
│ ├── StrategyTests.cs
│ ├── CqrsTests.cs
├── 📄 README.md
├── DesignPatternsWebApi.csproj
├── Program.cs
├── appsettings.json


---

## **📌 How to Run the Project?**  

### **1️⃣ Clone the Repository**  
```sh
git clone https://github.com/YOUR_GITHUB_USERNAME/Design-Patterns-With-CSharp-WebAPI.git
cd Design-Patterns-With-CSharp-WebAPI
2️⃣ Build and Run the Project
dotnet build
dotnet run
3️⃣ API Endpoints
Pattern	Endpoint
Singleton	/api/singleton
Factory	/api/factory?type=A
Repository	/api/repository/users
Strategy	/api/strategy/discount?type=percentage&price=100
CQRS	/api/cqrs/users
4️⃣ Access Swagger Documentation
After running the project, open Swagger UI:

http://localhost:5000/swagger
📌 Unit Testing

Unit tests are implemented using xUnit. You can find the test cases inside the UnitTests folder.

✅ Run all unit tests:

dotnet test
🔹 Below is a test result screenshot demonstrating the successful execution of our test cases:

(Insert Test Result Screenshot Here)

📌 Technologies Used

.NET 8 Web API
MediatR (for CQRS)
Entity Framework Core
PostgreSQL / SQL Server
xUnit for Unit Testing
Swagger for API Documentation
RESTful API Principles
