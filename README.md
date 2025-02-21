# CoffeeShopAPI

## High-Level Overview

The CoffeeShopAPI is a RESTful API built using C# and ASP.NET Core with Entity Framework Core for database interaction and SQLite as the database engine.

### Engineering Choices:

- **ASP.NET Core:** For building a RESTful API.
- **Entity Framework Core:** ORM for database management.
- **SQLite:** Lightweight and easy-to-configure database.
- **FluentValidation:** For validating incoming API requests.
- **Dependency Injection:** Ensures loose coupling and easy testing.
- **Separation of Concerns:** Controllers, Services, DTOs, Validators, and Data layers are distinctly organized.
- **Middleware:** Configured for CORS, Swagger documentation.

---

## Execution Instructions

### Dependencies Installation

Ensure you have the following installed:

- .NET SDK
- SQLite

### Setup Project

1. Navigate to the project directory.

2. Install dependencies:

   ```bash
   dotnet restore
   ```

3. Create migrations:

   ```bash
   dotnet ef migrations add InitialCreate
   ```

4. Apply migrations to create the database:

   ```bash
   dotnet ef database update
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Open Swagger to explore the API:
   - Navigate to: `http://localhost:5000/swagger`

---

## Endpoints

### 1. Get All Coffee Shops

- **Method:** `GET`
- **URL:** `/api/CoffeeShop`
- **Description:** Retrieves all coffee shops

### 2. Create a New Coffee Shop

- **Method:** `POST`
- **URL:** `/api/CoffeeShop`
- **Body Example:**

  ```json
  {
    "name": "Some Coffee Shop",
    "openingTime": "07:00",
    "closingTime": "19:00",
    "location": "Main Street",
    "rating": 4.8
  }
  ```

- **Validation Errors Example:**
  ```json
  {
    "errors": [
      {
        "propertyName": "Name",
        "errorMessage": "'Name' must not be empty."
      }
    ]
  }
  ```

