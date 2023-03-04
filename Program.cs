// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: Operaciones aritméticas. ");



Console.Write("Ingrese un número: ");
int n1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Ingrese otro número: ");
int n2 = Convert.ToInt32(Console.ReadLine());


int suma = n1 + n2;
Console.WriteLine( n1 + "+" + n2 + "=" + suma);

int resta = n1 - n2;
Console.WriteLine(n1 + "-" + n2 + "=" + resta);

int multiplicación = n1 * n2;
Console.WriteLine(n1 + "*" + n2 + "=" + multiplicación);

int div = n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + div);

int mod = n1 % n2;
Console.WriteLine(n1 + "%" + n2 + "=" + mod);

//double n1d = n1;
//conversión

//double n2d = n2;

//double division = (double)n1 / n2; es una conversión explicíta

double division = (double)n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + division);

// Ejercicio 2

Console.WriteLine("Ejercicio 2 operaciones booleanas");

if (suma > 10)
{
    Console.WriteLine(suma + " es mayor que 10");
}
else if (suma < 10)
{
    Console.WriteLine(suma + " es menor que 10");
}
else if (suma == 10)
{
    Console.WriteLine(suma + " es igual a 10");
}

if (resta > 10)
{
    Console.WriteLine(resta + " es mayor que 10");
}
else if (resta < 10)
{
    Console.WriteLine(resta + " es menor que 10");
}
else if (resta == 10)
{
    Console.WriteLine(resta + " es igual a cero");
}

if(multiplicación > 10)
{
    Console.WriteLine(multiplicación + " es mayor que 10");
}
else if (multiplicación < 10)
{
    Console.WriteLine(multiplicación + " es menor que 10");
}
else if (multiplicación == 10)
{
    Console.WriteLine(multiplicación + " es igual a 10");
}

if(div > 10)
{
    Console.WriteLine(div + " es mayor que 10");
}
else if (div < 10)
{
    Console.WriteLine(div + " es menor que 10");
}
else if (div == 10)
{
    Console.WriteLine(div + " es igual a 10");
}

if (mod > 10)
{
    Console.WriteLine(mod + " es mayor que 10");
}
else if (mod < 10)
{
    Console.WriteLine(mod + " es menor que 10");
}
else if (mod == 10)
{
    Console.WriteLine(mod + " es igual a 10");
}

if (division > 10)
{
    Console.WriteLine(division + " es mayor que 10");
}
else if (division < 10)
{
    Console.WriteLine(division + " es menor que 10");
}
else if (division == 10)
{
    Console.WriteLine(division + " es igual a 10");
}

