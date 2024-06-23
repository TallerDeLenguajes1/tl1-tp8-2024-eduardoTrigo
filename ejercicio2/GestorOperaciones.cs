// See https://aka.ms/new-console-template for more information

public class GestorOperaciones
{
    public static void GenerarOperacion(List<Operacion> operaciones, double nuevoValor, double resultadoAnterior, int operador, double resultado){
            Operacion operacion = new Operacion();
            operacion.ResultadoAnterior = resultadoAnterior;
            switch(operador){
                case 1: operacion.OperacionMat = TipoOperacion.Suma;
                break;
                case 2: operacion.OperacionMat = TipoOperacion.Resta;
                break;
                case 3: operacion.OperacionMat = TipoOperacion.Multiplicacion;
                break;
                case 4: operacion.OperacionMat = TipoOperacion.Divicion;
                break;
                case 5: operacion.OperacionMat = TipoOperacion.Limpiar;
                break;
                default:
                break;
            }
            operacion.NuevoValor = nuevoValor;
            operacion.Resultado = resultado;
            operaciones.Add(operacion);
    }

    public static void MostrarHistorial(List<Operacion> operaciones){
        foreach (var operacion in operaciones)
        {
            Console.WriteLine(operacion.MostrarOperacion());
        }
    }
}