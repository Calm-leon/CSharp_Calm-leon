/*
 * 1. Validar si es usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 * 3. El programa debe repetirse hasta que se registren las 10 personas
 */

string[] userNames = new string[10] {"migue", "", "", "", "", "", "", "", "", ""};

int arrayCurrentIndex = 1;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world!");
while (true)
{
    Console.WriteLine("Are you registered user? Write true, or write false to register");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", userToSearch);
    }
}