// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ciclos:
// ciclosn for: Para cuando se sabe cuántas veces se va a repetir el ciclo.
// for (int i = 0; i <= 2; i += 2)
// {
//     Console.WriteLine("Edad");
//     sbyte edad = sbyte.Parse(Console.ReadLine());
//     Console.WriteLine("Edad es: " + edad);
// }
// ciclos while: Para cuando no se sabe cuántas veces se va a repetir el ciclo.
// Console.WriteLine("Edad");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// sbyte edad_parametro_centinela = 99; // parametro centinela

// while (edad != edad_parametro_centinela)
// {
//     // cuando va hacer se va hacer lo que hay en bloque de codeigo 
//     Console.WriteLine("Puede ingresar");
//     edad = sbyte.Parse(Console.ReadLine());

//     Console.WriteLine("Edad es: ");
//     edad = sbyte.Parse(Console.ReadLine());
// }

// ciclos do while: Para cuando no se sabe cuántas veces se va a repetir el ciclo, pero al menos se debe ejecutar una vez.
// sbyte edad_parametro_centinela = 99;
// Console.WriteLine("Edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// do
// {
//     Console.WriteLine("Edad es: ");
//     edad = sbyte.Parse(Console.ReadLine());
// } while (edad != edad_parametro_centinela);


// variable



// array 
// array - lista (string - numeros ) - diccionarios
// string[] nombres = { "Ana", "Maria", "Jose", "Adres" };
// foreach (var nombre in nombres)
// {
//     Console.WriteLine(nombres);
// }

// lista
// List<string> nombres = new List<string>() { "Ana", "Maria", "Jose", "Andres" };

// llenar lista
// nombres.Capacity;
// nombres.Add()
// nombres.Add("Ana");
// nombres.Add("Maria");
// nombres.Add("Jose"); 
// nombres.Add("Andres");

// foreach (string nombre in nombres)
// {
//     Console.WriteLine(nombre);
// }

// lista numerica
// List<int> anios = new List<int>();

// anios.Add(2001);
// anios.Add(2010);
// anios.Add(2020);
// anios.Add(2024);

// foreach (int anio in anios)
// {
//     Console.WriteLine($" {anio}");
// }

// diccionario (sintaxis)
// diccionario<tipo de datos key, value> nombre_dicionario = new Dictionary<string, int>(tipo de datos key , value);
// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//    {"key" , "value"},
//    {"key" , "value"},
//    {"key" , "value"},
// };


// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//    {"Manzana" , 100},
//    {"Pera" , 200},
//    {"Uva" , 300},
// };

// foreach (var producto in lista_productos)
// {
//    Console.WriteLine($"Producto: {producto.Key}, Precio: {producto.Value}");
// }

