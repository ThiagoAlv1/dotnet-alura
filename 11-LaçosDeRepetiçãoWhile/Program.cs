﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Calcula Poupança 1");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês

        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento + " reais.");

            //mes = mes +1; poderiamos também usar o mes++
            mes += mes +1;
        }
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}