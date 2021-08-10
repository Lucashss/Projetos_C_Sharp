        float valor1, valor2, valor3, valor4, media;

        Console.WriteLine("Média Aritmética");

        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor: ");
        valor3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o quarto valor: ");
        valor4 = float.Parse(Console.ReadLine());

        media = (valor1 + valor2 + valor3 + valor4) /4;

        Console.WriteLine("A média aritmética é: {0}", media.ToString());

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();