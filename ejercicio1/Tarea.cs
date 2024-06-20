// See https://aka.ms/new-console-template for more information

public enum EstadoTarea
{
    Realizada,
    Pendiente,
}

public class Tarea
{
    int idTarea;
    string? description;
    int duracion;
    EstadoTarea estado;

    public Tarea()
    {

    }

    public Tarea(int idTarea, string description, int duracion, EstadoTarea estado){
        this.idTarea = idTarea;
        this.description = description;
        this.duracion = duracion;
        this.estado = estado;
    }

    public string MostrarTarea()
    {
        return $"{idTarea} | {description} | {duracion} dias | {estado}";
    }


    public int IdTarea { get => idTarea; set => idTarea = value; }
    public string? Description { get => description; set => description = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public EstadoTarea Estado { get => estado; set => estado = value; }

}

