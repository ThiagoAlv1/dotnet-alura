using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - AtribuiçõesDeVariaveis");

        int idade = 30;
        int idadeAna = 30;

        Console.WriteLine(idadeAna);

        idade = 25;

        //A idade continuará 30. Isso acontece porque o computador lê o código de forma linear.
        //Quando a variável idadeAna foi impressa no console, seu valor era 30.
        //Posteriormente seu valor mudou para 25, mas o computador não volta para exibir o novo número.
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}