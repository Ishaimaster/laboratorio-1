// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: Operaciones aritméticas. ");



Console.Write("Ingrese un número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

 
Console.Write("Ingrese otro número mayor o igual que 0: ");
int n2 = Convert.ToInt32(Console.ReadLine());


int suma = n1 + (n2);
Console.WriteLine( n1 + "+" + n2 + "=" + suma);

int resta = n1 - (n2);
Console.WriteLine(n1 + "-" + n2 + "=" + resta);

int multiplicación = n1 * (n2);
Console.WriteLine(n1 + "*" + n2 + "=" + multiplicación);

int div = n1 / (n2);
Console.WriteLine(n1 + "/" + n2 + "=" + div);

int mod = n1 % (n2);
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
    Console.WriteLine(resta + " es igual a 10");
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

Console.ReadKey();


//Ejercicio 3 y 4

double num1 = 0;
double num2 = 0;
double num3 = 0;



double pot = num3 * num3;

Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");

Console.WriteLine("Ingrese el valor a");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor b");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor c");
num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("la primera operacion es: a*b+c = " + ((num1 * num2) + (num3)));

Console.WriteLine("la segunda operacion es: a*(b+c) = " + (num1 * (num2 + num3)));

Console.WriteLine("la tercera operacion es: a/(b*c) = " + (num1 / (num2 * num3)));


Console.WriteLine("la cuarta operacion es: 3a+2b/c^2) = " + ((3 * num1) + (2 * num2)) / (num3 * num3));


Console.WriteLine("Ejercicio 4: Formula general de la ecuación cuadrática");

double n5 = Math.Sqrt((num2 * num2) - (4 * num1 * num3));

if (n5 < 0)
{

    Console.WriteLine(" El determinante es invalido para una respuesta real");

}
else if (n5 == 0)
{
    Console.WriteLine("x1 = " + (((-num2) + n5) / (num1 * 2)));
}

else
{
    Console.WriteLine("x1 = " + (((-num2) + n5) / (num1 * 2)));

    Console.WriteLine("x2 = " + (((-num2) - n5) / (num1 * 2)));
}


Console.ReadKey();