// See https://aka.ms/new-console-template for more information


// public class GestorTareas
// {
//     List<Tarea> tareasPendientes = new List<Tarea>();
//     List<Tarea> tareasRealizadas = new List<Tarea>();
// }


public class GestorTareas
{
    public static void GenerarTareas(List<Tarea> tareas, int cantidad)
    {
        Random random = new Random();
        for (int i = 0; i < cantidad; i++)
        {
            Tarea tarea = new Tarea();
            tarea.IdTarea = i + 10;
            tarea.Description = $"saludar {i}";
            tarea.Duracion = random.Next(4, 9);
            int estadoAleatorio = random.Next(0, 2);
            if (estadoAleatorio == 0)
            {
                tarea.Estado = EstadoTarea.Pendiente;
            }
            else
            {
                tarea.Estado = EstadoTarea.Realizada;
            }
            tareas.Add(tarea);
        }
    }

    public static void MostrarTarea(List<Tarea> tareas)
    {
        foreach (var tarea in tareas)
        {
            Console.WriteLine(tarea.MostrarTarea());
        }
    }
    public static void ListarPendientes(List<Tarea> tareas, List<Tarea> pendientes, List<Tarea> realizadas)
    {
        pendientes.Clear();
        realizadas.Clear();
        foreach (var tarea in tareas)
        {
            if (tarea.Estado == EstadoTarea.Pendiente)
            {
                pendientes.Add(tarea);
            }
            else
            {
                realizadas.Add(tarea);
            }
        }
    }

    public static void MoverTarea(List<Tarea> tareas, List<Tarea> pendientes, List<Tarea> realizadas){
        Console.WriteLine("--ingrese ID de la tarea pendiente a mover--");
            GestorTareas.ListarPendientes(tareas, pendientes, realizadas);
            GestorTareas.MostrarTarea(pendientes);
            int idPendiente = int.Parse(Console.ReadLine());
            foreach (var tarea in pendientes)
            {
                if (tarea.IdTarea == idPendiente)
                {
                    int confirmacion;
                    do
                    {
                    Console.WriteLine($"Desea cambiar la tarea {tarea.Description} a Realizada?  1:SI  2:NO");
                    confirmacion = int.Parse(Console.ReadLine());
                    } while (confirmacion != 1 && confirmacion != 2);
                    if (confirmacion == 1)
                    {
                        tarea.Estado = EstadoTarea.Realizada;
                        Console.WriteLine("opercaion exitosa");
                    }else{
                        Console.WriteLine("operacion descartada");
                        break;
                    }
                }
            }
    }

}