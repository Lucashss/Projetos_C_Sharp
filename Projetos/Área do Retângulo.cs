	int altura, bas, area;


	Console.WriteLine("Área do Retângulo");

        Console.WriteLine("Digite o valor da base do retângulo: ");
        bas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura do retângulo: ");
        altura = int.Parse(Console.ReadLine());

        area = bas * altura;

        Console.WriteLine("A area do retângulo é: {0}", area);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();