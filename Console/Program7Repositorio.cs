//ALGORITMO_METADE_MAIOR_50
double numero, metade;
Console.WriteLine("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());
metade = numero / 2;
if (metade > 50)
{
    Console.WriteLine("A metade do número é maior que 50.");
}
else
{
    Console.WriteLine("A metade do número não é maior que 50.");
}

//ALGORITMO_DOBRO
double numero1, dobro;
Console.WriteLine("Informe um número para saber o seu dobro");
numero1 = Convert.ToDouble(Console.ReadLine());
if (numero1 > 90)  
if (numero1 < 100)
    {
        dobro = numero1 * 2;
        Console.WriteLine("O dobro do número é: " + dobro);
    }
    else
    {
        Console.WriteLine("O número não está entre 90 e 100.");
    }

//ALGORITMO_QUINTA_PARTE
double numero2, quintaParte;
Console.WriteLine("Informe um número para saber sua quinta parte ");
numero2 = Convert.ToDouble(Console.ReadLine());
quintaParte = numero2 / 5;
if (quintaParte < 50)
if (quintaParte > 1000)
    {
        Console.WriteLine("A quinta parte do número está entre 50 e 1000.");
    }
    else
    {
        Console.WriteLine("A quinta parte do número não está entre 50 e 1000.");
    }

//ALGORTIMO_SEXTUPLO
double numero3, sextuplo;
Console.WriteLine("Informe um número para saber o seu sêxtuplo");
numero3 = Convert.ToDouble(Console.ReadLine());
if (numero3 > 90)
{
    sextuplo = numero3 * 6;
    Console.WriteLine("O sêxtuplo do número é: " + sextuplo);
}

//ALGORITMO_NUMERO_PAR
double numero4;
Console.WriteLine("Informe um número para saber se ele é par");
numero4 = Convert.ToDouble(Console.ReadLine());
if (numero4 % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}

//ALGORITMO_MAIOR_NUMERO
double numero5, numero6;
Console.WriteLine("Digite o primeiro número");
numero5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
numero6 = Convert.ToDouble(Console.ReadLine());
if (numero5 > numero6)
{
    Console.WriteLine("O maior número é: " + numero5);
}
if (numero6 > numero5)
{
    Console.WriteLine("O maior número é: " + numero6);
}
