# InventoryManagementSystem
Technical assessment for Jr. C# Developer position - Inventory Management System
# Inventory Management System

A simple console-based inventory management system developed in C# for retail store management.

## Features

- Product management (Add/Remove/Update)
- Inventory tracking
- Stock quantity updates
- Total inventory value calculation
- User-friendly console interface

## Requirements

- .NET Core SDK (version 6.0 or later)
- Visual Studio 2019/2022 or VS Code

## Installation

1. Clone the repository:
   ```bash
   git clone [your-repository-url]
   ```

2. Navigate to the project directory:
   ```bash
   cd InventoryManagementSystem
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

## Usage

The application provides a menu-driven interface with the following options:

- Add Product - Add a new product to inventory
- Remove Product - Remove an existing product
- Update Product Quantity - Modify stock quantity
- List Products - Display all products
- Get Total Inventory Value - Calculate total value
- Exit - Close the application

### Input Constraints

- Product IDs must be positive integers
- Prices must be non-negative real numbers
- Quantities must be non-negative integers
- Each product ID must be unique

## Screenshots

[Screenshots will be added showing the application in action]

## Project Structure

- `Program.cs` - Main application entry point and UI
- `Product.cs` - Product class definition
- `InventoryManager.cs` - Core inventory management logic

## Testing

The application includes validation for all inputs and handles edge cases appropriately.

## Contributing

This is a technical assessment project and is not open for contributions.

## License

MIT License

Copyright (c) 2025 Joshua Rivas

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
