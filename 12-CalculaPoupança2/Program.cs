using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Calcula Poupança 1");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês

        // for (parâmetro, condicional e contador)
        for (int mes = 1; mes <= 12; mes++)
        {
            // investimento * investimento x 1.005
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento + " reais.");
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}