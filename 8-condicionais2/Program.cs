using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 08 - Condicional 2");

        int idaderafael = 17;
        int quantidadepessoas = 2;

        bool acompanhado = quantidadepessoas > 1;

        bool grupo = true;



        if (idaderafael >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar");

        }
        else
        {
                Console.WriteLine("não pode entrar");
            }
        

        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}