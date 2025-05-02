//ALGORITMO_MAIOR_NUMERO
using System.ComponentModel.Design;

double numero1, numero2, numero3;
Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToDouble(Console.ReadLine());
if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("O maior número é: " + numero1);
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("O maior número é: " + numero2);
}
else
{
    Console.WriteLine("O maior número é: " + numero3);
}
//FIM_ALGORITMO_MAIOR_NUMERO

//ALGORITMO_CLASSIFICACAO_NADADOR
double idade;
Console.WriteLine("Digite a idade do nadador: ");
idade = Convert.ToDouble(Console.ReadLine());
if (idade >= 5 && idade <= 7)
{
    Console.WriteLine("Categoria: Infantil A");
}
else if (idade >= 8 && idade <= 10)
{
    Console.WriteLine("Categoria: Infantil B");
}
else if (idade >= 11 && idade <= 13)
{
    Console.WriteLine("Categoria: Juvenil A");
}
else if (idade >= 14 && idade <= 17)
{
    Console.WriteLine("Categoria: Juvenil B");
}
else if (idade >= 18)
{
    Console.WriteLine("Categoria: Adulto");
}
else
{
    Console.WriteLine("Idade inválida");
}
//FIM_ALGORITMO_CLASSIFICACAO_NADADOR

//ALGORITMO_TIPO_TRIANGULO
double ladoA, ladoB, ladoC;
Console.WriteLine("Digite o lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o lado C: ");
ladoC = Convert.ToDouble(Console.ReadLine());
if (ladoA == ladoB && ladoB == ladoC)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
//FIM_ALGORITMO_TIPO_TRIANGULO

//ALGORITMO_SITUACAO_ALUNO
double nota1, nota2, media;
double matricula;
Console.WriteLine("Digite a matrícula do aluno: ");
matricula = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
media = (nota1 + nota2) / 2;
if (media > 7)
{
    Console.WriteLine("Matrícula: " + matricula);
    Console.WriteLine("Aprovado");
}
else if (media <= 7)
{
    Console.WriteLine("Matrícula: " + matricula);
    Console.WriteLine("Se nota igual a 7, aluno em recuperação");
    Console.WriteLine("Reprovado");
}
//FIM_ALGORITMO_SITUACAO_ALUNO

//ALGORITMO_DESCONTO_CAMISA
double codigo;
double preco, desconto, precoComDesconto;
double tamanho, G, M, P;
Console.WriteLine("Digite o código da camisa: ");
codigo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o preço da camisa: ");
preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o tamanho da camisa (G, M, P): ");
tamanho = Convert.ToDouble(Console.ReadLine());
G = 0; M = 0; P = 0;
desconto = 1;
if (tamanho == G)
{
    desconto = preco * 0.10;
}
else if (tamanho == M)
{
    desconto = preco * 0.20;
}
else if (tamanho == P)
{
    desconto = preco *0.30;
}
precoComDesconto = preco - desconto;
Console.WriteLine("Código: "+ codigo);
Console.WriteLine(" Tamanho: " + tamanho);
Console.WriteLine("Preço sem desconto: R$ " + preco);
Console.WriteLine("Desconto: R$ " + desconto);
Console.WriteLine("Preço com desconto: R$ " + precoComDesconto);

//FIM_ALGORITMO_DESCONTO_CAMISA

//ALGORITMO_IMPOSTO_DE_RENDA
double salario, imposto;
Console.WriteLine("Digite o salário do funcionário: ");
salario = Convert.ToDouble(Console.ReadLine());
if (salario <= 1200)
{
    imposto = 0;
}
else
{
    if (salario > 1200 && salario <= 2500)
    {
        imposto = salario * 0.05;
    }
    else
    {
        if (salario > 2500 && salario <= 4000)
        {
            imposto = salario * 0.08;
        }
        else
        {
            if (salario > 4000 && salario <= 7000)
            {
                imposto = salario * 0.12;
            }
            else
            {
                imposto = salario * 0.275;
            }
        }
    }
}
Console.WriteLine("Salário: R$ " + salario);
Console.WriteLine("Imposto a ser pago: R$ " + imposto);

//FIM_ALGORITMO_IMPOSTO_DE_RENDA

//ALGORITMO_DIA_DA_SEMANA
double numero;
Console.WriteLine("Digite um número de 1 a 7: ");
numero = Convert.ToDouble(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("Domingo");
}
else if (numero == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (numero == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (numero == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (numero == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (numero == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (numero == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Número inválido");
}

//FIM_ALGORITMO_DIA_DA_SEMANA

//ALGORITMO_REAJUSTE_SALARIO
double salarioAtual, salarioReajustado;
double profissao, tecnico, gerente;
Console.WriteLine("Digite a profissão (Técnico, Gerente ou outro): ");
profissao = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o salário atual: ");
salarioAtual = Convert.ToDouble(Console.ReadLine());
tecnico = 1; gerente = 2;
if ( profissao == tecnico)
{
    salarioReajustado = salarioAtual + (salarioAtual * 1.15);
}
else if (profissao == gerente)
{
    salarioReajustado = salarioAtual + (salarioAtual * 1.13);
}
else
{
    salarioReajustado = salarioAtual + (salarioAtual * 1.11);
}
Console.WriteLine("Profissão: " + profissao);
Console.WriteLine("Salário atual: R$ " + salarioAtual);
Console.WriteLine("Salário reajustado: R$ " + salarioReajustado);

//FIM_ALGORITMO_REAJUSTE_SALARIO
