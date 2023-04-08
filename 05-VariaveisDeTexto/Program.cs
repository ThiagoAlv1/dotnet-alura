using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

        //Caracteres
        char letra = 'A';
        Console.WriteLine(letra);

        //Textos
        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase);

        //Criando uma lista
        string cursos = @"Cursos diponíveis:
- Go -
- C# 
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
   
    }
}