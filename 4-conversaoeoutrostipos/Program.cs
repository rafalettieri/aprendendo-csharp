using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 04 - conversões e Outros tipos");

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario); 


        int salariointeiro;
        salariointeiro = (int)salario;

        //o long é um tipo de variavel de 64 bits
        long x;
        x = 2000000000;
        Console.WriteLine(x); 

        short y;
        y = 150;
        Console.WriteLine(y); 

        float altura;
        altura = 1.72f;
        Console.WriteLine();

        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();

    }
}

