        double raio, altura, volume;

        Console.WriteLine("Volume do Cone");

        Console.WriteLine("Digite o valor da altura do cone: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do raio do cone: ");
        raio = double.Parse(Console.ReadLine());

        volume = 0.3333 * Math.PI * Math.Pow(raio, 2) * altura;

        Console.WriteLine("O volume do cone é: {0}", volume.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();