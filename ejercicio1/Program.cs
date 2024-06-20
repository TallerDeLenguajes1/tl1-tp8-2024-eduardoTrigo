Console.WriteLine("ingrese un numero de tareas a generar");
int cantTareas = int.Parse(Console.ReadLine());


List<Tarea> TareasTotales = new List<Tarea>();
List<Tarea> pendientes = new List<Tarea>();
List<Tarea> realizadas = new List<Tarea>();


GestorTareas.GenerarTareas(TareasTotales, cantTareas);
int opcion;
do
{
    Console.WriteLine("---ingrese una opcion---");
    Console.WriteLine("-opcion 1: Mostrar todas las tareas");
    Console.WriteLine("-opcion 2: Mostrar tareas pendientes");
    Console.WriteLine("-opcion 3: Mostrar tareas realizadas");
    Console.WriteLine("-opcion 4: Cambiar estado de Tarea");
    Console.WriteLine("-opcion 5: Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            GestorTareas.MostrarTarea(TareasTotales);
            break;
        case 2:
            GestorTareas.ListarPendientes(TareasTotales, pendientes, realizadas);
            GestorTareas.MostrarTarea(pendientes);
            break;

        case 3:
            GestorTareas.ListarPendientes(TareasTotales, pendientes, realizadas);
            GestorTareas.MostrarTarea(realizadas);
            break;

        case 4:
            GestorTareas.MoverTarea(TareasTotales, pendientes, realizadas);
            break;

        default:
            Console.WriteLine("Opcion incorrecta, ingrese nuevamente una opcion");
            break;
    }

} while (opcion != 5);

Console.WriteLine("------FIN------");