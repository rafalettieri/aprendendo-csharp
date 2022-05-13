using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 07 - Condicional");

        int idaderafael = 17;
        int quantidadepessoas = 2;


        if (idaderafael >= 18)
        {
            Console.WriteLine("Pode entrar");

        }
        else
        {
            if (quantidadepessoas > 1)
            {
                Console.WriteLine("Ela está acompanhado. Pode entrar...");
            }
            else
            {
                Console.WriteLine("não pode entrar");
            }
        }


















        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}