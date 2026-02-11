// ============================================================================
// RESTAURANT RESERVATION SYSTEM - 10 TABLES
// ============================================================================
// Description: Simple console-based reservation system for a restaurant
// Functionality:
//   - Allows registered and new users to make reservations
//   - Stores up to 10 reservations (one per table)
//   - Validates existing users and registers new ones
//   - Displays all reservations when the restaurant is full

// Maximum capacity: 10 tables/reservations
const int MAX_RESERVATIONS = 10;

// Array to store registered user names
string[] userNames = new string[MAX_RESERVATIONS];

// Tracks the current number of reservations
int currentReservationCount = 0;
bool isRegisteredUser;

Console.WriteLine("Welcome to the best restaurant in the world!");

// Main reservation loop - continues until all 10 tables are booked
while (currentReservationCount < MAX_RESERVATIONS)
{
    Console.WriteLine("\n--------------------------------------");
    Console.WriteLine("Are you a registered user? (true/false)");
    
    // Get user input and convert to boolean
    if (!bool.TryParse(Console.ReadLine(), out isRegisteredUser))
    {
        Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
        continue;
    }

    if (isRegisteredUser)
    {
        // Handle registered user login
        Console.WriteLine("Please enter your exact user name:");
        string userToSearch = Console.ReadLine()?.Trim();
        
        // Search for the user in the registered names array
        int foundIndex = Array.IndexOf(userNames, userToSearch);

        if (foundIndex == -1)
        {
            Console.WriteLine("User not found. Please try again or register as a new user.");
        }
        else
        {
            Console.WriteLine($"Welcome back, {userToSearch}! It's a pleasure to serve you.");
        }
    }
    else
    {
        // Handle new user registration
        Console.WriteLine("Please enter and remember your User Name:");
        string newUserName = Console.ReadLine()?.Trim();

        // Validate input is not empty
        if (string.IsNullOrEmpty(newUserName))
        {
            Console.WriteLine("User name cannot be empty. Please try again.");
            continue;
        }

        // Store new user in the next available slot
        userNames[currentReservationCount] = newUserName;

        Console.WriteLine($"✓ User registered successfully!");
        Console.WriteLine($"  User Name: {newUserName}");
        Console.WriteLine($"  Table: {currentReservationCount + 1}/{MAX_RESERVATIONS}");
        
        currentReservationCount++;
    }
}

// Restaurant is full - display final summary
Console.WriteLine("\n============================================");
Console.WriteLine("The restaurant is now FULL!");
Console.WriteLine("Thank you for your reservations!");
Console.WriteLine("These are tonight's dinner guests:");
Console.WriteLine("============================================");

// Display all reservations with table numbers
for (int i = 0; i < MAX_RESERVATIONS; i++)
{
    Console.WriteLine($"Table {i + 1,2}: {userNames[i]}");
}

Console.WriteLine("============================================");
Environment.Exit(0);