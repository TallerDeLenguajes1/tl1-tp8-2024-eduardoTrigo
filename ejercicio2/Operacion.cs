public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Divicion,
    Limpiar,
}
public class Operacion
{
    private double nuevoValor;
    private double resultadoAnterior;
    private TipoOperacion operacionMat;
    private double resultado;

    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public TipoOperacion OperacionMat { get => operacionMat; set => operacionMat = value; }
    public double Resultado { get => resultado; set => resultado = value; }

    public Operacion(){}

    public  Operacion(double nuevoValor, double resultadoAnterior, TipoOperacion operacionMat, double resultado )
    {
        this.nuevoValor = nuevoValor;
        this.resultadoAnterior = resultadoAnterior;
        this.operacionMat = operacionMat;
        this.resultado = resultado;
    }

    public string MostrarOperacion(){
        return $"{ResultadoAnterior} || {OperacionMat} || {NuevoValor} || {Resultado}";
    }
}