        double r, a, volume;

        Console.WriteLine("Volume Livre");

        Console.WriteLine("Digite o valor do raio: ");
        r = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da aresta: ");
        a = double.Parse(Console.ReadLine());

        volume = ((a * a * a) - ((1.3333) * Math.PI * Math.Pow(r, 3)));

        Console.WriteLine("O volume livre é: {0}", volume.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();