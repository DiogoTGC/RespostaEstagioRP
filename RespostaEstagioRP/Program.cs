using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
        // escreva um programa na linguagem que desejar onde, informado um número,
        // ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência. 
        int? num = null;

        Console.WriteLine("Digite um número:");
        string? numeroEscolhido = Console.ReadLine();

        try
        {
            num = Convert.ToInt32(numeroEscolhido);

            string reposta = (ChecaNumeroEstaFibonacci(num)) ? $"O número { num } está na sequência de Fibonacci"
                                                             : $"O número { num } não está na sequência de Fibonacci";
            Console.WriteLine(reposta);
        }
        catch (Exception)
        {
            Console.WriteLine($"{numeroEscolhido} não é um número.");
        }


        // 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.
        string? frase = "";

        while (frase == "")
        { 
            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
        }

        int quantidadeLetraA = ChecaQuantidadeLetraA(frase);

        if (quantidadeLetraA > 0)
        {
            Console.WriteLine($"A letra A sendo maiúscula ou minúscula apareceu {quantidadeLetraA} vezes.");
        }
        else
        {
            Console.WriteLine($"A letra A sendo maiúscula ou minúscula não apareceu nenhuma vez.");
        }


        // 3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA); 
        int indice = 12, soma = 0;

        for (int k = 1; k < indice; k++)
        {
            soma += k;
        }

        Console.WriteLine(soma);
    }
    private static bool ChecaNumeroEstaFibonacci(int? numero)
    {
        int primeiroNumero = 0;
        int segundoNumero = 1;
        
        int aux = 0;

        while (true)
        {
            aux = primeiroNumero + segundoNumero;

            if (primeiroNumero == numero) return true;

            if (primeiroNumero > numero) return false;

            if (primeiroNumero < numero)
            {
                primeiroNumero = segundoNumero;
                segundoNumero = aux;
            }
        }
    }

    private static int ChecaQuantidadeLetraA(string frase)
    {
        int quantidadeVezesAparece = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'A' || frase[i] == 'a')
            {
                quantidadeVezesAparece += 1;
            }
        }

        return quantidadeVezesAparece;
    }

}