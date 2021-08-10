        double milha, calculo;

        Console.WriteLine("Milha Marítima para Quilômetros");

        Console.WriteLine("Digite o valor em milha marítima: ");
        milha = double.Parse(Console.ReadLine());


        calculo = milha * 1.852;

        Console.WriteLine("O valor em quilômetros é: {0}", calculo);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();