using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - calculo de poupança");


        double investimento = 1000;
        //rendimento de 0,5% ao mes (0,005)
        int mes = 1;
        

        //mes 1 
        //vestimento = investimento + investimento * 0.005;
       //onsole.WriteLine(investimento);

        //mes 2
        //vestimento = investimento + investimento * 0.005;
        //nsole.WriteLine(investimento);

        //mes 3
        //vestimento = investimento + investimento * 0.005;
       //onsole.WriteLine(investimento);

        while(mes <= 12)
        {
           investimento= investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes+= 3; //incremento com valor maior de 1 se usa += 
            //mes = mes + 1
        }
















        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}