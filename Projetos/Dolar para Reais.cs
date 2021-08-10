        double cotacao, valor, reais;

        Console.WriteLine("Dolar para Reais");

        Console.WriteLine("Digite o valor da cotação do dolar: ");
        cotacao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de dolares: ");
        valor = double.Parse(Console.ReadLine());

        reais = valor * cotacao;

        Console.WriteLine("O valor em Reais (R$) é: {0}", reais.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();