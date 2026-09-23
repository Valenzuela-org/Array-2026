static void imprimirNotas(int []notasx)
{
    for (int i=0;i<notasx.Length;i++)
    {
        Console.WriteLine($"Nota {i+1}; {notasx[i]}");
    }
}
int[] notas = {15,18,12,17,20};
imprimirNotas(notas);
//Suma de todas las notas
int suma = 0; 
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}
Console.WriteLine($"Suma de todas las notas: {suma}");

//Promedio de todas las notas
double promedio = (double)suma / notas.Length;
Console.WriteLine($"Promedio de todas las notas: {promedio:F2}");