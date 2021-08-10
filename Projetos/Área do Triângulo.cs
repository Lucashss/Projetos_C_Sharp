
        int altura, bas, area;

        Console.WriteLine("Área do Triângulo");

        Console.WriteLine("Digite o valor da base do triângulo: ");
        bas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura do triângulo: ");
        altura = int.Parse(Console.ReadLine());

        area = (bas * altura) / 2;

        Console.WriteLine("A area do triângulo é: {0}", area);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();