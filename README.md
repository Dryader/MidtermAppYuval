# MidtermAppYuval

A phone ordering system built with ASP.NET Core MVC that allows users to order phones (Android, iPhone, Galaxy) with customization options.

## Technology Stack

- **Framework**: ASP.NET Core 9.0
- **Language**: C# with .NET 9.0
- **Architecture**: MVC (Model-View-Controller)
- **UI**: Razor Views with Bootstrap

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Visual Studio 2022, Visual Studio Code, or JetBrains Rider (optional)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Dryader/MidtermAppYuval.git
   cd MidtermAppYuval
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

## Running the Application

To run the application in development mode:

```bash
dotnet run --project MidtermAppYuval/MidtermAppYuval.csproj
```

The application will be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## Project Structure

```
MidtermAppYuval/
├── MidtermAppYuval/           # Main application project
│   ├── Business/              # Business logic layer
│   │   └── OrderService.cs    # Order management service
│   ├── Controllers/           # MVC Controllers
│   │   └── HomeController.cs  # Main controller
│   ├── Models/                # Data models
│   │   ├── Order.cs           # Order model
│   │   ├── ReceiptModel.cs    # Receipt model
│   │   └── ErrorViewModel.cs  # Error handling model
│   ├── Views/                 # Razor views
│   │   ├── Home/              # Home views
│   │   └── Shared/            # Shared layouts
│   ├── wwwroot/               # Static files (CSS, JS, images)
│   ├── Program.cs             # Application entry point
│   └── appsettings.json       # Configuration settings
└── MidtermAppYuval.sln        # Solution file
```

## Features

- **Phone Selection**: Choose from Android, iPhone, or Galaxy phones
- **Payment Options**: Credit or Debit card payment methods
- **Customization**: Select phone color and quantity
- **Tip Option**: Optional tip for the order
- **Order Receipt**: View order summary and total price
- **Order History**: Track previous orders
- **Responsive Design**: Mobile-friendly interface

## Development

### Building the Solution

```bash
dotnet build MidtermAppYuval.sln
```

### Configuration

Application settings can be modified in:
- `appsettings.json` - Production settings
- `appsettings.Development.json` - Development-specific settings

## License

This project is a midterm application developed for educational purposes.

## Author

Yuval Matasaro (Student ID: 991735973)
