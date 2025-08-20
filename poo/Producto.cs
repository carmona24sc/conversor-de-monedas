public class Producto
{
    public string Nombre { get; private set; }
    public int Cantidad { get; private set; }

    public Producto(string nombre, int cantidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
    }

    public void Agregar(int cantidad)
    {
        Cantidad += cantidad;
    }

    public bool Retirar(int cantidad)
    {
        if (cantidad <= Cantidad)
        {
            Cantidad -= cantidad;
            return true;
        }
        return false;
    }
}
