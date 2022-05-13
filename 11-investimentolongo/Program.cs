using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - investimento a longo prazo");

        double fatorrendimento = 1.005;
        double investimento = 1000;
      

        for(int anos = 1; anos<=5; anos++)
        {
            for(int mes = 1; mes<=12; mes++)
            {
                investimento *= fatorrendimento;
                Console.WriteLine("No mes " + mes + " Você tera " + investimento.ToString("c") + " De investimento");
            }

            fatorrendimento +=   0.001;
            Console.WriteLine();
        }
        
        Console.WriteLine("Depois de 5 anos voce tera " + investimento.ToString("c"));
       














        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}
