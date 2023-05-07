/*
 * 1. Validar si es usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 * 3. El programa debe repetirse hasta que se registren las 10 personas
 */

string[] userNames = new string[10] {"", "", "", "", "", "", "", "", "", ""};

int arrayCurrentIndex = 0;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world!");
while (arrayCurrentIndex < 10)
{
    /*if (arrayCurrentIndex == 10)
    {
        Console.WriteLine("The restaurant is full, try again the next year");
        Environment.Exit(0);
    }*/
    Console.WriteLine("\n \nAre you registered user? Write true, or write false to register");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch);

        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else
        {
            Console.WriteLine("Welcome {0}, it's a pleasure to give your food", userToSearch);
        }
    }
    else if (userType == false)
    {
        Console.WriteLine("Please write and remember your User Name");

        userNames[arrayCurrentIndex] = Console.ReadLine();

        Console.WriteLine("Your User has been saved successfully\n" + 
                          "Your User Name is> {0}", userNames[arrayCurrentIndex]);
        arrayCurrentIndex++;
    }
}

Console.WriteLine("The restaurant is full, try again the next year\n These are the guest to the dinner:");

int auxIndex = 0;
foreach (string element in userNames)
{
    Console.WriteLine("User number: {0} and user name: {1}", auxIndex + 1, userNames[auxIndex]);
    auxIndex++;
}
Environment.Exit(0);