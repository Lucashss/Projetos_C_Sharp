        int diagonal, area;

        Console.WriteLine("Área do Quadrado através da Diagonal");

        Console.WriteLine("Digite o valor da diagonal em metros: ");
        diagonal = int.Parse(Console.ReadLine());

        
        area = (diagonal * diagonal) / 2;

        Console.WriteLine("O valor da area é: {0}", area);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();