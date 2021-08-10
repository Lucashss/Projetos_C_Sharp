        double diametro, area;

        Console.WriteLine("Área do Círculo");

        Console.WriteLine("Digite o valor da resistência: ");
        diametro = double.Parse(Console.ReadLine());

        area = Math.PI * Math.Pow((diametro/2), 2) ;

        Console.WriteLine("A área do círculo é: {0}", area.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();