using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 04 - conversões e Outros tipos");

        char letra = 'a'; 
        Console.WriteLine(letra);

        letra = (char)82;
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);


        letra = (char)70;
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)69;
        Console.WriteLine(letra);

        letra = (char)76;
        Console.WriteLine(letra);



        letra = (char)82;
        Console.Write(letra);
        letra = (char)65;
        Console.Write(letra);
        letra = (char)70;
        Console.Write(letra);
        letra = (char)65;
        Console.Write(letra);
        letra = (char)69;
        Console.Write(letra);
        letra = (char)76;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string PrimeiraFrase = "Senai - Cursos de tecnologia ";
        Console.WriteLine(PrimeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponiveis: 
 -c
 -c++;
 -html
 -csharp";

        Console.WriteLine(cursos);
        

        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();

    }
}
