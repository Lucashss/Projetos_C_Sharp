        double r, i, u;

        Console.WriteLine("Lei de Ohm");

        Console.WriteLine("Digite o valor da resistência: ");
        r = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da corrente: ");
        i = double.Parse(Console.ReadLine());

        u = i * r;

        Console.WriteLine("O valor da tensão é: {0}", u);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();