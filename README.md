# SmartStock - Mini Inventory Management System

SmartStock is a simple ASP.NET Core MVC web application designed for managing products in an inventory system. It allows users to create, read, update, and delete (CRUD) products, with filtering and search capabilities.

---

## Features

- Product listing with search and category filter
- Add new products with validation
- Edit existing products with validation
- View detailed product information
- Delete products with confirmation popup
- Server-side and client-side validation using DataAnnotations
- Responsive UI using Bootstrap 5
- User-friendly notifications with Toastr and SweetAlert2
- Database seeded with initial sample data
- Clean and organized codebase following MVC pattern

---

## Technologies Used

- ASP.NET Core MVC (.NET 6+)
- Entity Framework Core (Code First)
- SQL Server (or any EF Core-supported database)
- Bootstrap 5 for responsive UI
- jQuery, Toastr, SweetAlert2 for client-side interactivity
- DataTables (optional, for enhanced table features)

---

## Getting Started

### Prerequisites

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- SQL Server or compatible database
- IDE such as Visual Studio 2022 or Visual Studio Code

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/mahmudulmadu/SmartStock.git
   cd SmartStock
   
2. Configure the database connection string in appsettings.json:
   
 ```bash
"ConnectionStrings": {
  "DefaultConnection": "YourConnectionStringHere"
}
```
3. Apply migrations, seed database and Run Project:

### Project Structure

Controllers/ - MVC controllers handling web requests

Models/ - Entity and view models with validation attributes

Data/ - EF Core DbContext and seed data configuration

Views/ - Razor views for UI (Create, Edit, Index, Details)

wwwroot/ - Static files (CSS, JS, libraries)

### Validation & Error Handling
Data annotations enforce validation rules on the Product model

Client-side validation scripts provide instant feedback

Server-side validation ensures data integrity

Toastr notifications show success and error messages

SweetAlert2 displays confirmation dialogs for deletions

Global error handling (optional) can be added for unhandled exceptions


### Contribution
Feel free to fork the repository and submit pull requests. For major changes, please open an issue first to discuss what you would like to change.

### License
This project is licensed under the MIT License.

### Author
Made with ❤️ by Mahmudul Hasan

