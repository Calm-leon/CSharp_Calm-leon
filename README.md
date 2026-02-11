# Restaurant 10 Tables Reservation System

## 📋 Description

A simple console-based reservation management system for a restaurant with 10 tables. The application allows users to either log in as existing customers or register as new ones to make dinner reservations.

---

## 🎯 Objective

Create a functional reservation system that:
- Validates registered users and provides them with access
- Manages new user registrations with unique names
- Maintains a capacity limit of 10 reservations (one per table)
- Displays all confirmed reservations once the restaurant reaches full capacity

---

## 🛠️ Technologies Used

- **Language**: C# .NET
- **Type**: Console Application (.NET Core/Framework)
- **Runtime**: .NET 6.0 or higher
- **IDE**: Visual Studio / Visual Studio Code

---

## 📁 Project Structure

```
Restaurant10TablesReservationSystem/
├── Restaurant10TablesReservationSystem.sln      # Visual Studio Solution file
└── Restaurant10TablesReservationSystem/          # Main project folder
    ├── Program.cs                                # Main application logic
    └── Restaurant10TablesReservationSystem.csproj # Project configuration
```

---

## ⚙️ How to Run

### Prerequisites
- .NET 6.0 or higher installed
- Visual Studio or Visual Studio Code with C# extension

### Running the Application

**Option 1: Using Visual Studio**
1. Open `Restaurant10TablesReservationSystem.sln`
2. Press `F5` or click "Run" to start the application
3. Follow the console prompts

**Option 2: Using Command Line**
```bash
cd Restaurant10TablesReservationSystem\Restaurant10TablesReservationSystem
dotnet run
```

**Option 3: Using Visual Studio Code**
1. Open the project folder in VS Code
2. Open the terminal and run: `dotnet run`

---

## 🎮 How to Use

1. **Launch the application** - You'll see the welcome message
2. **When prompted**, enter `true` if you're a registered user or `false` to register
3. **If registered user**:
   - Enter your exact user name
   - System checks if you exist
   - If found, you're welcomed back
4. **If new user**:
   - Enter a user name you'll remember
   - Your reservation will be confirmed with a table number
5. **Process repeats** until all 10 tables are booked
6. **Final screen** displays all dinner guests with their assigned tables

### Example Interaction
```
Welcome to the best restaurant in the world!

--------------------------------------
Are you a registered user? (true/false)
false
Please enter and remember your User Name:
John Smith
✓ User registered successfully!
  User Name: John Smith
  Table: 1/10
```

---

## 📚 Key Concepts Demonstrated

### Object-Oriented Programming (OOP)
- **Encapsulation**: Using constants and semantic variable naming
- **Modularity**: Clear logical flow in the main program
- **State Management**: Tracking reservations and user data

### Business Logic
- **Data Validation**: Checking for duplicate registrations
- **User Authentication**: Distinguishing between registered and new users
- **Data Persistence**: Temporary storage of reservation information

### C# Fundamentals
- **Arrays**: Dynamic storage of user names
- **Control Flow**: Loops and conditional statements
- **String Manipulation**: User input handling and formatting
- **Input/Output**: Console-based user interactions
- **Error Handling**: Input validation with `TryParse`

---

## 🔍 Code Quality Improvements

This version includes:
- **Clear Comments**: Comprehensive documentation of functionality
- **Semantic Variables**: Meaningful variable names (e.g., `currentReservationCount` instead of `arrayCurrentIndex`)
- **Input Validation**: Safe parsing of user input with `TryParse`
- **Null Safety**: Trim and null-check on string inputs
- **Better UX**: Enhanced console output with visual separators
- **Constants**: Magic numbers replaced with named constants
- **String Interpolation**: Modern C# syntax for cleaner output

---

## 📝 Future Enhancements (Optional)

Potential improvements without changing core architecture:
- Add reservation date/time tracking
- Implement a simple file-based persistence (save/load reservations)
- Add party size information per reservation
- Include reservation cancellation functionality
- Add reservation search by date or guest name

---

## 📄 License

This project is provided as-is for educational purposes.

---

## 📧 Support

For questions or issues, please refer to the project comments in `Program.cs`.

---

**Last Updated**: February 2026  
**Version**: 1.1 (Improved with documentation and code quality enhancements)
