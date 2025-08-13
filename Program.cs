// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// // PEDIMOS DATOS PERSONALES
// Console.Write("¿Cómo te llamas? ");
// string nombre = Console.ReadLine() ?? ""; // Aquí guardamos el nombre que escribe el usuario, usando cadena vacía si es null

// // Mostramos un saludo
// Console.WriteLine($"¡Mucho gusto, {nombre}! 😊\n"); 

// // Continuamos pidiendo los demás datos
// Console.Write("¿Cuántos años tienes? ");
// int edad = Convert.ToInt32(Console.ReadLine()); // Guardamos la edad como número entero

// Console.Write("¿Cuánto pesas? (en kilogramos) ");
// double peso = Convert.ToDouble(Console.ReadLine()); // Guardamos el peso como número con decimales

// Console.Write("¿Cuánto mides? (en metros, por ejemplo 1.70) ");
// double altura = Convert.ToDouble(Console.ReadLine()); // Guardamos la altura en metros

// // CALCULAMOS EL IMC
// double imc = peso / (altura * altura); // Esta es la fórmula del IMC

// // MOSTRAMOS RESULTADO DEL IMC
// Console.WriteLine($"\nHola {nombre}, tu IMC es: {Math.Round(imc, 2)}");

// if (imc < 18.5)
//     Console.WriteLine("Tienes bajo peso.");
// else if (imc < 24.9)
//     Console.WriteLine("Tienes un peso normal.");
// else if (imc < 29.9)
//     Console.WriteLine("Tienes sobrepeso.");
// else
//     Console.WriteLine("Tienes obesidad.");

// // CONVERSIÓN DE MONEDA
// Console.Write("\n¿Cuántos pesos colombianos tienes? ");
// double pesosColombianos = Convert.ToDouble(Console.ReadLine()); // Pedimos cantidad de dinero

// // Tasas de cambio (son valores inventados, pero funcionan para practicar)
// double tasaUSD = 4000.0; // 1 dólar = 4000 pesos
// double tasaEUR = 4400.0; // 1 euro = 4400 pesos
// double tasaPEN = 1100.0; // 1 sol peruano = 1100 pesos

// // Calculamos cuánto dinero sería en otras monedas
// double enDolares = pesosColombianos / tasaUSD;
// double enEuros = pesosColombianos / tasaEUR;
// double enSoles = pesosColombianos / tasaPEN;

// // Mostramos los resultados
// Console.WriteLine($"\n{nombre}, con {pesosColombianos} pesos colombianos puedes tener:");
// Console.WriteLine($"{Math.Round(enDolares, 2)} dólares");
// Console.WriteLine($"{Math.Round(enEuros, 2)} euros");
// Console.WriteLine($"{Math.Round(enSoles, 2)} soles peruanos");



// bool salir = false;
// while (!salir)
// {
//     Console.WriteLine("\n--- MENÚ DE OPCIONES ---"); // \n para nueva línea antes del menú 
//     Console.WriteLine("1. Mostrar la fecha actual");
//     Console.WriteLine("2. Decir el nombre");
//     Console.WriteLine("3. Un saludo motivacional");
//     Console.WriteLine("4. Salir");
//     Console.Write("Elige una opción: ");
//     string opcion = Console.ReadLine() ?? string.Empty;

//     switch (opcion)
//     {
//         case "1":
//             Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
//             break;
//         case "2":
//             Console.WriteLine("Mi nombre es Santiago Carmona.");
//             break;
//         case "3":
//             Console.WriteLine("¡Sigue adelante, cada día es una nueva oportunidad para lograr tus metas!");
//             break;
//         case "4":
//             Console.WriteLine("¡Adiós Santiago Carmona!");
//             salir = true;
//             break;
//         default:
//             Console.WriteLine("Opción no válida ya la has seleccionado.");
//             break;
//     }
// }

// Console.WriteLine("Bienvenido al Cajero Automático!");

// decimal saldo = 500000m;
// bool salir = false;

// while (!salir)
// {
//     Console.WriteLine("\n--- MENÚ DE CAJERO AUTOMÁTICO ---");
//     Console.WriteLine("1. Consultar saldo");
//     Console.WriteLine("2. Retirar dinero");
//     Console.WriteLine("3. Salir");
//     Console.Write("Elige una opción: ");
//     string opcion = Console.ReadLine() ?? string.Empty;

//     switch (opcion)
//     {
//         case "1":
//             Console.WriteLine($"Su saldo actual es: {saldo:C}");
//             break;
//         case "2":
//             Console.Write("Ingrese el monto a retirar: ");
//             string montoStr = Console.ReadLine() ?? "0";
//             if (decimal.TryParse(montoStr, out decimal monto) && monto > 0)
//             {
//                 if (monto <= saldo)
//                 {
//                     saldo -= monto;
//                     Console.WriteLine($"Retiro exitoso. Su saldo actualizado es: {saldo:C}");
//                     Console.WriteLine("¡Gracias por usar el cajero automático!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Saldo insuficiente para realizar el retiro.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Monto inválido.");

