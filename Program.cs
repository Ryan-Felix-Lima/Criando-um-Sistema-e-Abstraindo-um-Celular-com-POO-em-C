using DesafioPOO.Models;

using System;

namespace DesafioPOO.Tests
{
    class Program
    {
        static void Main()
        {
            TestarNokia();
            TestarIphone();
        }

        static void TestarNokia()
        {
            Nokia telefoneNokia = new Nokia();

            // Realizar testes específicos para o Nokia
            Console.WriteLine("Testando Nokia...");
            // Adicione sua lógica de teste aqui

            Console.WriteLine("Testes do Nokia concluídos.");
            Console.WriteLine();
        }

        static void TestarIphone()
        {
            Iphone iphone = new Iphone();

            // Realizar testes específicos para o Iphone
            Console.WriteLine("Testando Iphone...");
            // Adicione sua lógica de teste aqui

            Console.WriteLine("Testes do Iphone concluídos.");
            Console.WriteLine();
        }
    }
}
