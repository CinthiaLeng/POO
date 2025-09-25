// See https://aka.ms/new-console-template for more information



Console.WriteLine("***Bienvenido a la Biblioteca del Equipo 3***\nPor favor, elija una opción: ");


Console.WriteLine("1 = Agregar lector\n2 = Agregar libro\n3 = Listar libros\n4 = Prestar libros\n5 = Devolver libros\n6 = Salir");


string option = Console.ReadLine();


do
{

    switch(option)
    {
        case "1":

            break;

        case "2":

            break;

        case "3":

            break;

        case "4":

            break;

        case "5":

            break;

        case "6":
            Console.WriteLine("Saliendo del sistema... \nQue tenga un lindo día!" );
            break;

        default:
            Console.WriteLine("Ingrese una opción válida: \n1 = Agregar lector\n2 = Agregar libro\n3 = Listar libros\n4 = Prestar libros\n5 = Devolver libros\n6 = Salir");
            
            option = Console.ReadLine();

            Console.WriteLine("Gracias!");
            break;

    }


} while(option != "6");







Console.ReadKey();
