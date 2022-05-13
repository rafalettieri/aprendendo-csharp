using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - calculo de poupança");


        double investimento = 1000;
        //rendimento de 0,5% ao mes (0,005)
        


        for (int mes = 1; mes <= 12; mes +=1)
        {
            investimento = investimento + investimento * 0.005; //investimento *= 1.005
            Console.WriteLine("No mês " + mes +  " Você vai ter " + investimento.ToString("C"));
        }
















        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}
