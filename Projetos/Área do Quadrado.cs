        int aresta, area;

        Console.WriteLine("Área do Quadrado");

        Console.WriteLine("Digite o valor da aresta do quadrado: ");
        aresta = int.Parse(Console.ReadLine());

        area = aresta * aresta;

        Console.WriteLine("A area do quadrado é: {0}", area);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();