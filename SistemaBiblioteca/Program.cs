Console.WriteLine("Escriba su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"hola {nombre}, bienvenido al sistema de biblioteca");

Console.WriteLine("\nPresione cualquier tecla para ingresar al menu..");
Console.ReadKey();

Console.Clear();

Console.WriteLine("====== SISTEMA BIBLIOTECA ======");
Console.WriteLine("1. Agregar libro");
Console.WriteLine("2. Mostrar libros");
Console.WriteLine("3. Salir");

Console.Write("\nSeleccione una opcion: ");
string opcion = Console.ReadLine();

Console.WriteLine($"Elegiste la opción {opcion}");


if(opcion == "1")
{
    Console.WriteLine("Has seleccionado Agregar libro");
}
else if(opcion == "2") 
{
    Console.WriteLine("Has seleccionado Mostrar libros");
}
else if (opcion == "3") 
{
    Console.WriteLine("Saliendo del Sistema..");
}
else
    {
                Console.WriteLine("Opción incorrecta");
            }

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();