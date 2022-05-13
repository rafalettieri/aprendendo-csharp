using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - encadeando for");
 
        //com break
        for(int contadordelinha = 0; contadordelinha < 10; contadordelinha++)
        {
            for (int contadorcoluna = 0; contadorcoluna < 10; contadorcoluna++)
            {
                Console.Write("*");
                if(contadorcoluna >= contadordelinha)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        //sem break

        for (int contadordelinha = 0; contadordelinha < 10; contadordelinha++)
        {
            for (int contadorcoluna = 0; contadorcoluna <= contadordelinha; contadorcoluna++)
            {
                Console.Write("*");
             
            }
            Console.WriteLine();
        }














        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}

