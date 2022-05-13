using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 02 - criando variáveis!");
        int idade;
        idade = 27;
        Console.WriteLine("minha idade é" + idade);

        idade = 27 - 5;
        Console.WriteLine("minha idade é " + idade);

        idade = 5 * 2 - 6;
        Console.WriteLine("MInha idade é " + idade);

        idade = (5 - 2) * 3;
        Console.WriteLine("Minha idade é " + idade);

        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}