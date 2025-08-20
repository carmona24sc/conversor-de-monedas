// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, int> lista_productos = new Dictionary<string, int>()
{
    {"Manzana", 100},
    {"Pera", 200},
    {"Uva", 300},
};

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- Control de Stock ---");
    Console.WriteLine("1. Ver inventario");
    Console.WriteLine("2. Agregar producto");
    Console.WriteLine("3. Retirar producto");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("\nInventario actual:");
            foreach (var producto in lista_productos)
            {
                Console.WriteLine($"Producto: {producto.Key}, Cantidad: {producto.Value}");
            }
            break;

        case "2":
            Console.Write("Nombre del producto a agregar: ");
            string prodAgregar = Console.ReadLine();
            Console.Write("Cantidad a agregar: ");
            int cantidadAgregar = int.Parse(Console.ReadLine());

            if (lista_productos.ContainsKey(prodAgregar))
                lista_productos[prodAgregar] += cantidadAgregar;
            else
                lista_productos.Add(prodAgregar, cantidadAgregar);

            Console.WriteLine("Producto agregado correctamente.");
            break;

        case "3":
            Console.Write("Nombre del producto a retirar: ");
            string prodRetirar = Console.ReadLine();
            if (lista_productos.ContainsKey(prodRetirar))
            {
                Console.Write("Cantidad a retirar: ");
                int cantidadRetirar = int.Parse(Console.ReadLine());
                if (lista_productos[prodRetirar] >= cantidadRetirar)
                {
                    lista_productos[prodRetirar] -= cantidadRetirar;
                    Console.WriteLine("Producto retirado correctamente.");
                }
                else
                {
                    Console.WriteLine("No hay suficiente stock para retirar esa cantidad.");
                }
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
            break;

        case "4":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
Console.WriteLine("¡Hasta luego!");




