using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 14 - Encadeando For");

        for (int contadorLinhas = 0; contadorLinhas < 20; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 20; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    /* O break para a execução do laço mais interno que contém o comando break
                     e continua executando os laços mais externos*/
                    break;
            }
            
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}