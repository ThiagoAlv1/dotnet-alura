using System;
class Programa
{
    static void Main(string[] args)
    {
        //O double é um tipo de variável para números inteiros e reais
        double salario = 3000.15;
            Console.WriteLine(salario); 

        //O short é um tipo de variável de 32 bits
        short x = 1500;
            Console.WriteLine(x);
        
        //O int é um tipo de variável para números inteiros
        //Aqui, convertemos a variavei salario para um número inteiro através do casting
        int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);
       
        //O long é um tipo de variável de 64 bits
        long y = 200000000000000;
            Console.WriteLine(y);

        float altura = 1.62f;
            Console.WriteLine(altura);
        


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}