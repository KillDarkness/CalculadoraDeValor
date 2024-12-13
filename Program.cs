using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Conversor de Unidades Avançado";
        while (true)
        {
            MostrarMenuPrincipal();
            int escolha = LerEscolha(1, 4);

            switch (escolha)
            {
                case 1:
                    ConverterTemperatura();
                    break;
                case 2:
                    ConverterDistancia();
                    break;
                case 3:
                    ConverterPeso();
                    break;
                case 4:
                    Sair();
                    return;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void MostrarMenuPrincipal()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n************** Conversor de Unidades Avançado **************\n");
        Console.ResetColor();
        Console.WriteLine("Escolha uma categoria de conversão:\n");
        Console.WriteLine("1 - Temperatura");
        Console.WriteLine("2 - Distância");
        Console.WriteLine("3 - Peso");
        Console.WriteLine("4 - Sair\n");
        Console.WriteLine("************************************************************\n");
    }

    static int LerEscolha(int min, int max)
    {
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < min || escolha > max)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida! Tente novamente: ");
            Console.ResetColor();
        }
        return escolha;
    }

    static void ConverterTemperatura()
    {
        Console.Clear();
        Console.WriteLine("\nConverter Temperatura:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Celsius para Kelvin\n");

        int escolha = LerEscolha(1, 3);

        Console.WriteLine("Digite o valor da temperatura:");
        double valor = LerDouble();
        double resultado = 0;
        string unidade = "";

        switch (escolha)
        {
            case 1:
                resultado = (valor * 9 / 5) + 32;
                unidade = "°F";
                break;
            case 2:
                resultado = (valor - 32) * 5 / 9;
                unidade = "°C";
                break;
            case 3:
                resultado = valor + 273.15;
                unidade = "K";
                break;
        }

        ExibirResultado(valor, resultado, unidade);
    }

    static void ConverterDistancia()
    {
        Console.Clear();
        Console.WriteLine("\nConverter Distância:");
        Console.WriteLine("1 - Quilômetros para Milhas");
        Console.WriteLine("2 - Milhas para Quilômetros");
        Console.WriteLine("3 - Metros para Pés\n");

        int escolha = LerEscolha(1, 3);

        Console.WriteLine("Digite o valor da distância:");
        double valor = LerDouble();
        double resultado = 0;
        string unidade = "";

        switch (escolha)
        {
            case 1:
                resultado = valor * 0.621371;
                unidade = "milhas";
                break;
            case 2:
                resultado = valor / 0.621371;
                unidade = "quilômetros";
                break;
            case 3:
                resultado = valor * 3.28084;
                unidade = "pés";
                break;
        }

        ExibirResultado(valor, resultado, unidade);
    }

    static void ConverterPeso()
    {
        Console.Clear();
        Console.WriteLine("\nConverter Peso:");
        Console.WriteLine("1 - Quilogramas para Libras");
        Console.WriteLine("2 - Libras para Quilogramas");
        Console.WriteLine("3 - Quilogramas para Onças\n");

        int escolha = LerEscolha(1, 3);

        Console.WriteLine("Digite o valor do peso:");
        double valor = LerDouble();
        double resultado = 0;
        string unidade = "";

        switch (escolha)
        {
            case 1:
                resultado = valor * 2.20462;
                unidade = "libras";
                break;
            case 2:
                resultado = valor / 2.20462;
                unidade = "quilogramas";
                break;
            case 3:
                resultado = valor * 35.274;
                unidade = "onças";
                break;
        }

        ExibirResultado(valor, resultado, unidade);
    }

    static void ExibirResultado(double valor, double resultado, string unidade)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nResultado: {valor} => {resultado} {unidade}\n");
        Console.ResetColor();
    }

    static double LerDouble()
    {
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida! Digite um número válido: ");
            Console.ResetColor();
        }
        return valor;
    }

    static void Sair()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Obrigado por usar o Conversor de Unidades! Até a próxima.");
        Console.ResetColor();
    }
}
