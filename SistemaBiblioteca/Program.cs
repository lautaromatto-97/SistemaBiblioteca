using SistemaBiblioteca;

List<Libro> miBiblioteca = new List<Libro>();


Console.WriteLine("Escriba su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"hola {nombre}, bienvenido al sistema de biblioteca");

Console.WriteLine("\nPresione cualquier tecla para ingresar al menu..");
Console.ReadKey();

Console.Clear();

bool salir = false;

while (salir == false)
 
{
    Console.Clear();
    Console.WriteLine("====== SISTEMA BIBLIOTECA ======");
    Console.WriteLine("1. Agregar libro");
    Console.WriteLine("2. Mostrar libros");
    Console.WriteLine("3. Salir");

    Console.Write("\nSeleccione una opcion: ");
    string opcion = Console.ReadLine();

    Console.WriteLine($"Elegiste la opción {opcion}");


    if (opcion == "1")
    {
        Console.Clear();
        Console.WriteLine("Has seleccionado Agregar libro");
        Console.WriteLine("Ingrese el título del libro: ");
        string TituloIngresado = Console.ReadLine();
        Console.WriteLine("Ingrese el autor del libro: ");
        string AutorIngresado = Console.ReadLine();
        Console.WriteLine($"Libro agregado: {TituloIngresado} de {AutorIngresado}");

        Libro nuevoLibro = new Libro();
        nuevoLibro.Titulo = TituloIngresado;
        nuevoLibro.Autor = AutorIngresado;

        miBiblioteca.Add(nuevoLibro); //estamos guardando el libro en la lista de libros

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();

    }
    else if (opcion == "2")
   
        {
            Console.Clear();

        Console.WriteLine("Has seleccionado Mostrar libros...");
        Console.WriteLine("Presione enter para acceder a la lista de libros");
        Console.ReadKey();
        Console.Clear();  
        Console.WriteLine("====== LISTA DE LIBROS ======");
        foreach (Libro libro in miBiblioteca)
            {
                Console.WriteLine($"Titulo: {libro.Titulo} - Autor: {libro.Autor}");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

    else if (opcion == "3")
    {
        Console.WriteLine("Saliendo del Sistema..");
        salir = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opción incorrecta");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }
}
Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey(); Console.Clear();