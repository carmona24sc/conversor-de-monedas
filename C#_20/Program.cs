// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Programacion estructurada
// Sumar dos numeros 
Console.WriteLine("Ingrese el primer numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

// int suma = num1 + num2;
// Console.WriteLine("La suma es: " + suma);

// Programacion Orientada a Objetos


// Instanciar la clase (Crear un objecto de una clase)
// Sintaxis (claseAintanciar, objeto, new, contructorClase)
OperacionAritmetica op = new OperacionAritmetica();
op.Numero1 = num1;
op.Numero2 = num2;
op.ImprimirSuma();

OperacionAritmetica op1 = new OperacionAritmetica();
op1.Numero1 = 5;
op1.Numero2 = 10;
op1.ImprimirSuma();

OperacionAritmetica op2 = new OperacionAritmetica();
op2.Numero1 = 20;
op2.Numero2 = 30;
op2.ImprimirSuma();