// static void Main()
// {
//     Console.WriteLine("Clasificador de Valgo de Rodilla (ángulo en grados)");
//     Console.WriteLine("1: 0–5°");
//     Console.WriteLine("2: >5–10°");
//     Console.WriteLine("3: >10–15°");
//     Console.WriteLine("4: >15–20°");
//     Console.WriteLine("5: >20°\n");

//     while (true)
//     {
//         Console.Write("Ingresa el ángulo de valgo (°) o escribe 'salir': ");
//         var entrada = Console.ReadLine();

//         if (entrada?.ToLower() == "salir") break;

//         if (!double.TryParse(entrada, out double angulo) || angulo < 0 || angulo > 90)
//         {
//             Console.WriteLine("⚠ Valor inválido. Ingresa un número entre 0 y 90.\n");
//             continue;
//         }

//         int rango = angulo <= 5 ? 1 :
//                     angulo <= 10 ? 2 :
//                     angulo <= 15 ? 3 :
//                     angulo <= 20 ? 4 : 5;

//         string descripcion = rango == 1 ? "mínimo/funcionalmente neutro" :
//                               rango == 2 ? "leve" :
//                               rango == 3 ? "moderado" :
//                               rango == 4 ? "marcado" : "severo";

//         Console.WriteLine($"Ángulo: {angulo}° → Rango: {rango} ({descripcion})\n");
//     }
// }

ejemplo 1
// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//     {"Manzana", 100},
//     {"Pera", 200},
//     {"Uva", 300},
// };

// bool salir = false;

// while (!salir)
// {
//     Console.WriteLine("\n--- Control de Stock ---");
//     Console.WriteLine("1. Ver inventario");
//     Console.WriteLine("2. Agregar producto");
//     Console.WriteLine("3. Retirar producto");
//     Console.WriteLine("4. Salir");
//     Console.Write("Seleccione una opción: ");

//     string opcion = Console.ReadLine();

//     switch (opcion)
//     {
//         case "1":
//             Console.WriteLine("\nInventario actual:");
//             foreach (var producto in lista_productos)
//             {
//                 Console.WriteLine($"Producto: {producto.Key}, Cantidad: {producto.Value}");
//             }
//             break;

//         case "2":
//             Console.Write("Nombre del producto a agregar: ");
//             string prodAgregar = Console.ReadLine();
//             Console.Write("Cantidad a agregar: ");
//             int cantidadAgregar = int.Parse(Console.ReadLine());

//             if (lista_productos.ContainsKey(prodAgregar))
//                 lista_productos[prodAgregar] += cantidadAgregar;
//             else
//                 lista_productos.Add(prodAgregar, cantidadAgregar);

//             Console.WriteLine("Producto agregado correctamente.");
//             break;

//         case "3":
//             Console.Write("Nombre del producto a retirar: ");
//             string prodRetirar = Console.ReadLine();
//             if (lista_productos.ContainsKey(prodRetirar))
//             {
//                 Console.Write("Cantidad a retirar: ");
//                 int cantidadRetirar = int.Parse(Console.ReadLine());
//                 if (lista_productos[prodRetirar] >= cantidadRetirar)
//                 {
//                     lista_productos[prodRetirar] -= cantidadRetirar;
//                     Console.WriteLine("Producto retirado correctamente.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("No hay suficiente stock para retirar esa cantidad.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("El producto no existe en el inventario.");
//             }
//             break;

//         case "4":
//             salir = true;
//             break;

//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }
// Console.WriteLine("¡Hasta luego!");

// ejemplo 2
// Dictionary<int, int> calificaciones_sastisfaccion = new Dictionary<int, int>()
// {
//     {1, 0},
//     {2, 0},
//     {3, 0},
//     {4, 0},
//     {5, 0},
// };

// bool salir_encuesta = false;

// while (!salir_encuesta)
// {
//     Console.WriteLine("\n--- Encuesta de Satisfacción ---");
//     Console.WriteLine("1. Califique nuestro servicio del (1 al 5)");
//     Console.WriteLine("2. Ver resultados de la encuesta");
//     Console.WriteLine("3. Salir");
//     Console.Write("Seleccione una opción: ");
//     string opcion_encuesta = Console.ReadLine()!;

//     switch (opcion_encuesta)
//     {
//         case "1":
//         Console.Write("califique nuestro servicio del (1 al 5 ): ");
//         if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 1 && calificacion <= 5)
//         {
//             calificaciones_sastisfaccion[calificacion]++;
//             Console.WriteLine("Gracias por su calificación.");
//         }
//         else
//         {
//             Console.WriteLine("Calificación no válida. Intente nuevamente.");
//         }
//         break;

//         case "2":
//         Console.WriteLine("Resultados de la encuesta:");
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine($"Calificación {i}: {calificaciones_sastisfaccion[i]} votos");
//         }
//         break;

//         case "3":
//         salir_encuesta = true;
//         break;
//         default:
//         Console.WriteLine("Opción no válida.");
//             break;
//     }
// }



