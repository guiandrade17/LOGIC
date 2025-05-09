1)using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }
    }
}

2)using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Digite um número (0 para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                Console.WriteLine("Dobro: " + (numero * 2));
            }

        } while (numero != 0);
    }
}

3)using System;

class Program
{
    static void Main()
    {
        int numero, soma = 0;

        Console.Write("Digite um número (0 para sair): ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            soma += numero;

            Console.Write("Digite outro número (0 para sair): ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Soma total: " + soma);
    }
}

4)using System;

class Program
{
    static void Main()
    {
        int soma = 0, numero;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o " + i + "º número: ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.WriteLine("Soma total: " + soma);
    }
}

5)using System;

class Program
{
    static void Main()
    {
        int numero, soma = 0, qtdPares = 0;

        Console.Write("Digite um número (0 para sair): ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            if (numero % 2 == 0)
            {
                soma += numero;
                qtdPares++;
            }

            Console.Write("Digite outro número (0 para sair): ");
            numero = int.Parse(Console.ReadLine());
        }

        if (qtdPares > 0)
        {
            double media = (double)soma / qtdPares;
            Console.WriteLine("Média dos números pares: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}
