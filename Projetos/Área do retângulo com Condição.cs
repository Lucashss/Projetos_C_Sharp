        double bases, altura, area;

        Console.WriteLine("Área do retângulo com Condição");
        Console.WriteLine();

        Console.WriteLine("Digite o valor da base: ");
        bases = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o valor da altura: ");
        altura = double.Parse(Console.ReadLine());

        area = bases * altura;

        Console.WriteLine();
        Console.WriteLine("A área do retângulo é: {0}", area.ToString("N2"));

        if (area > 100)
        {
            Console.WriteLine();
            Console.WriteLine("Terreno grande");
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("Terreno pequeno");
        }

        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();