// Tarea niTarea= new Tarea (1, "hola");


List<Tarea> Tareas = new List<Tarea>();

int cantidad = 10;
for (int i = 0; i < cantidad; i++)
{
    Tarea tarea = new Tarea(i, $"hola {i}");
    Tareas.Add(tarea);
}

foreach (var tarea in Tareas)
{
    Console.WriteLine(tarea.description);
}