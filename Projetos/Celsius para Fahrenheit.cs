
        double celsius, fah;

        Console.WriteLine("Celsius para Fahrenheit");

        Console.WriteLine("Digite o valor em Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fah = (celsius * (9 / 5)) + 32;

        Console.WriteLine("O valor em Fahrenheit é: {0}", fah);

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();