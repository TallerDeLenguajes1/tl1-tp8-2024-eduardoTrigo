namespace EspacioTarea
{
    public enum EstadoTarea
    {
        Pendiente,
        Realizado,
        Cursando,
    }
    public class Tarea
    {
        int tareaID;
        string description;
        int duracion;
        EstadoTarea estado;

        public global::System.Int32 TareaID { get => tareaID; set => tareaID = value; }
        public global::System.String Description { get => description; set => description = value; }
        public global::System.Int32 Duracion { get => duracion; set => duracion = value; }
        public EstadoTarea Estado { get => estado; set => estado = value; }

        public Tarea(int tareaID, string description, int duracion, EstadoTarea estadoTarea)
        {
            this.tareaID = tareaID;
            this.description = description;
            this.duracion = duracion;
            this.estado = estado;
        }

        public int obtenerId(){
            return TareaID;
        }
    }

    public class GestorTareas
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasRealizadas = new List<Tarea>();

        public void crearAleatorio(int num){
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                Tarea tarea = new Tarea(i+1, "Tarea ID" + i, random.next(1,101));
                tareasPendientes.Add(tarea);
            }
        }

        public void moverListasRealizadas(int id){
            Tarea tareaAmover = null;
            for (int i = 0; i < tareasPendientes.count; i++)
            {
                if (tareasPendientes[i].TareaID == id)
                {
                    tareaAmover = tareasPendientes[i];
                    tareasPendientes.RemoveAt(i);
                    break;
                }
            }
            if (tareaAmover != null)
            {
                tareasRealizadas.Add(tareaAmover);
                Console.WriteLine("tarea movida con exito");
            }else
            {
                Console.WriteLine("tarea no encontrada");
            }
        }
    public void MostrarPendientes(){
        Console.WriteLine("tareas pendientes");
        foreach (Tarea tarea in tareasPendientes)
        {
            Console.WriteLine($"ID: {tarea.obtenerId()}, Descripcion: {tarea.Description}, Duracion: {}");
        }
    }
    }

}