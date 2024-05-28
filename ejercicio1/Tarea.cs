// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Tarea{
    private int id;
    private string description;

    public Tarea(int id, string description){
        this.id = id;
        this.description = description;
    }

    public string description { get => description; set => description = value; }
    public int id { get => id; set => id = value; }
}
