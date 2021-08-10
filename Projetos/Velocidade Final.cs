        double vi, a, t, vf;

        Console.WriteLine("Velocidade Final");

        Console.WriteLine("Digite o valor da velocidade inicial: ");
        vi = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da aceleração: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do tempo de percurso: ");
        t = double.Parse(Console.ReadLine());

        vf = (vi + (a * t)) * 3.6;

        Console.WriteLine("A velicidade final do automóvel é: {0}", vf.ToString("N2"));

        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();