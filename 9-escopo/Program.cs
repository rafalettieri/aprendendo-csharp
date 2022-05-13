using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo");

        int idaderafael = 17;
        int quantidadepessoas = 2;

        bool acompanhado = quantidadepessoas > 1;

        string textoadicional; 



        if (acompanhado == true)
        {
            textoadicional = ("Rafael está acompanhado");

        }
        else
        {
             textoadicional = ("Rafael não está acompanhado");
        }
        if(idaderafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoadicional);
            Console.WriteLine("Pode entrar");

            
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }



        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}