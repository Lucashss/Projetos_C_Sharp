        double valor1, valor2, media;

        Console.WriteLine("Média Geométrica");

        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        valor2 = double.Parse(Console.ReadLine());

        media = Math.Sqrt(valor1 * valor2);

        Console.WriteLine("A média geométrica é: {0}", media);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();