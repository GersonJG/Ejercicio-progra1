using System.Xml;

int eleccion, n1, n2;
void saludar()
{
    Console.WriteLine("Que hubo!!!");
}

int suma(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 + n2;
    return resultado;
}

int multi(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 * n2;
    return resultado;
}

int resta(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 - n2;
    return resultado;
}

int div(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 / n2;
    return resultado;
}
saludar();
Console.Write("Ingrese el primer numero: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Elija una opcion: \n 1.Suma \n 2.Resta \n 3.Multiplicacion \n 4.Division");
eleccion = int.Parse(Console.ReadLine());

switch (eleccion)
{
    case 1: Console.WriteLine($"La suma es: {suma(n1, n2)}");
        break;

    case 2: Console.WriteLine($"La resta es {resta(n1, n2)}");
        break;

    case 3: Console.WriteLine($"La Multipliacion es: {multi(n1, n2)}");
        break;

    case 4: Console.WriteLine($"La division es: {div(n1, n2)}");
        break;

    default: Console.WriteLine("Numero Invalido");
        break;
}
