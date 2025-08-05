// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// PEDIMOS DATOS PERSONALES
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine() ?? ""; // Aquí guardamos el nombre que escribe el usuario, usando cadena vacía si es null

// Mostramos un saludo
Console.WriteLine($"¡Mucho gusto, {nombre}! 😊\n"); 

// Continuamos pidiendo los demás datos
Console.Write("¿Cuántos años tienes? ");
int edad = Convert.ToInt32(Console.ReadLine()); // Guardamos la edad como número entero

Console.Write("¿Cuánto pesas? (en kilogramos) ");
double peso = Convert.ToDouble(Console.ReadLine()); // Guardamos el peso como número con decimales

Console.Write("¿Cuánto mides? (en metros, por ejemplo 1.70) ");
double altura = Convert.ToDouble(Console.ReadLine()); // Guardamos la altura en metros

// CALCULAMOS EL IMC
double imc = peso / (altura * altura); // Esta es la fórmula del IMC

// MOSTRAMOS RESULTADO DEL IMC
Console.WriteLine($"\nHola {nombre}, tu IMC es: {Math.Round(imc, 2)}");

if (imc < 18.5)
    Console.WriteLine("Tienes bajo peso.");
else if (imc < 24.9)
    Console.WriteLine("Tienes un peso normal.");
else if (imc < 29.9)
    Console.WriteLine("Tienes sobrepeso.");
else
    Console.WriteLine("Tienes obesidad.");

// CONVERSIÓN DE MONEDA
Console.Write("\n¿Cuántos pesos colombianos tienes? ");
double pesosColombianos = Convert.ToDouble(Console.ReadLine()); // Pedimos cantidad de dinero

// Tasas de cambio (son valores inventados, pero funcionan para practicar)
double tasaUSD = 4000.0; // 1 dólar = 4000 pesos
double tasaEUR = 4400.0; // 1 euro = 4400 pesos
double tasaPEN = 1100.0; // 1 sol peruano = 1100 pesos

// Calculamos cuánto dinero sería en otras monedas
double enDolares = pesosColombianos / tasaUSD;
double enEuros = pesosColombianos / tasaEUR;
double enSoles = pesosColombianos / tasaPEN;

// Mostramos los resultados
Console.WriteLine($"\n{nombre}, con {pesosColombianos} pesos colombianos puedes tener:");
Console.WriteLine($"{Math.Round(enDolares, 2)} dólares");
Console.WriteLine($"{Math.Round(enEuros, 2)} euros");
Console.WriteLine($"{Math.Round(enSoles, 2)} soles peruanos");

