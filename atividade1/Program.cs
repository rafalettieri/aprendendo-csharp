using System;

class Programa
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        Console.Write("digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        Console.WriteLine("a soma das notas é " + res);

        float media = res / 4;

        Console.WriteLine("A média de das notas é:" + media);


        if (media >= 6)
        {
            Console.WriteLine("Você foi aprovado");
        }
        if(media == 5)
        {
            Console.WriteLine("Você esta de recuperação");
        }
        if(media <= 4)
        {
            Console.WriteLine("Você esta reprovado");
        }







        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("Pressione enter para encerrar");
        Console.ReadLine();
    }
}
