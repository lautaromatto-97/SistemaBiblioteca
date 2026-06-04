Console.WriteLine("Escriba su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"hola {nombre}, bienvenido al sistema de biblioteca");

Console.WriteLine("\nPresione cualquier tecla para ingresar al menu..");
Console.ReadKey();

Console.Clear();

Console.WriteLine("====== SISTEMA BIBLIOTECA ======");
Console.WriteLine("1. Agregar libro");
Console.WriteLine("2. Mostra libros");
Console.WriteLine("3. Salir");

Console.WriteLine("\nSeleccione una opcion: ");
string opcion = Console.ReadLine();

Console.WriteLine($"Elegiste la opción {opcion}");
