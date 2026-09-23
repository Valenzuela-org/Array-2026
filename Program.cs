static void imprimirNotas(int []notasx)
{
    for (int i=0;i<notasx.Length;i++)
    {
        Console.WriteLine($"Nota {i+1}; {notasx[i]}");
    }
}

//Funcion de promedio de notas
static double calcularPromedio(int[] notas)
{
    int suma = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        suma += notas[i];
    }
    return (double)suma / notas.Length;
}

int[] notas = {15,18,12,17,20};
imprimirNotas(notas);

//Promedio de todas las notas
double promedio = calcularPromedio(notas);
Console.WriteLine($"Promedio de todas las notas: {promedio:F2}");
//Funcion para maximos
static int hallarNotaMasAlta(int[] notas)
{
    int notaMasAlta = notas[0];
    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > notaMasAlta)
        {
            notaMasAlta = notas[i];
        }
    }
    return notaMasAlta;
}

//Funcion para minimos
static int hallarNotaMasBaja(int[] notas)
{
    int notaMasBaja = notas[0];
    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] < notaMasBaja)
        {
            notaMasBaja = notas[i];
        }
    }
    return notaMasBaja;
}
Console.WriteLine($"Nota más alta: {hallarNotaMasAlta(notas)}");
Console.WriteLine($"Nota más baja: {hallarNotaMasBaja(notas)}");