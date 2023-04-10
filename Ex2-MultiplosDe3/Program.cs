using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ex 2 - Multiplos de 3");

     

        for (int multiplos = 0; multiplos < 100; multiplos++)
        {
            if ((multiplos % 3) == 0)
            {
                Console.WriteLine(multiplos);
            }
        }
       

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}