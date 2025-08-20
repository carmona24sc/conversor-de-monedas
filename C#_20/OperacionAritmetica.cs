public class OperacionAritmetica
{
    // Propiedades
    // Sintaxis (Mod acceso, tipoDato, nombre, propiedades, get, y set)

    public int Numero1 { get; set; }
    public int Numero2 { get; set; }

    // Funciones
    // Sintaxis (Mod acceso, tipoDato, nombre, parametro)


    public void ImprimirSuma()
    {
        int resultadoSuma = Numero1 + Numero2;
        Console.WriteLine("La suma es: " + resultadoSuma);
    }
  public int Sumar(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;
    }
   
}