using System.Text.Json;
using Capitulos.CapituloDois;

public class Program
{
    public static void Main(string[] args)
    {
        int[] lista = {31, 41, 59, 26, 41, 58};

        System.Console.WriteLine(ArrayFormatter(Exercicios.InsertionSort(lista)));
        System.Console.WriteLine(ArrayFormatter(Laboratorio.SelectionSort(lista)));
        System.Console.WriteLine(ArrayFormatter(Laboratorio.BubbleSort(lista)));

    }

    public static string ArrayFormatter(int[] obj)
    {
        return JsonSerializer.Serialize(obj);
    }
}