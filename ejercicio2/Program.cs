// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int operacion;
Calculadora calculadora = new Calculadora();
List<Operacion> misOperaciones = new List<Operacion>();
do
{
    do
    {
        Console.WriteLine("ingrese una operacion");
        Console.WriteLine("-- 1)Sumar:");
        Console.WriteLine("-- 2)Restar:");
        Console.WriteLine("-- 3)Multiplicar:");
        Console.WriteLine("-- 4)Dividir:");
        Console.WriteLine("-- 5)Limpiar");
        Console.WriteLine("-- 6)Historial");
        Console.WriteLine("-- 7)Salir:");
        operacion = int.Parse(Console.ReadLine());
    } while (operacion > 6 || operacion < 1);


    double termino;
    double resultadoAnterior;
    double resultaActual;
    switch (operacion)
    {
        case 1:
            Console.WriteLine("ingrese el valor");
            termino = double.Parse(Console.ReadLine());
            resultadoAnterior = calculadora.Resultado;
            calculadora.Sumar(termino);
            resultaActual = calculadora.Resultado;
            GestorOperaciones.GenerarOperacion(misOperaciones, termino, resultadoAnterior, operacion, resultaActual);
            Console.WriteLine(calculadora.Resultado);
            break;

        case 2:
            Console.WriteLine("ingrese el valor");
            termino = double.Parse(Console.ReadLine());
            resultadoAnterior = calculadora.Resultado;
            calculadora.Restar(termino);
            resultaActual = calculadora.Resultado;
            GestorOperaciones.GenerarOperacion(misOperaciones, termino, resultadoAnterior, operacion, resultaActual);
            Console.WriteLine(calculadora.Resultado);
            break;

        case 3:
            Console.WriteLine("ingrese el valor");
            termino = double.Parse(Console.ReadLine());
            resultadoAnterior = calculadora.Resultado;
            calculadora.Multiplicar(termino);
            resultaActual = calculadora.Resultado;
            GestorOperaciones.GenerarOperacion(misOperaciones, termino, resultadoAnterior, operacion, resultaActual);
            Console.WriteLine(calculadora.Resultado);
            break;

        case 4:
            Console.WriteLine("ingrese el valor");
            termino = double.Parse(Console.ReadLine());
            resultadoAnterior = calculadora.Resultado;
            calculadora.Dividir(termino);
            resultaActual = calculadora.Resultado;
            GestorOperaciones.GenerarOperacion(misOperaciones, termino, resultadoAnterior, operacion, resultaActual);
            Console.WriteLine(calculadora.Resultado);
            break;

        case 5:
            Console.WriteLine("ingrese el valor");
            termino = double.Parse(Console.ReadLine());
            resultadoAnterior = calculadora.Resultado;
            calculadora.Limpiar();
            resultaActual = calculadora.Resultado;
            GestorOperaciones.GenerarOperacion(misOperaciones, termino, resultadoAnterior, operacion, resultaActual);
            Console.WriteLine(calculadora.Resultado);
            break;
        case 6:
            GestorOperaciones.MostrarHistorial(misOperaciones);
            break;
        default:
            break;
    }
} while (operacion != 7);
