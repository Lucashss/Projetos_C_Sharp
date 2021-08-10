        double diametro, volume;

        Console.WriteLine("Volume da Esfera");

        Console.WriteLine("Digite o valor do diametro da esfera: ");
        diametro = int.Parse(Console.ReadLine());

        volume = 1.3333 * Math.PI * Math.Pow((diametro / 2), 3);

        Console.WriteLine("O volume da esfera é: {0}", volume.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();
