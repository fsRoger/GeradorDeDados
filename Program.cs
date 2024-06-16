using GeradorDeDados.Services;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        GeradorListaService.GerarLista().Wait();
        Console.WriteLine("pressione qualquer tecla para sair...");
        Console.ReadLine();
    }
}